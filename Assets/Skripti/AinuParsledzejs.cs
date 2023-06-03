using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AinuParsledzejs : MonoBehaviour {

	// Use this for initialization
	public void Apturet()
	{
		Application.Quit();
	}
	
	// Update is called once per frame
	public void uzSpele(){
		SceneManager.LoadScene("Karte", LoadSceneMode.Single);
	}
}
