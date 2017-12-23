using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainWord : MonoBehaviour {

	[SerializeField] private GameObject catGO;
	[SerializeField] private GameObject dogGO;
	[SerializeField] private GameObject tigerGO;
	[SerializeField] private Text wordUI;
	[SerializeField] List<string> alf = new List<string>();
	[SerializeField] List<GameObject> chars = new List<GameObject>();
	private string tmp = "";

	public string Word = "show cubes";

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(tmp != Word) {
			wordUI.text = Word;
			tmp = Word;
			//cat
			if (Word == alf[0]) {
				catGO.SetActive (true);
			} else {
				catGO.SetActive (false);
			}
			//dog
			if (Word == alf[1]) {
				dogGO.SetActive (true);
			} else {
				dogGO.SetActive (false);
			}
			//tig
			if (Word == alf[2]) {
				tigerGO.SetActive (true);
			} else {
				tigerGO.SetActive (false);
			}
		}
	}

	public void resetChars(){
		Word = "Show cubes";
		foreach (GameObject go in chars) {
			go.GetComponent<SetRay> ().NumberWord = -1;
		}
	}
}
