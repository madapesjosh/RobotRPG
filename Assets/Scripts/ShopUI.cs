using UnityEngine;
using System.Collections;

public class ShopUI : MonoBehaviour {
	
	//The left start of the shop background
	public float shopBackgroundLeftStart;
	
	//The top start of the shop background
	public float shopBackgroundRightStart;
	
	//The length of the shop background
	public float shopBackgroundLength;
	
	//The height of the shop background
	public float shopBackroundHeight;
	
	// The picute for the wepons category
	public Texture2D generalWeaponPicture;
	
	// The name for the weapons category
	public string weaponsCategory;

	// The description for the weapons category
	public string weaponsCatergoryDescription;
	
	//Price is zero for a category
	public int categoryPrice;
	
	//The picture for the powers category
	public Texture2D generalPowerPicture;
	
	//The name for the powers category
	public string powersCategory;
	
	// The description for the powers category
	public string powersCategoryDescription;
	
	// The picture of the first weapon
	public Texture2D firstWeaponPicture;
	
	// The name of the first weapon
	public string firstWeaponName;
	
	// The description of the frist weapon
	public string fristWeaponDescription;
	
	// The picture of the first power
	public Texture2D firstPowerPicture;
	
	// The name of the first power
	public string firstPowerName;
	
	// The description of the first power
	public string firstPowerDescription;
	
	// The price of the first power
	public int firstPowerPrice;
	
	// The text on a button to enter a category
	public string categoryButtonText;
	
	// The text on a button to buy something
	public string buyText;

	//The main GUI Skin
	public GUISkin robotSkin;
	
	// is The first level of the shop menu active
	bool startLevel;
	
	// is The weapons selection level of the shop menu active
	bool weaponsBaseLevel;
	
	// is The power selection menu of the shop active
	bool powersBaseLevel;
	
	//is the menu for the first weapon active
	bool weapon1Level;
	
	//is the menu for the first power active
	bool power1Level;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnGUI ()
	{
		GUI.Box (new Rect(100, 60, 1720, 700), "dfsafdsafs");
		GUI.skin = robotSkin;
		if (shopBlock (new Rect(200,300,1000,120),generalWeaponPicture, weaponsCategory, weaponsCatergoryDescription,
			categoryPrice, categoryButtonText))
			Debug.Log("clicked");
	}
	
	/// <summary>
	/// The basic design used in creating the tiles in the shop
	/// </summary>
	/// <returns>
	/// If the button has been clicked
	/// </returns>
	/// <param name='boxPosition'>
	/// The position of the box on the screen
	/// </param>
	/// <param name='itemPicture'>
	/// The picture of the item
	/// </param>
	/// <param name='name'>
	/// The name of the item
	/// </param>
	/// <param name='itemDescription'>
	/// The description of the item
	/// </param>
	/// <param name='price'>
	/// The price of the item
	/// </param>
	/// <param name='buttonText'>
	/// The text on the button
	/// </param>
	bool shopBlock (Rect boxPosition, Texture2D itemPicture, string name, string itemDescription, 
		int price, string buttonText)
	{
		GUI.Box (boxPosition,"");
		float itemStartPosition = boxPosition.x + 10f;
		GUI.Box (new Rect(itemStartPosition, boxPosition.y + 10f, 200, 100), itemPicture);
		itemStartPosition += 220f;
		GUI.Label(new Rect(itemStartPosition, boxPosition.y + 10f , 300, 25), name);
		GUI.Label(new Rect(itemStartPosition, boxPosition.y + 50f, 600, 25), itemDescription);
		itemStartPosition = boxPosition.xMax - 450f;
		GUI.Label (new Rect(itemStartPosition,boxPosition.y + 10f, 100, 25), price.ToString());
		return GUI.Button (new Rect(boxPosition.xMax - 210f, boxPosition.y + 10f, 200, 100), "Buy");
	}
}
