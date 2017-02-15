using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour {

	private int score;

	public int Score{
		get{
			return score;
		}
		set{
			score = value;
			Debug.Log ("Score: " + Score);
		}
	}

	private const int HEALTH_MIN = 0;
	public const int HEALTH_MAX = 5;

	//public int damageAmt = 1;

	private static int health;

	public int Health{
		get{
			return health;
		}

		set{
			health = value;

			if(health > HEALTH_MAX){
				health = HEALTH_MAX;
			}

			if(health < HEALTH_MIN){
				health = HEALTH_MIN;
			}

			Debug.Log ("Health: " + Health);
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

		score = 0;
		health = HEALTH_MAX;
	}
	
	// Update is called once per frame
	void Update () {
		if(score == 100){
			SceneManager.LoadScene("Scene 2");
		}
		if(health == 0){
			SceneManager.LoadScene("Scene 1");
		}
	}
}
