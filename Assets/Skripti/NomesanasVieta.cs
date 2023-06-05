using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class NomesanasVieta : MonoBehaviour, IDropHandler{
	private float vietasZRot, velkObjZRot, rotacijasStarpiba;
	private Vector2 vietasIzm, velkObjIzm;
	private float xIzmeruStarp, yIzmeruStarp;
	public Objekti objektuSkripts;



	//public int sk=0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnDrop(PointerEventData eventData)
    {
		if(eventData.pointerDrag != null){
			if (eventData.pointerDrag.tag.Equals(tag))
			{
				vietasZRot = GetComponent<RectTransform>().transform.eulerAngles.z;

				velkObjZRot = eventData.pointerDrag.GetComponent<RectTransform>().transform.eulerAngles.z;

				rotacijasStarpiba = Mathf.Abs(velkObjZRot - vietasZRot);

				velkObjIzm = eventData.pointerDrag.GetComponent<RectTransform>().localScale;

				vietasIzm = GetComponent<RectTransform>().localScale;

				xIzmeruStarp = Mathf.Abs(velkObjIzm.x - vietasIzm.x);
				yIzmeruStarp = Mathf.Abs(velkObjIzm.y - vietasIzm.y);

				if ((rotacijasStarpiba <= 6 || (rotacijasStarpiba >= 354 && rotacijasStarpiba <= 360))
					&& (xIzmeruStarp <= 0.1 && yIzmeruStarp <= 0.1))
				{

					objektuSkripts.vaiIstajaVieta = true;
					eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
					eventData.pointerDrag.GetComponent<RectTransform>().localRotation = GetComponent<RectTransform>().localRotation;
					eventData.pointerDrag.GetComponent<RectTransform>().localScale = GetComponent<RectTransform>().localScale;
					objektuSkripts.masinas++;
					objektuSkripts.rez ();

					switch (eventData.pointerDrag.tag)
					{
						case "atkritumi":
							objektuSkripts.audioAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[1]);
							break;
						case "medicina":
							objektuSkripts.audioAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[2]);
							break;
						case "buss":
							objektuSkripts.audioAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[3]);
							break;                    
                        case "cements":
                            objektuSkripts.audioAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[6]);
                            break;
                        case "e46":
                            objektuSkripts.audioAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[4]);
                            break;                     
                        case "e61":
                            objektuSkripts.audioAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[3]);
                            break;
                        case "b2":
                            objektuSkripts.audioAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[4]);
                            break;
                        case "eskavator":
                            objektuSkripts.audioAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[7]);
                            break;
					case "policija":
						objektuSkripts.audioAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[2]);
						break;
					case "traktor":
						objektuSkripts.audioAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[8]);
						break;
					case "traktor2":
						objektuSkripts.audioAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[9]);
						break;
					case "uguns":
						objektuSkripts.audioAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[10]);
						break;

                    }
				}	

			} else {
                objektuSkripts.vaiIstajaVieta = false;
                objektuSkripts.audioAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[0]);

                switch (eventData.pointerDrag.tag)
                {
                    case "atkritumi":
                        objektuSkripts.atkritumuMasina.GetComponent<RectTransform>().localPosition = objektuSkripts.atkrMKoord;
                        break;
                    case "medicina":
                        objektuSkripts.atraPalidziba.GetComponent<RectTransform>().localPosition = objektuSkripts.atrPalKoord;

                        break;
                    case "buss":
                        objektuSkripts.autobuss.GetComponent<RectTransform>().localPosition = objektuSkripts.bussKoord;
                        break;
       
                    case "cements":
                        objektuSkripts.cementaMasina.GetComponent<RectTransform>().localPosition = objektuSkripts.cementaKoord;
                        break;
                    case "e46":
                        objektuSkripts.e46.GetComponent<RectTransform>().localPosition = objektuSkripts.e46Koord;
						break;
                   
                    case "e61":
                        objektuSkripts.e61.GetComponent<RectTransform>().localPosition = objektuSkripts.e61Koord;
                        break;
                    case "b2":
                        objektuSkripts.b2.GetComponent<RectTransform>().localPosition = objektuSkripts.b2Koord;
                        break;
                    case "eskavator":
                        objektuSkripts.eskavators.GetComponent<RectTransform>().localPosition = objektuSkripts.eskKord;
                        break;
				case "policija":
					objektuSkripts.policija.GetComponent<RectTransform>().localPosition = objektuSkripts.policijaKoord;
					break;

				case "traktor":
					objektuSkripts.traktors.GetComponent<RectTransform>().localPosition = objektuSkripts.traktorKoord;
					break;

				case "traktor2":
					objektuSkripts.traktors2.GetComponent<RectTransform>().localPosition = objektuSkripts.traktor2Koord;
					break;

				case "uguns":
					objektuSkripts.ugunsdzesejs.GetComponent<RectTransform>().localPosition = objektuSkripts.ugunsKoord;
					break;


                }
            }

		}

    }
}
