using UnityEngine;
using System.Collections;

public class GameManagerScript : MonoBehaviour {

	private int score;

	public int Score{
		get{
			return score;
		}
		set{
			score = value;

		}
	}

	public static GameManagerScript instance;

	// Use this for initialization
	void Start () {
		if(instance == null){
			instance = this;
		}
		else{
			Destroy(this.gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
