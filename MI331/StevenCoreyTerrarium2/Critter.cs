using UnityEngine;
using System.Collections;

public class Critter : MonoBehaviour {
	
	protected Rigidbody2D rb;
	
	public Sprite basicImage;
	public Sprite selectedImage;

	// Use this for initialization
	void Start () {
		rb= GetComponent<Rigidbody2D> ();
		setVelocity();
	}
	
	public virtual void setVelocity(){
		
		float startX = Random.Range (-Wrangler.halfWidth,Wrangler.halfWidth);
		float startY = Random.Range (-2f,Wrangler.halfHeight); //seeing as it flies it should be off the ground
		transform.position = new Vector2(startX,startY);
		
		float randomVel = Random.Range(-2f,2f);
		rb.velocity = new Vector2 (randomVel,0);
	}
	
	public void SetSprite(Sprite sprite){
		GetComponent<SpriteRenderer> ().sprite = sprite;
	}
	
	protected void OnMouseDown(){
		Critter otherOne = Wrangler.selectedCritter;
		
		if(otherOne){
			otherOne.SetSprite(otherOne.basicImage);
		}
		
		Wrangler.selectedCritter = this;
		
		SetSprite(selectedImage);
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position.x > Wrangler.halfWidth){ //right side
			transform.position = new Vector2(-Wrangler.halfWidth, transform.position.y);
		}
		if(transform.position.x < -Wrangler.halfWidth){ //left side
			transform.position = new Vector2(Wrangler.halfWidth, transform.position.y);
		}
		if(transform.position.y > Wrangler.halfHeight){ //top
			transform.position = new Vector2(transform.position.x, -Wrangler.halfHeight);
		}
		if(transform.position.y < -Wrangler.halfHeight){ //bottom
			transform.position = new Vector2(transform.position.x, Wrangler.halfHeight);
		}
	}
}
