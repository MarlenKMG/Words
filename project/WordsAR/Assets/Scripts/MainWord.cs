using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainWord : MonoBehaviour {

	[SerializeField] private GameObject catGO;
	[SerializeField] private GameObject dogGO;
	[SerializeField] private GameObject tigerGO;
	[SerializeField] private Text wordUI;
	[SerializeField] private GameObject sorryGO;
	[SerializeField] List<string> alf = new List<string>();
	[SerializeField] List<GameObject> chars = new List<GameObject>();

	private string tmp = "";
	public string Word = "Show cubes";

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
				dogGO.SetActive (false);
				tigerGO.SetActive (false);
				sorryGO.SetActive (false);
			} else if (Word == alf[1]) {
				//dog
				dogGO.SetActive (true);
				tigerGO.SetActive (false);
				catGO.SetActive (false);
				sorryGO.SetActive (false);
			} else if (Word == alf[2]) {
				//tig
				dogGO.SetActive (false);
				catGO.SetActive (false);
				sorryGO.SetActive (false);
				tigerGO.SetActive (true);
			} else {
				tigerGO.SetActive (false);
				dogGO.SetActive (false);
				catGO.SetActive (false);
				sorryGO.SetActive (false);
				if (Word != "Show cubes") {
					sorryGO.SetActive (true);
				}
			}
		}
	}

	public void resetChars(){
		Word = "Show cubes";
		foreach (GameObject go in chars) {
			go.GetComponent<SetRay> ().NumberWord = -1;
		}
	}

	public void goToMainMenu() {
		Application.LoadLevel (0);
	}
}
