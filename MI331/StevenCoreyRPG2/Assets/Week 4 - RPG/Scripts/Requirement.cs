using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Requirement : MonoBehaviour {

		public Text labelsText ;

		public Text  valuesText;
		public int   value;
		
		public Attribute attribute;

		// Use this for initialization
		void Start () {
			
		}
		
		// Update is called once per frame
		void Update () {
			
		}

		public bool isRequirementMet(){
			return attribute.value >= value;
		}
		
		public void updateText(){
			valuesText.text = value.ToString();
		}

}
