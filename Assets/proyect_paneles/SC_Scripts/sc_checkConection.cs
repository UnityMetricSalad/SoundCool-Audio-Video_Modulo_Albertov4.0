using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UniOSC;
using System;

public class sc_checkConection : MonoBehaviour {


    public GameObject statusImage;//, statusImage1, statusImage2;

	Animator animbutton1;
    Animator animImage1;//, animImage2, animImage3;

	void Start(){
		animbutton1= GetComponent<Animator>();
		animImage1=statusImage.GetComponent<Animator>();
       // animImage2 = statusImage1.GetComponent<Animator>();
       // animImage3 = statusImage2.GetComponent<Animator>();
        theOSCConnection =theOSCgameobject.GetComponent<UniOSCConnection>();
	}
	public GameObject theOSCgameobject;
	private UniOSCConnection theOSCConnection;
    public void checkConnectionColorButton() {

		bool connectionSuccessful =theOSCConnection.dispatchOSCOut;// transform.parent.GetComponentInChildren<UniOSCConnection>().dispatchOSCOut;

       // GetComponent<Image>().color = connectionSuccessful ? UniOSCUtils.CONNECTION_ON_COLOR : UniOSCUtils.CONNECTION_PAUSE_COLOR;
        
        Debug.Log(connectionSuccessful + " connected");
        if (connectionSuccessful)
        {
			animbutton1.SetTrigger("Connecting");
			animImage1.SetTrigger("Connecting");
           // animImage2.SetTrigger("Connecting");
           // animImage3.SetTrigger("Connecting");
            //statusImage.color= Color.yellow;
            StartCoroutine(pingConnection(theOSCConnection.oscOutIPAddress));//transform.parent.GetComponentInChildren<UniOSCConnection>().oscOutIPAddress));
        }
        else {
			animbutton1.SetTrigger("Failed");
			animImage1.SetTrigger("Failed");
           // animImage2.SetTrigger("Failed");
           // animImage3.SetTrigger("Failed");


            //statusImage.color= Color.red;

        }


    }


    public float waitSecondsForPING = 4f;

    IEnumerator pingConnection(string ip)
    {
       // Debug.Log("ping..."+ ip);
        Ping pingMasterServer = null;

        try
        {
             pingMasterServer = new Ping(ip);
        }
        catch (Exception e)
        {
            Debug.LogWarning("Couldn't ping: " + e.Message);
			animbutton1.SetTrigger("FailedPing");
			animImage1.SetTrigger("FailedPing");
            yield break; //can't continue
      
        }

        //got here, can continue with logic
        float startTime = Time.time;
        while (!pingMasterServer.isDone && Time.time < startTime + waitSecondsForPING)
        {
          
            yield return new WaitForSeconds(waitSecondsForPING);
        }
        if (pingMasterServer.isDone && pingMasterServer.time > 2)
        {
           // Debug.Log("IntenetON" + " time:" + pingMasterServer.time);
			animbutton1.SetTrigger("Connected");
			animImage1.SetTrigger("Connected");
			//statusImage.color= Color.green;
        }else if (pingMasterServer.isDone && pingMasterServer.time <= 1)
        {
           // Debug.Log("IntenetOFF" + " time:" + pingMasterServer.time);
			animbutton1.SetTrigger("FailedPing");
			animImage1.SetTrigger("FailedPing");
			//statusImage.color= Color.yellow;
        }else
        {
			animbutton1.SetTrigger("FailedPing");
			animImage1.SetTrigger("FailedPing");
			//statusImage.color= Color.yellow;
        }
    }


}




