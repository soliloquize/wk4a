using UnityEngine;
using System.Collections;

public class ResetLevel : MonoBehaviour {
	public GameObject resetBtn;

	public void ShowBtn(){
		resetBtn.SetActive(true);
		Time.timeScale = 0;
	}

	public void ReStartLevel() {
		Application.LoadLevel(Application.loadedLevel);
	}

	public void FixedUpdate() {
		transform.position += new Vector3 (0f, 0.2f, 0f);
	}

	public void Update() {
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
