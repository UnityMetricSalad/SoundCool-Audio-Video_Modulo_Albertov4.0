using UnityEngine;
using System.Collections;
using UnityEngine.UI;
namespace UniOSC
{
    public class SliderMidiControl : MonoBehaviour {

        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }
        public Text textMidi;
        public void selectMidi(float value) {
            string result;
			int indice = (int)Mathf.Floor(value*127f)+1;
			//Debug.Log (indice);

			statics.midiDictionary.TryGetValue(indice, out result);
            textMidi.text = indice + "- " +result;
        }
    }
}
