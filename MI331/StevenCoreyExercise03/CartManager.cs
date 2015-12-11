using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class CartManager : MonoBehaviour {

    public GameObject itemPrefab;
    public GameObject itemArea;

	public Item item1;
	public Item item2;
	public Item item3;


	public Text welcomeNameText;
    public Text subtotalText;
    public Text taxText;
    public Text totalText;
    public InputField firstNameInput;
    public InputField lastNameInput;



    // Use this for initialization
    void Start () {

       item1 = createItem("Flour", 2.49f, "Basic flour for cooking needs");
       item2 = createItem("Cooking Sheet", 9.90f, "Cooking sheet to use in an oven");
       item3 = createItem("Frosting", 1.85f, "Frosting to top deserts");

    }

    Item createItem(string type, float price, string description) {
        GameObject go = Instantiate(itemPrefab);
        go.transform.parent = itemArea.transform;

        //get the item script from the item object
        // < > indicate a variable type
        //The following code will get a component of type 'Item' from go
        Item itemScript = go.GetComponent<Item>();

        //set the manager to cart manager. "this" is the current object running the script
        itemScript.cartManager = this;

        //Setting the item's name
        itemScript.itemName = type;

        //Set the item's price
        itemScript.price = price;

        //Set the item's description
        itemScript.itemDescription = description;


        return itemScript;
    }
	
	// Update is called once per frame
	void Update () {
        updatePrices();
    }

	public void updateName()
	{
        string str = "Welcome ";
        string firstName = firstNameInput.text;
        string lastName = lastNameInput.text;
        welcomeNameText.text = str + " " + firstName + " " + lastName;
	}


    //function to take a float value, add a '$', and return a string
    public String floatToString(float invalue) {
        String floatvalue = invalue.ToString();
        floatvalue = "$" + floatvalue;

        return floatvalue;

    }

	public void updatePrices()
	{
        float subtotal = item1.cost + item2.cost + item3.cost;
        subtotalText.text = floatToString(subtotal);

        float tax = subtotal * .06f;
        taxText.text = floatToString(tax);

        float total = subtotal + tax;
        totalText.text = floatToString(total);


	}
}