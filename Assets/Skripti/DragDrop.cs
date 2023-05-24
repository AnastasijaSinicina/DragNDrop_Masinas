using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class DragDrop : MonoBehaviour, 
  IBeginDragHandler, IDragHandler, IEndDragHandler{
    //uzglabas noradi uz objekti skriptu
    public Objekti objektuSkripts;
    //Uzglabas noradi uz katra objekta CanvasGroup
    private CanvasGroup kanvasGrupa;
    private RectTransform velkObjRectTransf;


    public void OnBeginDrag(PointerEventData eventData)
    {
        kanvasGrupa = GetComponent<CanvasGroup>();
        velkObjRectTransf= GetComponent<RectTransform>();
    }
    
    public void OnDrag(PointerEventData eventData)
    {
        
    }

    public void OnEndDrag(PointerEventData eventData)
    {

    }




    // Use this for initialization
    void Start () {
		
	}
	
}
