using UnityEngine;
using System.Collections;

public class Tank : Warrior {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	#region implemented abstract members of Warrior
	public override void Execute (Spell spell)
	{
		throw new System.NotImplementedException ();
	}
	#endregion
}
