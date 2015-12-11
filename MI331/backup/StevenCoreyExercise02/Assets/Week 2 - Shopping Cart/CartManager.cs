using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class CartManager : MonoBehaviour {

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


	public void updatePrices()
	{
        float subtotal = item1.cost + item2.cost + item3.cost;
        subtotalText.text = "$" +subtotal.ToString();

        float tax = subtotal * .06f;
        taxText.text = "$" + tax.ToString();

        float total = subtotal + tax;
        totalText.text = "$" + total.ToString();


	}
}