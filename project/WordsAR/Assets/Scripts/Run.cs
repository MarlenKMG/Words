using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Run : MonoBehaviour {

	[SerializeField] private GameObject loadGO;
	[SerializeField] private GameObject wordsGO;

	public void RunGame(){
		loadGO.SetActive (true);
		Application.LoadLevel (1);
	}

	public void QuitGame(){
		Application.Quit ();
	}

	public void words () {
		if (wordsGO.activeSelf) {
			wordsGO.SetActive (false);
		} else {
			wordsGO.SetActive (true);
		}
	}
}
