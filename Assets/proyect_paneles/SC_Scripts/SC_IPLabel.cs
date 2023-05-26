using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace UniOSC
{
    public class SC_IPLabel : MonoBehaviour {

        // SoundCool_UniOSCConnection miConnection;
        public GameObject PlaceHoldertextIP, textIP;
        public GameObject GOconnection;
        public GameObject PlaceHoldertextPort, textPort;
        public InputField IF_IP0;
        public InputField IF_Port;

        // Use this for initialization

		// Inicializamos los valores de IP y PORT con datos guardados del usuario anterior
		// Si no existen valores guardados carga unos predeterminados.
        void Start() {
				if(PlayerPrefs.HasKey("IP")){
					statics.IP=PlayerPrefs.GetString("IP");
				}else{
				statics.IP="255.255.0.0";
				}

				if(PlayerPrefs.HasKey("PORT")){
				statics.PORT=PlayerPrefs.GetInt("PORT");
				}else{
				statics.PORT=9000;
				}
				


            GOconnection.GetComponent<UniOSCConnection>().sc_changeoscOutIPAddress(statics.IP);
            GOconnection.GetComponent<UniOSCConnection>().sc_changePort(statics.PORT.ToString());

            PlaceHoldertextIP.GetComponent<Text>().text= GOconnection.GetComponent<UniOSCConnection>().oscOutIPAddress;
            PlaceHoldertextPort.GetComponent<Text>().text = GOconnection.GetComponent<UniOSCConnection>().oscOutPort.ToString();
         

        }

        public void ShowValuesInIPTextBox()
        {
            // textIP.GetComponent<Text>().text = GOconnection.GetComponent<UniOSCConnection>().oscOutIPAddress;
            IF_IP0.text= GOconnection.GetComponent<UniOSCConnection>().oscOutIPAddress;
			PlaceHoldertextIP.GetComponent<Text>().text= GOconnection.GetComponent<UniOSCConnection>().oscOutIPAddress;
			PlaceHoldertextPort.GetComponent<Text>().text = GOconnection.GetComponent<UniOSCConnection>().oscOutPort.ToString();
        }
        public void ShowValuesInPORTTextBox()
        {
            IF_Port.text =  GOconnection.GetComponent<UniOSCConnection>().oscOutPort.ToString();
			PlaceHoldertextIP.GetComponent<Text>().text= GOconnection.GetComponent<UniOSCConnection>().oscOutIPAddress;
			PlaceHoldertextPort.GetComponent<Text>().text = GOconnection.GetComponent<UniOSCConnection>().oscOutPort.ToString();
        }
        // Update is called once per frame
		// La siguiente función muestra la publicidad de Unity en nuestra app
        void Update() {

			if (Input.GetKeyUp(KeyCode.Escape))
			{
				if (Application.platform == RuntimePlatform.Android)
				{
					AndroidJavaObject activity = new AndroidJavaClass("com.unity3d.player.UnityPlayer").GetStatic<AndroidJavaObject>("currentActivity");
					activity.Call<bool>("moveTaskToBack", true);
				}
				else
				{
					Application.Quit();
				}
			}

    }
        
}
}
