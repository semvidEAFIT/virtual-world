using UnityEngine;
using System.Collections;

[RequireComponent (typeof (CharacterController))]
public class Motion : MonoBehaviour {
	public float speed = 200;
	private CharacterController controller;
	// Use this for initialization
	void Start () {
		controller = gameObject.GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	/// <summary>
	/// Move the specified movement.
	/// </summary>
	/// <param name='movement'>
	/// Movement represented in a vector with both values clamped between -1 and 1
	/// </param>
	public void Move(Vector2 movement){
		controller.SimpleMove(new Vector3(movement.x, 0, movement.y) * Time.deltaTime * speed);
	}
}
