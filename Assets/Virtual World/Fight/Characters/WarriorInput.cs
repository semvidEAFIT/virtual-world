using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Warrior))]
public class WarriorInput : MonoBehaviour {

    public Joystick input;
    private Warrior character;

	void Awake(){
        character = GetComponent<Warrior>();
	}
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 movement = input.Value;
        if(movement != Vector2.zero){
            character.Move(movement.x, movement.y);
        }
	}
}
