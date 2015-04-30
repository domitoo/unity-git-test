using UnityEngine;
using System.Collections;

public class TargetBone : MonoBehaviour {
	public GameObject prefab;
	public GameObject prefab2;
	float timer;
	float timer2;
	Vector3 position = new Vector3(0f,0f,15f);
	Vector3 position2 = new Vector3(0f,0f,15f);
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		timer2 += Time.deltaTime;

		if( timer >= 1f){
			position.x = Random.Range(3f,18f);
			Instantiate (prefab, position, Quaternion.identity);
			timer = 0f;
		}
		
		if( timer2 >= 3f){
			position2.x = Random.Range(3f,18f);
			Instantiate (prefab2, position2, Quaternion.identity);
			timer2 = 0f;
		}

	}
}
