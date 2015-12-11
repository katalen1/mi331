using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class Item : MonoBehaviour {
	public CartManager cartManager; 
	public InputField firstNameInput;
	public InputField lastNameInput;

    //add item name and description variables here
    public Text itemNameText;
    public string itemName;
    public Text itemDescriptionText;
    public string itemDescription;


    //Add number variables here
    public Text priceText;
    public Text costText;
    public InputField quantityText;

    public float price = 19.95f;
    public float cost = 0f;
    public int quantity = 1;

	//Add image varaibles here


	// Use this for initialization
	
	void Start () {
        itemNameText.text = itemName;
        itemDescriptionText.text = itemDescription;

        priceText.text = "$" + price.ToString();

        updateCost();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void updateCost()
	{
        // Here is what we want the code to do:
        // 1. Get the values quanitity objects
        // 2. multiply price by the quantities
        // 3. update the cost text 
        // This is the order the code will be in its final form
        // However, we are going to start with the middle stel

        quantity = int.Parse(quantityText.text);

        cost = price * quantity;
        costText.text = "$" + cost.ToString();

	}
	
}
