using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Pool : MonoBehaviour {
	
	public Text labelText;
	public Text valueText;

    public int value = 3;
    public string labelString = "Remaining Points";

    public Color disabled = Color.red;
    public Color enabled = Color.black;

	// Use this for initialization
	void Start () {
        labelText.text = labelString;
        updateValueText();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void decrease()
	{
        value--;
        updateValueText();
	}

	public void increase(){
        value++;
        updateValueText();

	}

	public void updateValueText()
	{
        valueText.text = value.ToString();

        if (value == 0)
            valueText.color = disabled;
        else
            valueText.color = enabled;
	}
}
