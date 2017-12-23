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
	private bool firstChar = false;

	void Update(){
		rayRight = new Ray(transform.position, transform.right);
		rayLeft = new Ray(transform.position, -transform.right);
		if (Physics.Raycast (rayRight, out hit)) {
			if (hit.transform.tag == "Char" && NumberWord !=0) {
				if (!Physics.Raycast (rayLeft, out hit1)) {
					firstChar = true;
					cameraGO.GetComponent<MainWord> ().Word = "";
					NumberWord = 0;
					cameraGO.GetComponent<MainWord> ().Word = "" + transform.name;
					tmp = NumberWord;
				}
			}
		}
		if (Physics.Raycast (rayRight, out hit)) {
			if (hit.transform.tag == "Char" && hit.transform.GetComponent<SetRay> ().NumberWord != NumberWord + 1) {
				int tmpInt = NumberWord + 1;
				hit.transform.GetComponent<SetRay> ().NumberWord = tmpInt;
				cameraGO.GetComponent<MainWord> ().Word = cameraGO.GetComponent<MainWord> ().Word + hit.transform.name;
			}
		}
	}
}

