using UnityEngine;
using System.Collections;

public class TargetUp : MonoBehaviour {
	Vector3 pos;


	// Use this for initialization
	void Start () {
		pos = transform.localPosition;
	}
	
	// Update is called once per frame
	void Update () {
		transform.localPosition = pos;  
		pos.y += 0.03f;

		if (this.transform.localPosition.y >= 10) {
			Destroy (this.gameObject);
		}
	}
}
