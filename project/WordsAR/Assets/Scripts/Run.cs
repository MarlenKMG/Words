using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Run : MonoBehaviour {

	public void RunGame(){
		Application.LoadLevel (1);
	}

	public void QuitGame(){
		Application.Quit ();
	}
}
