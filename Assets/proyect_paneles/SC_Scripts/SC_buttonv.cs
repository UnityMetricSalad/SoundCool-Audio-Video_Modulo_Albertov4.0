using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UniOSC;

public class SC_buttonv : Button {

	// Use this for initialization
	// UniOSCEventDispatcherButton oscB;

	// public bool mouseDown= false;

	//Con esta funcion se envia el estado del boton a traves del OSCConnection

	void PointerPress()
	{
		this.GetComponent<UniOSCEventDispatcherButton>().SC_SendValue( true);
	}
	void PointerUp()
	{
		this.GetComponent<UniOSCEventDispatcherButton>().SC_SendValue(false);
	}
}
