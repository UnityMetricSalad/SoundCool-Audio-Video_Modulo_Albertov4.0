using UnityEngine;
using System.Collections;
using UnityEngine.UI;
namespace UniOSC
{
    public class SliderScreenControl : MonoBehaviour
    {

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
        public Text textScreen;
        public void selectScreen(float value)
        {
            string result;
            int indice = (int)Mathf.Floor(value * 5f) + 1;
            //Debug.Log (indice);

            statics.screenDictionary.TryGetValue(indice, out result);
            textScreen.text = indice + "- " + result;
        }
    }
}
