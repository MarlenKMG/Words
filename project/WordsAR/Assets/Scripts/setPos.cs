using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setPos : MonoBehaviour {
	[SerializeField] private GameObject charGO;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = charGO.transform.position;
		transform.rotation = charGO.transform.rotation;
		//transform.rotation = Quaternion.Euler(charGO.transform.rotation.x, charGO.transform.rotation.x + 180, charGO.transform.rotation.z);
	}
}
