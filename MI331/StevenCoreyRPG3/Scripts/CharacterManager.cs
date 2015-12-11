using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class CharacterManager : MonoBehaviour {
	
	public Sprite[] images= new Sprite[4];
	public string[] imagesNames = new string[4];
	public string[] profNames = new string [3];
	public string[] profDescrip = new string [3];
	public string[] profImgNames = new string [3];
	public Image portraitImage;
	public int currentImage=0;

    public GameObject attributePrefab;
    public GameObject attributeArea;
	
	public GameObject professionPrefab;
    public GameObject professionArea;
	
	public Profession selectedProfession;
	
	public Attribute[] attributes;
	public Profession[] professions;

	
	public Pool pool;
	
	public Profession profession1;
	public Profession profession2;
	public Profession profession3;

	
	Sprite CreateSprite(string spriteName){
		Sprite sprite= Instantiate(Resources.Load<Sprite>(spriteName) as Sprite);
		return sprite;
	}
	// Use this for initialization
	void Start () {
		string[] imagesNames = new string[3] {"portrait01","portrait02","portrait03"};
		
		for(int i =0; i<imagesNames.Length; i++){
			images [i] = CreateSprite(imagesNames[i]);
		}
		
		portraitImage.sprite = images[0];
       
		//profession1 = createProfession("Journalism", "Enjoy writing? Major in Journalism!", "profession01",new int[3]{12,12,12});
		//profession2 = createProfession("Chemistry", "Enjoy science? Major in Chemistry!", "profession02", new int[]{});
		//profession3 = createProfession("Computer Science", "Enjoy both math and computers? Major in Computer Science!", "profession03", new int[]{});
		
		attributes = new Attribute[3];
		attributes[0] = createAttribute("English", 12, 12,12);
		attributes[1] = createAttribute("Science", 12, 12,12);
		attributes[2] = createAttribute("Math", 12, 12,12);
		
		professions = new Profession[3];
		professions[0] = createProfession("Journalism", "Enjoy writing? Major in Journalism!", "profession01", new int[3]{15,10,10});
		professions[1] = createProfession("Chemistry", "Enjoy science? Major in Chemistry!", "profession02", new int[3]{12,15,12});
		professions[2] = createProfession("Computer Science", "Enjoy both math and computers? Major in Computer Science!", "profession03", new int[3]{9,14,15});
		
    }
	
	Profession createProfession(string name, string description, string imgName, int[] minRequirement){
		GameObject go = Instantiate<GameObject> (professionPrefab);
		go.transform.parent = professionArea.transform;
		
		
		Profession profession = go.GetComponent<Profession>();
		
		
		profession.characterManager = this;
		
		profession.labelString = name;
		profession.descriptionString = description;
		profession.imgName = imgName;
		
		for(int j = 0; j<minRequirement.Length; j++){
			profession.requirements[j] = profession.CreateRequirement(attributes[j], minRequirement[j]);
		}
		
		
		return profession;
	}

    Attribute createAttribute(string type, int value, int value2, int value3)
    {
        GameObject go = Instantiate<GameObject> (attributePrefab);
        go.transform.parent = attributeArea.transform;

        //get the item script from the item object
        // < > indicate a variable type
        //The following code will get a component of type 'Attribute' from go
        Attribute attribute = go.GetComponent<Attribute>();

        //set the manager to character manager. "this" is the current object running the script
        attribute.CharacterManager = this;

        //Setting the attributes's name
        attribute.labelString = type;

        //Set the attributes value
        attribute.value = value;
		attribute.pool = pool;
 


        return attribute;
    }

	
	// Update is called once per frame
	void Update () {
	
	}


		
	public void next()
	{
		currentImage++;
		if(currentImage == images.Length){
			currentImage=0;
		}
		updatePortrait();
	}
	public void prev()
	{
		currentImage--;
		if(currentImage < 0){
			currentImage = (images.Length)-1;
		}
		updatePortrait();
	}
	
	public void updatePortrait(){
		portraitImage.sprite = images[currentImage];
	}

	void previous()
	{

	}
}

