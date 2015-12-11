using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class CharacterManager : MonoBehaviour {

    public GameObject attributePrefab;
    public GameObject attributeArea;

    public Attribute attribute1;
	public Attribute attribute2;
	public Attribute attribute3;

	// Use this for initialization
	void Start () {
        attribute2 = createAttribute("Dexterity", 12);
        attribute3 = createAttribute("Knowledge", 12);

    }

    Attribute createAttribute(string type, int value)
    {
        GameObject go = Instantiate(attributePrefab);
        go.transform.parent = attributeArea.transform;

        //get the item script from the item object
        // < > indicate a variable type
        //The following code will get a component of type 'Attribute' from go
        Attribute attributeScript = go.GetComponent<Attribute>();

        //set the manager to character manager. "this" is the current object running the script
        attributeScript.CharacterManager = this;

        //Setting the attributes's name
        attributeScript.labelString = type;

        //Set the attributes value
        attributeScript.value = value;
 


        return attributeScript;
    }

	
	// Update is called once per frame
	void Update () {
	
	}


		
	void next()
	{

	}

	void previous()
	{

	}
}

