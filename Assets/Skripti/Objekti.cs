using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Objekti : MonoBehaviour {
    public GameObject atkritumuMasina;
    public GameObject atraPalidziba;
    public GameObject autobuss;
    public GameObject cementaMasina;
    public GameObject e46;
    public GameObject b2;
    public GameObject e61;
    public GameObject eskavators;
    public GameObject policija;
    public GameObject traktors;
    public GameObject traktors2;
    public GameObject ugunsdzesejs;
    public int masinas;
    public GameObject izkartne;
    public GameObject restart;
    public int zvaigznesSk;
    public Sprite[] zvaigznesMasivs;
    public GameObject zvaigznes;
    //public float laiks;
   // public bool laiksBool;

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
    [HideInInspector]
    public Vector2 policijaKoord;
    [HideInInspector]
    public Vector2 traktorKoord;
    [HideInInspector]
    public Vector2 traktor2Koord;
    [HideInInspector]
    public Vector2 ugunsKoord;

    public Canvas kanva;
    public AudioSource audioAvots;
    public AudioClip[] skanasKoAtskanot;

    public bool vaiIstajaVieta = false;
    public GameObject pedejaisVilktais = null;

	public GameObject taimers;
	public float miliSekundes;
	public int sekundes;
	public int minutes;
	public int stundas;
	public Text text;

    // Use this for initialization
    void Start() {
        atkrMKoord = atkritumuMasina.GetComponent<RectTransform>().localPosition;
        atrPalKoord = atraPalidziba.GetComponent<RectTransform>().localPosition;
        bussKoord = autobuss.GetComponent<RectTransform>().localPosition;
        cementaKoord = cementaMasina.GetComponent<RectTransform>().localPosition;
        e46Koord = e46.GetComponent<RectTransform>().localPosition;
        e61Koord = e61.GetComponent<RectTransform>().localPosition;
        b2Koord = b2.GetComponent<RectTransform>().localPosition;
        eskKord = eskavators.GetComponent<RectTransform>().localPosition;
        policijaKoord = policija.GetComponent<RectTransform>().localPosition;
        traktorKoord = traktors.GetComponent<RectTransform>().localPosition;
        traktor2Koord = traktors2.GetComponent<RectTransform>().localPosition;
        ugunsKoord = ugunsdzesejs.GetComponent<RectTransform>().localPosition;
		zvaigznes.SetActive (false);
    }
	public void FixedUpdate(){
		if (masinas < 12) {
			miliSekundes += 0.02f;
		}
		if (miliSekundes >= 1) {
			sekundes++;
			miliSekundes = 0;
		}
		if (sekundes >= 60) {
			minutes++;
			sekundes=0;
		}
		if (minutes >= 60) {
			stundas++;
			sekundes = 0;
		}
		text.text = $"{stundas} : {minutes} : {sekundes}";

		switch (minutes)
		{
		case 0:
			zvaigznesSk = 2;
			break;
		case 1:
			zvaigznesSk = 1;
			break;
		case 2: 
			zvaigznesSk = 0;
			break;
		}
	}

    public void rez() {
        if (masinas >= 2) {
			zvaigznes.SetActive (true);
            izkartne.SetActive(true);
            restart.SetActive(true);
			taimers.SetActive(true);


			switch (zvaigznesSk) {
			case 0:
				zvaigznes.GetComponent<Image> ().sprite = zvaigznesMasivs [0];
				break;
			case 1:
				zvaigznes.GetComponent<Image> ().sprite = zvaigznesMasivs [1];
				break;
			case 2:
				zvaigznes.GetComponent<Image> ().sprite = zvaigznesMasivs [2];
				break;
			}
        }
      
    }

    

    // Update is called once per frame
    void Update () {
		
	}
}
