using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Attribute : MonoBehaviour {

    public Text labelText;
	public Text valueText;

    public int value = 12;
    public int max = 18;
    public int min = 6;
    public string labelString;

    public Color disabled = Color.grey;
    public Color enabled = Color.black;

	public Pool pool;

    public CharacterManager CharacterManager { get; internal set; }

    // Use this for initialization
    void Start () {
        labelText.text = labelString;
        updateValueText();
	}



	// Update is called once per frame
	void Update () {
	
	}

	public void increase()
	{
        if(value < max && pool.value != 0)
        {
            value++;
            pool.decrease();
        }

        updateValueText();
	}

	public void decrease()
	{
        if(value > min)
        {
            value--;
            pool.increase();
        }

        updateValueText();
	}

	public void updateValueText() {
        valueText.text = value.ToString();

        if (value == min || value == max)
            valueText.color = disabled;
        else
            valueText.color = enabled;
	}
}