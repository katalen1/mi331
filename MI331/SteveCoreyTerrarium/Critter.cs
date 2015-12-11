using UnityEngine;
using System.Collections;

public class Critter : MonoBehaviour {
	
	protected Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		rb= GetComponent<Rigidbody2D> ();
		setVelocity();
	}
	
	public virtual void setVelocity(){
		rb.velocity = new Vector2 (1,0);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
