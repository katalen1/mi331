using UnityEngine;
using System.Collections;

public class Scorpion : Critter {

	public override void setVelocity(){
		rb.velocity = new Vector2(-0.1f, 0);
	}
}