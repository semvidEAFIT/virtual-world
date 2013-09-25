using UnityEngine;
using System.Collections;

/// <summary>
/// Script that moves the player around a fixed target according to two axis, one 
/// to rotate around and other to move forward and backward.
/// </summary>
[RequireComponent(typeof(CharacterController))]
public class Motion : MonoBehaviour {
	
	public Transform target;
	public float vertSpeed;
	public float horSpeed;
	private CharacterController characterController;
	
	void Awake(){
		characterController = GetComponent<CharacterController>();
	}
	
	void Update(){
		if(target != null){
            Vector3 lookingPoint = target.position;
            lookingPoint.y = transform.position.y;
			transform.LookAt(lookingPoint);
		}
	}
	
	public void Move(float horizontal, float vertical){
		if(target == null){
			throw new System.Exception(this.name+" has no target");
		}
		characterController.SimpleMove(transform.forward*vertical*vertSpeed+ transform.right*horizontal*horSpeed);
	}
}
