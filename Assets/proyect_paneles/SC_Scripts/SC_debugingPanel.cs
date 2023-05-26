using UnityEngine;
using System.Collections;
using UnityEngine.UI;
namespace UniOSC
{
    public class SC_debugingPanel : MonoBehaviour
    {

       
        public GameObject panelDebuging1;
        public GameObject panelDebuging2;
        public GameObject panelDebuging3;
        public void debuging(bool d)
        {

            statics.DEBUGGING = d;
           panelDebuging1.SetActive(statics.DEBUGGING);
           panelDebuging2.SetActive(statics.DEBUGGING);
           panelDebuging3.SetActive(statics.DEBUGGING);

        }
        
    }
}
