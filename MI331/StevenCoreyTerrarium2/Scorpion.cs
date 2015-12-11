using UnityEngine;
using System.Collections;

public class Scorpion : Critter {

	public override void setVelocity(){
		
		float scorpX = Random.Range (-Wrangler.halfWidth,Wrangler.halfWidth);
		float scorpY = Random.Range (-Wrangler.halfHeight,-3.5f);
		transform.position = new Vector2(scorpX,scorpY);
		
		float randomVel = Random.Range(-0.5f,0.5f);
		rb.velocity = new Vector2 (randomVel,0);
	}
}