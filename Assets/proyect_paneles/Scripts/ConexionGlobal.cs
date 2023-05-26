using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConexionGlobal : MonoBehaviour {

    public static ConexionGlobal EstadoConexion;
    void Awake()
    {
        if(EstadoConexion == null)
        {
            EstadoConexion = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (EstadoConexion != this)
        {
            Destroy(gameObject);
        }
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
