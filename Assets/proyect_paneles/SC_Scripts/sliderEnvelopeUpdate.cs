using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class sliderEnvelopeUpdate : MonoBehaviour {

	public Text sliderlabel;
	// Use this for initialization
	public void sliderENVELOPEupdate(float value) {
		//  _sliderValue = value;
		sliderlabel.text= (value/10f)+ " sec.";
		 
	}
}
