using UnityEngine;
using System.Collections;

[RequireComponent (typeof(Motion))]
public abstract class Character : MonoBehaviour {
	
	private Motion motion;
	
	void Awake(){
		motion = GetComponent<Motion>();
	}
	
	void Start () {
	
	}
	
	void Update () {
	
	}
	
	public void Move(float horizontal, float vertical){
		motion.Move(horizontal, vertical);
	}
}
