using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleButton2 : MonoBehaviour {

	public Button Bkey1;
	public Button Bkey2;
	public Button Bkey3;
	public Button Bkey4;
	public Button Bkey5;
	public Button Bkey6;
	public Button Bkey7;

	public Button Ckey1;
	public Button Ckey2;
	public Button Ckey3;
	public Button Ckey4;
	public Button Ckey5;

	// Use this for initialization
	void Start () {

		//Bkey1 = Button.FindObjectOfType<Button>;

		//Bkey2 = GameObject.Find ("BKey2");
		//Bkey3 = GameObject.Find ("BKey3");
		//Bkey4 = GameObject.Find ("BKey4");
		//Bkey5 = GameObject.Find ("BKey5");
		//Bkey6 = GameObject.Find ("BKey6");
		//Bkey7 = GameObject.Find ("BKey7");

		//Ckey1 = GameObject.Find ("CKey1");
		//Ckey2 = GameObject.Find ("CKey2");
		//Ckey3 = GameObject.Find ("CKey3");
		//Ckey4 = GameObject.Find ("CKey4");
		//Ckey5 = GameObject.Find ("CKey5");

		GameObject.Find("BKey1").GetComponent<Button>().enabled = false;
		GameObject.Find("BKey2").GetComponent<Button>().enabled = false;
		GameObject.Find("BKey3").GetComponent<Button>().enabled = false;
		GameObject.Find("BKey4").GetComponent<Button>().enabled = false;
		GameObject.Find("BKey5").GetComponent<Button>().enabled = false;
		GameObject.Find("BKey6").GetComponent<Button>().enabled = false;
		GameObject.Find("BKey7").GetComponent<Button>().enabled = false;

		GameObject.Find("CKey1").GetComponent<Button>().enabled = false;
		GameObject.Find("CKey2").GetComponent<Button>().enabled = false;
		GameObject.Find("CKey3").GetComponent<Button>().enabled = false;
		GameObject.Find("CKey4").GetComponent<Button>().enabled = false;
		GameObject.Find("CKey5").GetComponent<Button>().enabled = false;

		Bkey1.image.color = Color.white;
		Bkey2.image.color = Color.white;
		Bkey3.image.color = Color.white;
		Bkey4.image.color = Color.white;
		Bkey5.image.color = Color.white;
		Bkey6.image.color = Color.white;
		Bkey7.image.color = Color.white;

		Ckey1.image.color = Color.grey;
		Ckey2.image.color = Color.grey;
		Ckey3.image.color = Color.grey;
		Ckey4.image.color = Color.grey;
		Ckey5.image.color = Color.grey;

	}
	
	// Update is called once per frame
	public void KeyPressed (int value) {

		if (value==1) {

//			Bkey1.IsActive = true;
//			Bkey1.IsActive = false;
//			Bkey1.IsActive = false;
//			Bkey1.IsActive = false;
//			Bkey1.IsActive = false;
//			Bkey1.IsActive = false;
//			Bkey1.IsActive = false;
//
//			Ckey1.IsActive = false;
//			Ckey2.IsActive = false;
//			Ckey3.IsActive = false;
//			Ckey4.IsActive = false;
//			Ckey5.IsActive = false;


//			GameObject.Find("BKey1").GetComponent<Button>().enabled = true;
//			GameObject.Find("BKey2").GetComponent<Button>().enabled = false;
//			GameObject.Find("BKey3").GetComponent<Button>().enabled = false;
//			GameObject.Find("BKey4").GetComponent<Button>().enabled = false;
//			GameObject.Find("BKey5").GetComponent<Button>().enabled = false;
//			GameObject.Find("BKey6").GetComponent<Button>().enabled = false;
//			GameObject.Find("BKey7").GetComponent<Button>().enabled = false;
//
//			GameObject.Find("CKey1").GetComponent<Button>().enabled = false;
//			GameObject.Find("CKey2").GetComponent<Button>().enabled = false;
//			GameObject.Find("CKey3").GetComponent<Button>().enabled = false;
//			GameObject.Find("CKey4").GetComponent<Button>().enabled = false;
//			GameObject.Find("CKey5").GetComponent<Button>().enabled = false;

			Bkey1.image.color = Color.grey;
			Bkey2.image.color = Color.white;
			Bkey3.image.color = Color.white;
			Bkey4.image.color = Color.white;
			Bkey5.image.color = Color.white;
			Bkey6.image.color = Color.white;
			Bkey7.image.color = Color.white;

			Ckey1.image.color = Color.grey;
			Ckey2.image.color = Color.grey;
			Ckey3.image.color = Color.grey;
			Ckey4.image.color = Color.grey;
			Ckey5.image.color = Color.grey;

		}

		else if (value==3) {

			GameObject.Find("BKey1").GetComponent<Button>().enabled = false;
			GameObject.Find("BKey2").GetComponent<Button>().enabled = true;
			GameObject.Find("BKey3").GetComponent<Button>().enabled = false;
			GameObject.Find("BKey4").GetComponent<Button>().enabled = false;
			GameObject.Find("BKey5").GetComponent<Button>().enabled = false;
			GameObject.Find("BKey6").GetComponent<Button>().enabled = false;
			GameObject.Find("BKey7").GetComponent<Button>().enabled = false;

			GameObject.Find("CKey1").GetComponent<Button>().enabled = false;
			GameObject.Find("CKey2").GetComponent<Button>().enabled = false;
			GameObject.Find("CKey3").GetComponent<Button>().enabled = false;
			GameObject.Find("CKey4").GetComponent<Button>().enabled = false;
			GameObject.Find("CKey5").GetComponent<Button>().enabled = false;

			Bkey1.image.color = Color.white;
			Bkey2.image.color = Color.grey;
			Bkey3.image.color = Color.white;
			Bkey4.image.color = Color.white;
			Bkey5.image.color = Color.white;
			Bkey6.image.color = Color.white;
			Bkey7.image.color = Color.white;

			Ckey1.image.color = Color.grey;
			Ckey2.image.color = Color.grey;
			Ckey3.image.color = Color.grey;
			Ckey4.image.color = Color.grey;
			Ckey5.image.color = Color.grey;

		}

		else if (value==5) {

			GameObject.Find("BKey1").GetComponent<Button>().enabled = false;
			GameObject.Find("BKey2").GetComponent<Button>().enabled = false;
			GameObject.Find("BKey3").GetComponent<Button>().enabled = true;
			GameObject.Find("BKey4").GetComponent<Button>().enabled = false;
			GameObject.Find("BKey5").GetComponent<Button>().enabled = false;
			GameObject.Find("BKey6").GetComponent<Button>().enabled = false;
			GameObject.Find("BKey7").GetComponent<Button>().enabled = false;

			GameObject.Find("CKey1").GetComponent<Button>().enabled = false;
			GameObject.Find("CKey2").GetComponent<Button>().enabled = false;
			GameObject.Find("CKey3").GetComponent<Button>().enabled = false;
			GameObject.Find("CKey4").GetComponent<Button>().enabled = false;
			GameObject.Find("CKey5").GetComponent<Button>().enabled = false;

			Bkey1.image.color = Color.white;
			Bkey2.image.color = Color.white;
			Bkey3.image.color = Color.grey;
			Bkey4.image.color = Color.white;
			Bkey5.image.color = Color.white;
			Bkey6.image.color = Color.white;
			Bkey7.image.color = Color.white;

			Ckey1.image.color = Color.grey;
			Ckey2.image.color = Color.grey;
			Ckey3.image.color = Color.grey;
			Ckey4.image.color = Color.grey;
			Ckey5.image.color = Color.grey;

		}

		else if (value==6) {

			GameObject.Find("BKey1").GetComponent<Button>().enabled = false;
			GameObject.Find("BKey2").GetComponent<Button>().enabled = false;
			GameObject.Find("BKey3").GetComponent<Button>().enabled = false;
			GameObject.Find("BKey4").GetComponent<Button>().enabled = true;
			GameObject.Find("BKey5").GetComponent<Button>().enabled = false;
			GameObject.Find("BKey6").GetComponent<Button>().enabled = false;
			GameObject.Find("BKey7").GetComponent<Button>().enabled = false;

			GameObject.Find("CKey1").GetComponent<Button>().enabled = false;
			GameObject.Find("CKey2").GetComponent<Button>().enabled = false;
			GameObject.Find("CKey3").GetComponent<Button>().enabled = false;
			GameObject.Find("CKey4").GetComponent<Button>().enabled = false;
			GameObject.Find("CKey5").GetComponent<Button>().enabled = false;

			Bkey1.image.color = Color.white;
			Bkey2.image.color = Color.white;
			Bkey3.image.color = Color.white;
			Bkey4.image.color = Color.grey;
			Bkey5.image.color = Color.white;
			Bkey6.image.color = Color.white;
			Bkey7.image.color = Color.white;

			Ckey1.image.color = Color.grey;
			Ckey2.image.color = Color.grey;
			Ckey3.image.color = Color.grey;
			Ckey4.image.color = Color.grey;
			Ckey5.image.color = Color.grey;

		}

		else if (value==8) {

			GameObject.Find("BKey1").GetComponent<Button>().enabled = false;
			GameObject.Find("BKey2").GetComponent<Button>().enabled = false;
			GameObject.Find("BKey3").GetComponent<Button>().enabled = false;
			GameObject.Find("BKey4").GetComponent<Button>().enabled = false;
			GameObject.Find("BKey5").GetComponent<Button>().enabled = true;
			GameObject.Find("BKey6").GetComponent<Button>().enabled = false;
			GameObject.Find("BKey7").GetComponent<Button>().enabled = false;

			GameObject.Find("CKey1").GetComponent<Button>().enabled = false;
			GameObject.Find("CKey2").GetComponent<Button>().enabled = false;
			GameObject.Find("CKey3").GetComponent<Button>().enabled = false;
			GameObject.Find("CKey4").GetComponent<Button>().enabled = false;
			GameObject.Find("CKey5").GetComponent<Button>().enabled = false;

			Bkey1.image.color = Color.white;
			Bkey2.image.color = Color.white;
			Bkey3.image.color = Color.white;
			Bkey4.image.color = Color.white;
			Bkey5.image.color = Color.grey;
			Bkey6.image.color = Color.white;
			Bkey7.image.color = Color.white;

			Ckey1.image.color = Color.grey;
			Ckey2.image.color = Color.grey;
			Ckey3.image.color = Color.grey;
			Ckey4.image.color = Color.grey;
			Ckey5.image.color = Color.grey;

		}

		else if (value==10) {

			GameObject.Find("BKey1").GetComponent<Button>().enabled = false;
			GameObject.Find("BKey2").GetComponent<Button>().enabled = false;
			GameObject.Find("BKey3").GetComponent<Button>().enabled = false;
			GameObject.Find("BKey4").GetComponent<Button>().enabled = false;
			GameObject.Find("BKey5").GetComponent<Button>().enabled = false;
			GameObject.Find("BKey6").GetComponent<Button>().enabled = true;
			GameObject.Find("BKey7").GetComponent<Button>().enabled = false;

			GameObject.Find("CKey1").GetComponent<Button>().enabled = false;
			GameObject.Find("CKey2").GetComponent<Button>().enabled = false;
			GameObject.Find("CKey3").GetComponent<Button>().enabled = false;
			GameObject.Find("CKey4").GetComponent<Button>().enabled = false;
			GameObject.Find("CKey5").GetComponent<Button>().enabled = false;

			Bkey1.image.color = Color.white;
			Bkey2.image.color = Color.white;
			Bkey3.image.color = Color.white;
			Bkey4.image.color = Color.white;
			Bkey5.image.color = Color.white;
			Bkey6.image.color = Color.grey;
			Bkey7.image.color = Color.white;

			Ckey1.image.color = Color.grey;
			Ckey2.image.color = Color.grey;
			Ckey3.image.color = Color.grey;
			Ckey4.image.color = Color.grey;
			Ckey5.image.color = Color.grey;

		}

		else if (value==12) {

			GameObject.Find("BKey1").GetComponent<Button>().enabled = false;
			GameObject.Find("BKey2").GetComponent<Button>().enabled = false;
			GameObject.Find("BKey3").GetComponent<Button>().enabled = false;
			GameObject.Find("BKey4").GetComponent<Button>().enabled = false;
			GameObject.Find("BKey5").GetComponent<Button>().enabled = false;
			GameObject.Find("BKey6").GetComponent<Button>().enabled = false;
			GameObject.Find("BKey7").GetComponent<Button>().enabled = true;

			GameObject.Find("CKey1").GetComponent<Button>().enabled = false;
			GameObject.Find("CKey2").GetComponent<Button>().enabled = false;
			GameObject.Find("CKey3").GetComponent<Button>().enabled = false;
			GameObject.Find("CKey4").GetComponent<Button>().enabled = false;
			GameObject.Find("CKey5").GetComponent<Button>().enabled = false;

			Bkey1.image.color = Color.white;
			Bkey2.image.color = Color.white;
			Bkey3.image.color = Color.white;
			Bkey4.image.color = Color.white;
			Bkey5.image.color = Color.white;
			Bkey6.image.color = Color.white;
			Bkey7.image.color = Color.grey;

			Ckey1.image.color = Color.grey;
			Ckey2.image.color = Color.grey;
			Ckey3.image.color = Color.grey;
			Ckey4.image.color = Color.grey;
			Ckey5.image.color = Color.grey;

		}

		else if (value==2) {

			GameObject.Find("BKey1").GetComponent<Button>().enabled = false;
			GameObject.Find("BKey2").GetComponent<Button>().enabled = false;
			GameObject.Find("BKey3").GetComponent<Button>().enabled = false;
			GameObject.Find("BKey4").GetComponent<Button>().enabled = false;
			GameObject.Find("BKey5").GetComponent<Button>().enabled = false;
			GameObject.Find("BKey6").GetComponent<Button>().enabled = false;
			GameObject.Find("BKey7").GetComponent<Button>().enabled = false;

			GameObject.Find("CKey1").GetComponent<Button>().enabled = true;
			GameObject.Find("CKey2").GetComponent<Button>().enabled = false;
			GameObject.Find("CKey3").GetComponent<Button>().enabled = false;
			GameObject.Find("CKey4").GetComponent<Button>().enabled = false;
			GameObject.Find("CKey5").GetComponent<Button>().enabled = false;

			Bkey1.image.color = Color.white;
			Bkey2.image.color = Color.white;
			Bkey3.image.color = Color.white;
			Bkey4.image.color = Color.white;
			Bkey5.image.color = Color.white;
			Bkey6.image.color = Color.white;
			Bkey7.image.color = Color.white;

			Ckey1.image.color = Color.black;
			Ckey2.image.color = Color.grey;
			Ckey3.image.color = Color.grey;
			Ckey4.image.color = Color.grey;
			Ckey5.image.color = Color.grey;

		}

		else if (value==4) {

			GameObject.Find("BKey1").GetComponent<Button>().enabled = false;
			GameObject.Find("BKey2").GetComponent<Button>().enabled = false;
			GameObject.Find("BKey3").GetComponent<Button>().enabled = false;
			GameObject.Find("BKey4").GetComponent<Button>().enabled = false;
			GameObject.Find("BKey5").GetComponent<Button>().enabled = false;
			GameObject.Find("BKey6").GetComponent<Button>().enabled = false;
			GameObject.Find("BKey7").GetComponent<Button>().enabled = false;

			GameObject.Find("CKey1").GetComponent<Button>().enabled = false;
			GameObject.Find("CKey2").GetComponent<Button>().enabled = true;
			GameObject.Find("CKey3").GetComponent<Button>().enabled = false;
			GameObject.Find("CKey4").GetComponent<Button>().enabled = false;
			GameObject.Find("CKey5").GetComponent<Button>().enabled = false;

			Bkey1.image.color = Color.white;
			Bkey2.image.color = Color.white;
			Bkey3.image.color = Color.white;
			Bkey4.image.color = Color.white;
			Bkey5.image.color = Color.white;
			Bkey6.image.color = Color.white;
			Bkey7.image.color = Color.white;

			Ckey1.image.color = Color.grey;
			Ckey2.image.color = Color.black;
			Ckey3.image.color = Color.grey;
			Ckey4.image.color = Color.grey;
			Ckey5.image.color = Color.grey;

		}

		else if (value==7) {

			GameObject.Find("BKey1").GetComponent<Button>().enabled = false;
			GameObject.Find("BKey2").GetComponent<Button>().enabled = false;
			GameObject.Find("BKey3").GetComponent<Button>().enabled = false;
			GameObject.Find("BKey4").GetComponent<Button>().enabled = false;
			GameObject.Find("BKey5").GetComponent<Button>().enabled = false;
			GameObject.Find("BKey6").GetComponent<Button>().enabled = false;
			GameObject.Find("BKey7").GetComponent<Button>().enabled = false;

			GameObject.Find("CKey1").GetComponent<Button>().enabled = false;
			GameObject.Find("CKey2").GetComponent<Button>().enabled = false;
			GameObject.Find("CKey3").GetComponent<Button>().enabled = true;
			GameObject.Find("CKey4").GetComponent<Button>().enabled = false;
			GameObject.Find("CKey5").GetComponent<Button>().enabled = false;

			Bkey1.image.color = Color.white;
			Bkey2.image.color = Color.white;
			Bkey3.image.color = Color.white;
			Bkey4.image.color = Color.white;
			Bkey5.image.color = Color.white;
			Bkey6.image.color = Color.white;
			Bkey7.image.color = Color.white;

			Ckey1.image.color = Color.grey;
			Ckey2.image.color = Color.grey;
			Ckey3.image.color = Color.black;
			Ckey4.image.color = Color.grey;
			Ckey5.image.color = Color.grey;

		}

		else if (value==9) {

			GameObject.Find("BKey1").GetComponent<Button>().enabled = false;
			GameObject.Find("BKey2").GetComponent<Button>().enabled = false;
			GameObject.Find("BKey3").GetComponent<Button>().enabled = false;
			GameObject.Find("BKey4").GetComponent<Button>().enabled = false;
			GameObject.Find("BKey5").GetComponent<Button>().enabled = false;
			GameObject.Find("BKey6").GetComponent<Button>().enabled = false;
			GameObject.Find("BKey7").GetComponent<Button>().enabled = false;

			GameObject.Find("CKey1").GetComponent<Button>().enabled = false;
			GameObject.Find("CKey2").GetComponent<Button>().enabled = false;
			GameObject.Find("CKey3").GetComponent<Button>().enabled = false;
			GameObject.Find("CKey4").GetComponent<Button>().enabled = true;
			GameObject.Find("CKey5").GetComponent<Button>().enabled = false;

			Bkey1.image.color = Color.white;
			Bkey2.image.color = Color.white;
			Bkey3.image.color = Color.white;
			Bkey4.image.color = Color.white;
			Bkey5.image.color = Color.white;
			Bkey6.image.color = Color.white;
			Bkey7.image.color = Color.white;

			Ckey1.image.color = Color.grey;
			Ckey2.image.color = Color.grey;
			Ckey3.image.color = Color.grey;
			Ckey4.image.color = Color.black;
			Ckey5.image.color = Color.grey;

		}

		else if (value==11) {

			GameObject.Find("BKey1").GetComponent<Button>().enabled = false;
			GameObject.Find("BKey2").GetComponent<Button>().enabled = false;
			GameObject.Find("BKey3").GetComponent<Button>().enabled = false;
			GameObject.Find("BKey4").GetComponent<Button>().enabled = false;
			GameObject.Find("BKey5").GetComponent<Button>().enabled = false;
			GameObject.Find("BKey6").GetComponent<Button>().enabled = false;
			GameObject.Find("BKey7").GetComponent<Button>().enabled = false;

			GameObject.Find("CKey1").GetComponent<Button>().enabled = false;
			GameObject.Find("CKey2").GetComponent<Button>().enabled = false;
			GameObject.Find("CKey3").GetComponent<Button>().enabled = false;
			GameObject.Find("CKey4").GetComponent<Button>().enabled = false;
			GameObject.Find("CKey5").GetComponent<Button>().enabled = true;

			Bkey1.image.color = Color.white;
			Bkey2.image.color = Color.white;
			Bkey3.image.color = Color.white;
			Bkey4.image.color = Color.white;
			Bkey5.image.color = Color.white;
			Bkey6.image.color = Color.white;
			Bkey7.image.color = Color.white;

			Ckey1.image.color = Color.grey;
			Ckey2.image.color = Color.grey;
			Ckey3.image.color = Color.grey;
			Ckey4.image.color = Color.grey;
			Ckey5.image.color = Color.black;

		}

	}
}
