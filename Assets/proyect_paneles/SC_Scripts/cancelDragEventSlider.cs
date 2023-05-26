using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System;

public class cancelDragEventSlider : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{

	public bool IsDragable;

	#region IBeginDragHandler implementation

	public void OnBeginDrag (PointerEventData eventData)
	{
		
		//if (!IsDragable)  {  return;}

//		Debug.Log ("OnBeginDrag:Do something");
	}

	#endregion

	#region IDragHandler implementation

	public void OnDrag (PointerEventData eventData)
	{
		//if (eventData.pointerEnter.transform.parent.parent!=null) {

		try{
		if (eventData.pointerEnter.transform.parent.parent){//evitamos nulos
			if (eventData.pointerEnter.transform.parent.parent.name == eventData.pointerDrag.name) {
			//	Debug.Log ("OnDrag ok");
			
			}
			}
		}catch(Exception e){

			Debug.Log ("catch exception");
		}

		;
		if (eventData.pointerEnter){
			if (eventData.pointerEnter.name == "Handle") {
				eventData.pointerDrag = eventData.pointerEnter.transform.parent.parent.gameObject;
			//	Debug.Log ("pointerEnter en: " + eventData.pointerEnter.name);
//				Debug.Log ("OnDrag hacia Handle: " + eventData.pointerEnter.transform.parent.parent.gameObject.name);
				OnBeginDrag (eventData);
				//eventData.pointerDrag=null;
			} else if (eventData.pointerEnter.name == "Background") {
				eventData.pointerDrag = eventData.pointerEnter.transform.parent.gameObject;
			//	Debug.Log ("pointerEnter en: " + eventData.pointerEnter.name);
			//	Debug.Log ("OnDrag hacia...: " + eventData.pointerEnter.transform.parent.gameObject.name);
				OnBeginDrag (eventData);

			} else if (eventData.pointerEnter.name == "Fill") {
				eventData.pointerDrag = eventData.pointerEnter.transform.parent.parent.gameObject;
			//	Debug.Log ("pointerEnter en: " + eventData.pointerEnter.name);
			//	Debug.Log ("OnDrag hacia...: " + eventData.pointerEnter.transform.parent.parent.gameObject.name);
				OnBeginDrag (eventData);

				return;
			}
		}
	//	}else {}


	}

	#endregion

	#region IEndDragHandler implementation

	public void OnEndDrag (PointerEventData eventData)
	{
		//if (!IsDragable) return;

//		Debug.Log ("OnEnd: Do something");
	}

	#endregion
}

