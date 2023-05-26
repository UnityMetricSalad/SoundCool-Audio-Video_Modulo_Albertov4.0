using UnityEngine;
using System.Collections;
using UnityEngine.UI;
namespace UniOSC
{
    public class SliderModControl : MonoBehaviour
    {

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
        public Text textMod;
        public void selectMod(float value)
        {
            string result;
            int indice = (int)Mathf.Floor(value * 33f) + 1;
            //Debug.Log (indice);

            statics.modDictionary.TryGetValue(indice, out result);
            textMod.text = indice + "- " + result;
        }
    }
}
