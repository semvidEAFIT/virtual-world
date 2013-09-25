using UnityEngine;
using System.Collections;

public class Zone : MonoBehaviour {

    private static Zone instance;
    private bool inFight = false;

    public static Zone Instance
    {
        get { return Zone.instance; }
    }

	void Awake () {
        if (instance == null)
        {
            instance = this;
        }
        else 
        {
            Debug.Log("Two or more Zones were instanced");
            Destroy(this);
        }
        DontDestroyOnLoad(this);
	}
	
	void Update () {
	    
	}

    void OnGUI() { 
        if(inFight){
            return;
        }
        if(GUI.Button(new Rect(0,0, 150.0f, 100.0f), "Fight")){
            inFight = true;
            Application.LoadLevel("Landscape1");
        }
    }
}
