using UnityEngine;
using System.Collections;

public class ResetLevel : MonoBehaviour {
	public GameObject resetBtn;
	bool canMoveCam = false;

	public void ShowBtn(){
		resetBtn.SetActive(true);
		canMoveCam = true;
		Time.timeScale = 0;
	}

	public void ReStartLevel() {
		Application.LoadLevel(Application.loadedLevel);
		Time.timeScale = 1f;
	}

	public void FixedUpdate() {
		GameObject genCube = GameObject.FindWithTag("Player");
		Vector3 dir = new Vector3 ( genCube.transform.position.x, 110f, genCube.transform.position.z);
		//Vector3 dir = genCube.transform.position - transform.position;

		transform.position = Vector3.Lerp (transform.position, dir, 0.01f);

	}

	public void Update() {

		if (canMoveCam == true){
			if (Input.GetKey(KeyCode.W)){
				transform.position += new Vector3 (0f, 0f, 5f);
			}
			if (Input.GetKey(KeyCode.A)){
				transform.position += new Vector3 (-5f, 0f, 0f);
			}
			if (Input.GetKey(KeyCode.S)){
				transform.position += new Vector3 (0f, 0f, -5f);
			}
			if (Input.GetKey(KeyCode.D)){
				transform.position += new Vector3 (5f, 0f,0f);
			}
		}
	}
}
