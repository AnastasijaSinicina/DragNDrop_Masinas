using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objekti : MonoBehaviour {
	public GameObject atkritumuMasina;
	public GameObject atraPalidziba;
	public GameObject autobuss;
    public GameObject cementaMasina;
    public GameObject e46;
    public GameObject b2;
    public GameObject e61;
    public GameObject eskavators;

    [HideInInspector]
	public Vector2 atkrMKoord;
	[HideInInspector]
	public Vector2 atrPalKoord;
    [HideInInspector]
    public Vector2 bussKoord;
    [HideInInspector]
    public Vector2 cementaKoord;
    [HideInInspector]
    public Vector2 e46Koord;
    [HideInInspector]
    public Vector2 e61Koord;
    [HideInInspector]
    public Vector2 b2Koord;
    [HideInInspector]
    public Vector2 eskKord;

    public Canvas kanva;
	public AudioSource audioAvots;
	public AudioClip[] skanasKoAtskanot;

	public bool vaiIstajaVieta = false;
	public GameObject pedejaisVilktais = null;

    // Use this for initialization
    void Start () {
		atkrMKoord = atkritumuMasina.GetComponent<RectTransform>().localPosition;
        atrPalKoord = atraPalidziba.GetComponent<RectTransform>().localPosition;
        bussKoord = autobuss.GetComponent<RectTransform>().localPosition;
        cementaKoord = cementaMasina.GetComponent<RectTransform>().localPosition;
        e46Koord = e46.GetComponent<RectTransform>().localPosition;
        e61Koord = e61.GetComponent<RectTransform>().localPosition;
        b2Koord = b2.GetComponent<RectTransform>().localPosition;
        eskKord = eskavators.GetComponent<RectTransform>().localPosition;
    }

    // Update is called once per frame
    void Update () {
		
	}
}
