using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetRay : MonoBehaviour {

	[SerializeField] private GameObject cameraGO;

	public int NumberWord = -1;

	private int tmp = 0;

	void Update(){
		
		RaycastHit hit;
		RaycastHit hit1;
		Ray rayRight = new Ray(transform.position, transform.right);
		Ray rayLeft = new Ray(transform.position, -transform.right);
		if (Physics.Raycast(rayRight, out hit)) {
			if (hit.transform.tag == "Char") {
				if (!Physics.Raycast (rayLeft, out hit1)) {
					if (NumberWord != tmp){
						//NumberWord != 0 || hit.transform.GetComponent<SetRay> ().NumberWord != NumberWord+1)
						cameraGO.GetComponent<MainWord> ().Word = "";
						NumberWord = 0;
						cameraGO.GetComponent<MainWord> ().Word = cameraGO.GetComponent<MainWord> ().Word + transform.name;
						hit.transform.GetComponent<SetRay> ().NumberWord = NumberWord + 1;
						cameraGO.GetComponent<MainWord> ().Word = cameraGO.GetComponent<MainWord> ().Word + hit.transform.name;
						tmp = NumberWord;
					} 
				} else {
					if (NumberWord != tmp) {
						hit.transform.GetComponent<SetRay> ().NumberWord = 2;
						print (hit.transform.name);
						cameraGO.GetComponent<MainWord> ().Word = cameraGO.GetComponent<MainWord> ().Word + hit.transform.name;
					}
				}
			}
		}
	}
}

