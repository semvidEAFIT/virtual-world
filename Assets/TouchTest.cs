using UnityEngine;
using System.Collections;

public class TouchTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)){
			Debug.Log(0);
			renderer.material.color = Color.red;
		}
		if(Input.GetMouseButtonDown(1)){
			Debug.Log(1);
			renderer.material.color = Color.green;
		}
	}
}
