using UnityEngine;
using System.Collections;

public class openURL : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// con esta función se abrira la URL escrita en string
    public void OpenURL(string url)
    {
        Application.OpenURL(url);
    }
}
