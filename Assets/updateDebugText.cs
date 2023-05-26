using UnityEngine;
using System.Collections;
using UnityEngine.UI;
namespace UniOSC {
public class updateDebugText : MonoBehaviour {

		private Text t;
		void Start(){

			t=this.GetComponent<Text>();
		}
	
	void Update () {
		
			if (statics.DEBUGGING) t.text = statics.DEBUGGINGTEXT;
		}
	}

}