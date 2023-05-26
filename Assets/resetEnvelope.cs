using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class resetEnvelope : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//====== funcione de reseteo de sliders de Envelope
	public Slider[] envelopes;
	public void SC_SendResetEnvelope()//funcion de reseteo de todo el keyboard
	{
		if (envelopes.Length==20){
			for(int x=0;x<20;x++){

				envelopes[x].value=0f;

			}
		}

	}
}
