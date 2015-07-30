using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TenPrint : MonoBehaviour {

	public Text printText;

	void Start () {
		// set the random seed,
		Random.seed = 420;

		// While() loop: will check the if() statement
		// inside of it, while(true) do everything
		// if false, keep going
		// an infinit loop calls "unbounded loop"
		//a bounded loop ends eventually
		int counter = 0;
		while ( counter < 6000 ){
			printText.text += Random.Range (0f, 100f) > 50f ? "/" : "\\" ;
			counter ++;
		}
	}

	void Update () {
//
//			printText.text += Random.Range (0f, 100f) > 50f ? "/" : "\\" ;
//
//
		// so,pleast reset is tell the unity to reload the current level

		if (Input.GetKey (KeyCode.R) ) {

			Application.LoadLevel (Application.loadedLevel);
		}

	}
}
