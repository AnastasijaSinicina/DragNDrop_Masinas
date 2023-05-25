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


    void Start()
    {
        kanvasGrupa = GetComponent<CanvasGroup>();
        velkObjRectTransf = GetComponent<RectTransform>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        objektuSkripts.pedejaisVilktais = null;
        kanvasGrupa.alpha= 0.6f;
        kanvasGrupa.blocksRaycasts= false;

    }
    
    public void OnDrag(PointerEventData eventData)
    {
        velkObjRectTransf.anchoredPosition += eventData.delta / objektuSkripts.kanva.scaleFactor;

    }

    public void OnEndDrag(PointerEventData eventData)
    {
        objektuSkripts.pedejaisVilktais = eventData.pointerDrag;
        kanvasGrupa.alpha = 1f;

        if (objektuSkripts.vaiIstajaVieta == false)
            kanvasGrupa.blocksRaycasts = true;

        else
            objektuSkripts.pedejaisVilktais = null;

        objektuSkripts.vaiIstajaVieta= false;          
    }

}
