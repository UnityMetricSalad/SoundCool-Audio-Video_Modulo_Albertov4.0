/*
* UniOSC
* Copyright © 2014-2015 Stefan Schlupek
* All rights reserved
* info@monoflow.org
*/
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System;
using OSCsharp.Data;
using UnityEngine.UI;


namespace UniOSC{

	/// <summary>
	/// Dispatcher button that forces a OSCConnection to send a OSC Message.
	/// Two separate states: Down and Up 
	/// </summary>
	[AddComponentMenu("UniOSC/EventDispatcherButton")]
	[ExecuteInEditMode]
	public class UniOSCEventDispatcherButton: UniOSCEventDispatcher {
       
        #region public
        [HideInInspector]
		public float downOSCDataValue=1;
		[HideInInspector]
		public float upOSCDataValue=0;
		[HideInInspector]
		public bool showGUI;
		[HideInInspector]
		public float xPos;
		[HideInInspector]
		public float yPos;
       
     
        #endregion

        #region private
        private bool _btnDown;
		private GUIStyle _gs;
        #endregion
        bool nuevovalor = false;
        
      
        //============ soundcool

        float nuevovalorF = 0f;

        public void SC_SendValue(bool value)
        {
            //  _sliderValue = value;
            nuevovalor = value;
            if (nuevovalor) { SendOSCMessageDown(); } else { SendOSCMessageUp(); };
        }

		public override void SendOSCMessage(){
			if(_OSCeArg.Packet is OscMessage)
			{
				((OscMessage)_OSCeArg.Packet).UpdateDataAt(0, nuevovalorF);
			}
			else if(_OSCeArg.Packet is OscBundle)
			{
				foreach (OscMessage m in ((OscBundle)_OSCeArg.Packet).Messages)
				{
					m.UpdateDataAt(0, nuevovalorF);
				}				
			}
			_SendOSCMessage(_OSCeArg);
			//================================= amg soundcool
			if (statics.DEBUGGING) statics.DEBUGGINGTEXT=(_OSCeArg.Address + " " + nuevovalorF.ToString() );/// activa debuging en pantalla 
			if (statics.VIBRATE) Handheld.Vibrate();

		}
		public void SC_SendMuteKeyboard()//funcion de reseteo de todo el keyboard
		{
			int octava= statics.OCTAVA;
			string log="";
			for(int x=0;x<=10;x++){
				oscOutAddress= "/3/fader3";
				nuevovalorF = x;
				//log=log+_OSCeArg.Address + " "+x +" ";
				SendOSCMessage();
				for (int p=1;p<=13;p++){
					oscOutAddress= "/3/push"+p;
				//	log=log+_OSCeArg.Address + " 0 --";
					SendOSCMessageUp();
				}
				//Debug.Log(log);

			}
			oscOutAddress="/3/fader3"; 
			nuevovalorF=octava;
			SendOSCMessage();//vuelve a la octava previa al reset
		}


        //===================

        public override void Awake()
		{
			base.Awake ();
			
		}

		public override void OnEnable ()
		{
			base.OnEnable ();
            ClearData();
            AppendData(0f);
		}
		public override void OnDisable ()
		{
			base.OnDisable ();
		}
        
		public void SendOSCMessageDown(){
          //  if (OnlyOneKey) this.transform.parent.BroadcastMessage("SendOSCMessageUp");


            if (_OSCeArg.Packet is OscMessage)
			{
				((OscMessage)_OSCeArg.Packet).UpdateDataAt(0, downOSCDataValue);
			}
			else if(_OSCeArg.Packet is OscBundle)
			{
                foreach (OscMessage m in ((OscBundle)_OSCeArg.Packet).Messages)
                {
                    m.UpdateDataAt(0, downOSCDataValue);
                }				
			}


			_SendOSCMessage(_OSCeArg);
            //================================= amg soundcool
			if (statics.DEBUGGING) statics.DEBUGGINGTEXT = (_OSCeArg.Address + " " + downOSCDataValue.ToString());/// activa debuging en pantalla 
            if (statics.VIBRATE) Handheld.Vibrate();
        }

        /// <summary>
        /// Sends the OSC message with the upOSCDataValue.
        /// </summary>
        public void SendOSCMessageUp(){
			if(_OSCeArg.Packet is OscMessage)
			{
                ((OscMessage)_OSCeArg.Packet).UpdateDataAt(0, upOSCDataValue);
			}
			else if(_OSCeArg.Packet is OscBundle)
			{
                foreach (OscMessage m in ((OscBundle)_OSCeArg.Packet).Messages)
                {
                    m.UpdateDataAt(0, upOSCDataValue);
                }              
			}

			_SendOSCMessage(_OSCeArg);
            //================================= amg soundcool
			if (statics.DEBUGGING) statics.DEBUGGINGTEXT = (_OSCeArg.Address + " " + upOSCDataValue.ToString());/// activa debuging en pantalla 
		}


    }
}