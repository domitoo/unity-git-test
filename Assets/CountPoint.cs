using UnityEngine;
using System.Collections;

public class CountPoint : MonoBehaviour {
	private int score;


	// Use this for initialization
	void Start () {
		score = 0;
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void Point(int pt){
		if(score+pt != -1){
			score += pt; 
		}

	}

	void OnGUI(){
		GUI.Label(new Rect(10,10,100,100),"Score : "+score);
	
	}

}
