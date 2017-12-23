using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetRay : MonoBehaviour {

	[SerializeField] private GameObject cameraGO;

	public int NumberWord = -1;

	private int tmp = 200;

	private RaycastHit hit;
	private RaycastHit hit1;
	private Ray rayRight;
	private Ray rayLeft;

	void Update(){
		rayRight = new Ray(transform.position, transform.right);
		rayLeft = new Ray(transform.position, -transform.right);
		if (Physics.Raycast (rayRight, out hit)) {
			if (hit.transform.tag == "Char") {
				if (!Physics.Raycast (rayLeft, out hit1) && NumberWord != 0) {
					cameraGO.GetComponent<MainWord> ().Word = "";
					NumberWord = 0;
					cameraGO.GetComponent<MainWord> ().Word = "" + transform.name;
					hit.transform.GetComponent<SetRay> ().NumberWord = NumberWord + 1;
					cameraGO.GetComponent<MainWord> ().Word = cameraGO.GetComponent<MainWord> ().Word + hit.transform.name;
					if (tmp != NumberWord) {
						hit.transform.GetComponent<SetRay> ().addNewChar ();
						tmp = NumberWord;
					}
				}
			}
		}
	}

	public void addNewChar () {
		tmp = NumberWord;
		rayRight = new Ray (transform.position, transform.right);
		if (Physics.Raycast (rayRight, out hit)) {
			if (hit.transform.tag == "Char") {
				hit.transform.GetComponent<SetRay> ().NumberWord = NumberWord + 1;
				cameraGO.GetComponent<MainWord> ().Word = cameraGO.GetComponent<MainWord> ().Word + hit.transform.name;
				hit.transform.GetComponent<SetRay> ().addNewChar ();
			}
		}
	}
}

