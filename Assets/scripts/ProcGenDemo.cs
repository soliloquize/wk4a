using UnityEngine;
using System.Collections;
using System.Collections.Generic; // to use list<>

public class ProcGenDemo : MonoBehaviour {

	// to instantiate, need original copy of something
	public Transform prefab;
	public List<Transform> listOfClone = new List<Transform>();

	void Start() {
		// for loop: a "FOR LOOP" is a WHILE LOOP with a built-in control
		// 1st part : initialize a variable, usually a counter
		// 2nd part: the "if" statement to check each time
		// 3rd part: what to do at the end

		for (int  i = 0; i<200; i++) {

			Transform newItem =(Transform) Instantiate (prefab, /*new Vector3 (Mathf.Sin(Random.Range(200f, 360f)) * 10f, 
			                                                                 Random.Range (-1f, 1f), 
			                                                                 Mathf.Cos(Random.Range(200f, 360f)) * 10f)*/ Random.insideUnitCircle * 5f, 
			                                            /*Quaternion.Euler (Random.Range (0f, 360f), 
			                  											Random.Range (0f, 360f),
			                  											Random.Range (0f, 360f)) */ Quaternion.identity); // as GameObject;
			//newItem.localScale = new Vector3 ( Random.Range (0.1f, 0.5f),
			//                                            Random.Range (0.1f, 0.5f),
			//                                            Random.Range (0.1f, 0.5f));
			newItem.GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value, 1f);
			Debug.Log (i.ToString());
			listOfClone.Add (newItem);
		}
			
		//Vector3 torus = new Vector3 (Mathf.Cos(Random.Range(2f,3f)),);

	}

	void Update() {

		if(Input.GetKey (KeyCode.Q)){
			for ( int i = 0; i <100; i++){
				listOfClone[i].transform.localScale *= 1.1f;
			}
		}
		if(Input.GetKey (KeyCode.E)){
			for ( int i = 0; i <100; i++){
				listOfClone[i].transform.localScale *= 0.9f;
			}
		}
	}
}
