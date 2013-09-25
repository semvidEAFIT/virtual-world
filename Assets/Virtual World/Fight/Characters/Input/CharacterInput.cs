using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Character))]
public class CharacterInput : MonoBehaviour {

    public Joystick input;
    private Character character;

	void Awake(){
        character = GetComponent<Character>();
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
