using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objekti : MonoBehaviour {
	public GameObject atkritumuMasina;
	public GameObject atraPalidziba;
	public GameObject autobuss;

	[HideInInspector]
	public Vector2 atkrMKoord;
	[HideInInspector]
	public Vector2 atrPalKoord;
    [HideInInspector]
    public Vector2 bussKoord;

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
    }

    // Update is called once per frame
    void Update () {
		
	}
}
