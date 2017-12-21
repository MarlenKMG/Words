using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainWord : MonoBehaviour {

	[SerializeField] private GameObject catGO;
	[SerializeField] private GameObject dogGO;
	[SerializeField] private GameObject tigerGO;
	[SerializeField] private Text wordUI;
	public string Word = "show cubes";

	private string tmp = "";

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(tmp != Word) {
			wordUI.text = Word;
			tmp = Word;
			if (Word == "CAT") {
				catGO.SetActive (true);
			} else {
				catGO.SetActive (false);
			}
			if (Word == "DOG") {
				dogGO.SetActive (true);
			} else {
				dogGO.SetActive (false);
			}
			if (Word == "AT") {
				tigerGO.SetActive (true);
			} else {
				tigerGO.SetActive (false);
			}
		}

		//uggu;
	}
}
