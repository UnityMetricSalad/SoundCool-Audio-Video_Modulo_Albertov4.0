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


namespace UniOSC{

	/// <summary>
	/// Dispatcher toggle that forces a OSCConnection to send a OSC Message.
	/// Two separate states: On and Off 
	/// </summary>
	[AddComponentMenu("UniOSC/SoundCool_UniOSCEventDispatcherSlider")]
	[ExecuteInEditMode]
	public class SoundCool_UniOSCEventDispatcherSlider: UniOSCEventDispatcher {

		#region public

        public enum SliderMode { Horizontal,Vertical}
        public SliderMode sliderMode;
		//[HideInInspector]

        public float minOSCDataValue = 0;
        public float maxOSCDataValue = 1;
		
		//[HideInInspector]
		public bool showGUI;
		[Range(0f,1f)]
		public float xPos;
        [Range(0f, 1f)]
		public float yPos;
        public float sliderSize= 100f;
		#endregion

		#region private
		
		private GUIStyle _gs;
        private float _sliderValue;
        private float _prev_sliderValue; 
		#endregion

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


        float nuevovalor = 0f;

        public void SC_SendValue(float value) {
          //  _sliderValue = value;
            nuevovalor = value;
            SendOSCMessage();
        }


		public void SC_SendValueMIDIINSTRUMENT(float value) {
			//int indice = (int)Mathf.Floor(value*127f);
			nuevovalor = value;
			//indice/127f;

			SendOSCMessage();
		}

		public void SC_SendValueENVELOPE(float value) {
			//  _sliderValue = value;
			nuevovalor = value/100f;
			SendOSCMessage();
		}

		/// <summary>
		/// Sends the OSC message with the sliderValue.
		/// </summary>
        /// 

		public override void SendOSCMessage(){
			if(_OSCeArg.Packet is OscMessage)
			{
                ((OscMessage)_OSCeArg.Packet).UpdateDataAt(0, nuevovalor);
			}
			else if(_OSCeArg.Packet is OscBundle)
			{
                foreach (OscMessage m in ((OscBundle)_OSCeArg.Packet).Messages)
                {
                    m.UpdateDataAt(0, nuevovalor);
                }				
			}


			_SendOSCMessage(_OSCeArg);
            //================================= amg soundcool
         if (statics.DEBUGGING) statics.DEBUGGINGTEXT=(_OSCeArg.Address + " " + nuevovalor.ToString() );/// activa debuging en pantalla 
            if (statics.VIBRATE) Handheld.Vibrate();

        }




    }
}