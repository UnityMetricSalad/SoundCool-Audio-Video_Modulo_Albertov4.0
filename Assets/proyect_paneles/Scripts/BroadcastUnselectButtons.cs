using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BroadcastUnselectButtons : MonoBehaviour {

    private void OnEnable()
    {
        transform.BroadcastMessage("SpreadSendOSCMessageUp_OP");
        //transform.BroadcastMessage("SpreadSendOSCMessageUp_OP", SendMessageOptions.DontRequireReceiver);

        //Debug.Log("Funcion Broadcast");
    }
}
