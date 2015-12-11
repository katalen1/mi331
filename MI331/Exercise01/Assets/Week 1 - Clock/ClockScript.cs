using UnityEngine;
using System.Collections;

/*
 * We'll cover classes later on.  For now, consider them to be reusable templates with 
 * common set of functionality. For example, you would expect all of the cars in your app
 * to have very similiar functionality.
*/

public class ClockScript : MonoBehaviour {
	/*
	 * At the start of a class, we list out the information the class knows about.
	* These bits of information are called "properties"
	* "public" means this property is visible to other classes.  GameObject refer what type of 
	* property the object knows about. We'll be working with GameObjects and numbers for this assignment.  
	* Throughout this course, you'll learn more about properties and types.
	*/

	public GameObject bigHand;
    public GameObject littleHand;
    private float hoursToMinutes = 1 / 60f;
    private int speedVariable = 70;

    /*  Update is a special Unity function that gets run repeatedly every time the app gets refreshed.  
     *  This refresh is called a "frame"  Typically, Unity runs at 30 to 60 times per second.  The frames updated per second, or FPS, can be controlled
     *  numerous factors, including application settings and the complexity of your scene.  
     */
    void Update () {

		/*
		 * Simple Rorate takes a GameObject (e.g. bigHand) and rotates by a small amount 
		 * please see the following referrence on Time.deltaTime: http://docs.unity3d.com/ScriptReference/Time-deltaTime.html
		*/
		simpleRotate (bigHand, -Time.deltaTime * speedVariable);



        //todo: add code for the little hand here.
        simpleRotate(littleHand, hoursToMinutes * -Time.deltaTime * speedVariable);
    }
	//I wrote this function here to make the exercise easier to understand. You don't need to understand this yet.  
	void simpleRotate(GameObject obj, float amount)
	{
		obj.transform.Rotate(0, 0, amount);
	}
}
