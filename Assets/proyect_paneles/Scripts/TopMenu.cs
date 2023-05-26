using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class TopMenu : MonoBehaviour {

	// Use this for initialization
	public void AnimarBotones() {

        this.transform.parent.parent.BroadcastMessage("NormalTrigger", SendMessageOptions.DontRequireReceiver);

    }
    public void NormalTrigger()
    {

        GetComponent<Animator>().SetTrigger("Normal");

    }
}
