using UnityEngine;
using System.Collections;

public class GridInstantiate : MonoBehaviour {

	public Transform floorTile;
	public Transform wallTile;
	public Transform genPath;
	//public Transform genRoom;
	int roomSize;
	float genPathRate = 0f;


	void Start () {
		genPathRate = Random.Range(0f,1f);
		roomSize = Random.Range(3, 7);
		Color randC = new Color(Random.value, Random.value, Random.value, 1f);
		//Vector3 curPos = new Vector3 (0f, 0f, 0f);
		for (int x = 0; x<roomSize; x++) {
			for (int z = 0; z<roomSize; z++) {
				Vector3 pos = new Vector3 (x * 5f, 0f, z * 5f) + transform.position;

				float rand = Random.Range (0f, 1f);
				if (rand<0.7f) {
					Transform newItem = (Transform) Instantiate(floorTile, pos, Quaternion.identity);
					newItem.GetComponent<Renderer>().material.color = randC;
				} else if (rand<0.95f) {
					Transform newItem = (Transform) Instantiate(wallTile,pos, Quaternion.identity);
					newItem.GetComponent<Renderer>().material.color = randC;
				} else {
				}
			}
		}

		if (genPathRate > 0.3f){
			Transform newItem = (Transform) Instantiate ( genPath, transform.position,transform.rotation);
		} else {
			GameObject.Find("Main Camera").GetComponent<ResetLevel>().ShowBtn();
			//Instantiate (genRoom, transform.position, transform.rotation);
		}
		Destroy(gameObject);

	}


}
