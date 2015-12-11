using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Profession : MonoBehaviour {
	public Text labelText;
	public Text descriptionText;
	
	public Requirement[] requirements = new Requirement[3];
	public GameObject requirementArea;
	public GameObject requirementPrefab;
	
	public string labelString = "WoodCutter";
	public string descriptionString = "I'm a woodcutter and I'm ok....";
	public string imgName = "";
	
	
	
	public Image image;
	public Image imageBackground;
	
	public Color rowSelected = Color.yellow;
	public Color rowDisabled = Color.red;
	public Color rowNormal = Color.grey;
	
	Sprite CreateSprite(string spriteName){
		Sprite sprite= Instantiate(Resources.Load<Sprite>(spriteName) as Sprite);
		return sprite;
	}
	public CharacterManager characterManager;
	
	public CharacterManager CharacterManager { get; internal set; }

	// Use this for initialization
	void Start () {
		labelText.text = labelString;
		descriptionText.text = descriptionString;
		image.sprite = CreateSprite(imgName);
		updateRowColor();
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void doClick(){
		if(isSelected()){
			return; //do nothing
		}else{
			if(areRequirementsMet()){
				if(areAnyProfessionSelected()){
					Profession otherOne = GetSelected();
					otherOne.SetSelected(false);
					otherOne.updateRowColor();
				}
			}
			
			SetSelected(true);
			updateRowColor();
		}
		
	}
	
	public bool areRequirementsMet(){
		bool result = true;
		
		Profession profession = GetSelected();
		
		for(int i =0; i<requirements.Length; i++){
			result = requirements[i].isRequirementMet();
			
			if(result == false){break;} //if one requirement is not met, break because it must meet all requirements
		}
		
		return result;
	}

	public bool isSelected(){
		bool result = true;
		
		if(GetSelected() == this){
			result = true;
		}else{
			result = false;
		}
		
		return result;
	}
	
	public bool areAnyProfessionSelected(){
		bool result = true;
		
		if(GetSelected() == null){
			result = false;
		}else{
			result = true;
		}
		
		return result;
	}
	
	public Profession GetSelected(){
		//Profession profession = new Profession ();
		//return profession;
		
		return characterManager.selectedProfession;
	}
	
	public void updateRowColor(){
		if(areRequirementsMet() == false){
			imageBackground.color = rowDisabled;
		}else if(isSelected()){
			imageBackground.color = rowSelected;
		}else{
			imageBackground.color= rowNormal;
		}
	}
	
	public void SetSelected(bool selected){
		if(selected){
			characterManager.selectedProfession = this;
		}else{
			characterManager.selectedProfession = null;
		}
		
	}
	public Requirement CreateRequirement (Attribute attribute, int min)
	{
		GameObject go = Instantiate<GameObject> (requirementPrefab);
		
		go.transform.parent = requirementArea.transform;
		Requirement requirement = go.GetComponent<Requirement> ();
		requirement.attribute = attribute;
		requirement.value = min;
		requirement.labelsText.text = attribute.labelString;
		requirement.updateText ();
		
		return requirement;
	}

}
