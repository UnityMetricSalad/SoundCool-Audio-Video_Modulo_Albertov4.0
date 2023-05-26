using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyTriggersControl : MonoBehaviour {

	Animator thisAnimator ;

	// Use this for initialization
	void Start () {
		thisAnimator = this.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public void setAnimatorBoolTrue(){
		thisAnimator.SetBool ("pushed",true);
	}
	public void setAnimatorBoolFalse(){
		thisAnimator.SetBool ("pushed",false);
	}
}
