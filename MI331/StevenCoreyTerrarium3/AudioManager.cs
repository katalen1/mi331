using UnityEngine;
using System.Collections;

public class AudioManager : MonoBehaviour {
	
	public AudioSource backgroundLoop;

	// Use this for initialization
	void Start () {
	
	}
	
	public void Pause(){
		backgroundLoop.Pause();
	}
	
	public void Play(){
		backgroundLoop.Play();
	}
	
	public void Increase(){
		backgroundLoop.volume += 0.1f;
	}
	
	public void Decrease(){
		backgroundLoop.volume -= 0.1f;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
