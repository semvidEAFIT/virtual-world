using UnityEngine;
using System.Collections;

public class Joystick : MonoBehaviour
{

    public Vector2 downLeft;
    public float radius;
    public Texture2D guiImage;
    public bool matchScreen = false;
    private Rect zone;
    private Touch inJoystick;
    private bool used = false;

    private Vector2 value = Vector2.zero;
    public Vector2 Value
    {
        get { return this.value; }
    }

    void Awake()
    {
        if (matchScreen)
        {
            radius = guiImage.height / 2;
            zone = new Rect(0, 0, guiImage.width, guiImage.height);
        }
        else
        {
            zone = new Rect(downLeft.x, downLeft.y, radius * 2, radius * 2);
        }
    }

    // Use this for initialization
    void Start()
    {
        /*Debug.Log(zone);
        Debug.Log(zone.center);*/
    }

    // Update is called once per frame
    void Update()
    {
#if UNITY_ANDROID || UNITY_IPHONE
        value = Vector2.zero;
        foreach (Touch t in Input.touches)
	    {
            if(used && inJoystick.fingerId == t.fingerId){
                switch (t.phase)
                {
                    case TouchPhase.Began:
                        throw new System.Exception("Found new touch while using.");
                    case TouchPhase.Canceled:
                    case TouchPhase.Ended:
                        used = false;
                        break;
                    case TouchPhase.Moved:
                        Vector2 distance = t.position - zone.center;
                        value = new Vector2(Mathf.Clamp(distance.x/radius, -1.0f, 1.0f), Mathf.Clamp(distance.y/radius, -1, 1));
                        break;
                    case TouchPhase.Stationary:
                        break;
                    default:
                        break;
                }
                break;
            }else{
                Vector2 distance = t.position - zone.center;
                if(distance.sqrMagnitude < radius*radius && t.phase == TouchPhase.Began){
                    inJoystick = t;
                    used = true;
                    break;
                }
            }
            //Debug.Log(t.position);
        }
#else
        Vector2 distance = (Vector2)Input.mousePosition - zone.center;
        if (Input.GetMouseButton(0))
        {
            if(distance.sqrMagnitude < radius * radius){
                value = new Vector2(Mathf.Clamp(distance.x / radius, -1.0f, 1.0f), Mathf.Clamp(distance.y / radius, -1.0f, 1.0f));
            }
        }
        else
        {
            value = Vector2.zero;
        }
        //Debug.Log(Input.mousePosition);
#endif
        //Debug.Log(value);
    }

    void OnGUI()
    {
        Rect zoneGUI = new Rect(zone.x, Screen.height - zone.height, zone.width, zone.height);
        GUI.Button(zoneGUI, guiImage);
    }
}
