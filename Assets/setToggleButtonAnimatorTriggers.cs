using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UniOSC;
using System;

public enum ToggleTipo
{
	PlayPause,
	ForwardReverse,
	Otro,
}

public class setToggleButtonAnimatorTriggers : MonoBehaviour {
	//public GameObject thisObj;


	public ToggleTipo toggleTipo;

	private Animator anim;
	// Use this for initialization
	void Start () {
		anim=GetComponent<Animator>();
		setAnimatorTrigger(false);

	}
	void OnEnable(){
		anim=GetComponent<Animator>();
		setAnimatorTrigger(false);
	}
	// Update is called once per frame
	void Update () {
	
	}


	public void setAnimatorTrigger(bool i){

		switch(toggleTipo){
		case ToggleTipo.PlayPause:
			if (i){anim.SetTrigger("Pause");}else{anim.SetTrigger("Play");}
				break;
		case ToggleTipo.ForwardReverse:
			if (i){anim.SetTrigger("Forward");}else{anim.SetTrigger("Reverse");}
			 break;	
		}

		}
		
	}

