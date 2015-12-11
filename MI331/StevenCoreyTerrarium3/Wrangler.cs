using UnityEngine;
using System.Collections;

public class Wrangler : MonoBehaviour {
	
	public static float halfWidth = 6;
	public static float halfHeight =5;
	public static Critter selectedCritter;

	public GameObject critterPrefab;
	public GameObject scorpPrefab;
	
	int critterCount = 0; //how many critters have been created
	int critterMax = 5; //max number of critters
	float critterSpawnTime = 1f; //time between critter spawns
	
	
	
	
	// Use this for initialization
	void Start () {
		StartCoroutine("SpawnVulture");
		StartCoroutine("SpawnScorpion");
	}
	
	IEnumerator SpawnVulture(){
		while(critterCount < critterMax){
			CreateVulture();
			yield return new WaitForSeconds(1.0f);
		}
	}
	IEnumerator SpawnScorpion(){
		while(critterCount<critterMax){
			CreateScorpion();
			yield return new WaitForSeconds(1.0f);
		}
	}
	
	void CreateVulture(){
		critterCount++;
		Instantiate(critterPrefab);
	}
	
	void CreateScorpion(){
		critterCount++;
		Instantiate(scorpPrefab);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
