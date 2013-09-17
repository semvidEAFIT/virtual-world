using UnityEngine;
using System.Collections;

[RequireComponent (typeof(Motion))]
public abstract class Warrior : MonoBehaviour, ICaster {
	
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
	
	#region ICaster implementation
	public GameObject GetGameObject ()
	{
		return this.gameObject;
	}

	public abstract void Execute (Spell spell);
	#endregion
}
