using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Motion))]
public class Character : MonoBehaviour {
	
	private Vector2 moveDir;
	private Motion motion;
	
	// Use this for initialization
	void Start () {
		motion=gameObject.GetComponent<Motion>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey("w")){
			moveDir.y=1;
		} else{
			if(Input.GetKey("s")){
				moveDir.y=-1;
			} else {
				moveDir.y=0;
			}
		}
		
		if (Input.GetKey("d")){
			moveDir.x=1;
		} else{
			if(Input.GetKey("a")){
				moveDir.x=-1;
			} else {
				moveDir.x=0;
			}
		}
		
		motion.Move(moveDir);
	}
}
