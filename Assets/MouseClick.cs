using UnityEngine;
using System.Collections;

public class MouseClick : MonoBehaviour {
	RaycastHit hit;
	GameObject target;
	Vector3 clickPosition;
	Ray ray;
	CountPoint countPoint;
	public GameObject parent;
	
	// Use this for initialization
	void Start () {
		countPoint = parent.GetComponent<CountPoint> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown (0)) {
			ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			if (Physics.Raycast(ray,out hit, 100)) {
				target= hit.collider.gameObject;
				if(target.CompareTag("target")){
					countPoint.Point (1);
					Destroy (target);

				}else if(target.CompareTag("target2")){
					countPoint.Point (2);
					Destroy(target);
				}
			
			}else{
				countPoint.Point (-1);
		}
	}
 }
}