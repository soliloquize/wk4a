using UnityEngine;
using System.Collections;

public class PathInstantiate : MonoBehaviour {

	int counter = 0;
	public Transform floorPrefab;
	public Transform genWallPrefab;
	Color randC = new Color();
	//public Transform genRoom;
	//public Transform genPath;
	float genWallRate = 0f;

	void Start () {
		randC = new Color(Random.value, Random.value, Random.value, 1f);
		//Vector3 pos = new Vector3 (0f, 0f, 0f);
		//Quaternion rotation = Quaternion.identity;

//		for (int i=0; i < 50; i++) {
//
//			float f = Random.Range (0f, 1f);
//			float rot = 0f;
//			if (f <= 0.25f) {
//				rot = 90f;
//			} else if (f > 0.25f && f <= 0.5f) {
//				rot = -90f;
//			}
//
//			//Transform newFloor = (Transform) Instantiate ( floorPrefab, pos, rotation);
//			//newFloor.Rotate(new Vector3(0f, rot, 0f));
//			//rotation = newFloor.rotation;
//			//pos = pos + newFloor.forward * 5f;
//			Instantiate(floorPrefab, transform.position, transform.rotation);
//			transform.Rotate (0f, rot,0f);
//			transform.position = transform.position + transform.forward *5f;
//			counter ++;
//		}
//		if (counter == 50){
//			Destroy(gameObject);
//		}

		genWallRate = Random.Range(0f,1f);

	}

	void Update () {

		//if (canGenPath == true){
			if (counter < 50){
				float f = Random.Range (0f, 1f);
				float rot = 0f;
				if (f <= 0.25f) {
					rot = 90f;
				} else if (f > 0.25f && f <= 0.5f) {
					rot = -90f;
				}
				
				//Transform newFloor = (Transform) Instantiate ( floorPrefab, pos, rotation);
				//newFloor.Rotate(new Vector3(0f, rot, 0f));
				//rotation = newFloor.rotation;
				//pos = pos + newFloor.forward * 5f;
				Transform newItem = (Transform) Instantiate(floorPrefab, transform.position, transform.rotation);
				newItem.GetComponent<Renderer>().material.color = randC;
				transform.Rotate (0f, rot,0f);
				transform.position = transform.position + transform.forward *5f;
				counter ++;
			} else {

				if (genWallRate > 0.3f){
				Instantiate(genWallPrefab, transform.position, transform.rotation);
				} else {
				GameObject.Find("Main Camera").GetComponent<ResetLevel>().ShowBtn();
			}
				Destroy(gameObject);
			}
		//}


	}

}
