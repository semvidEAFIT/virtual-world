using UnityEngine;
using System.Collections;

public interface ICaster 
{
	GameObject GetGameObject();
	void Execute(Spell spell);
}