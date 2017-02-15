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

	private const int HEALTH_MIN = 0;
	public const int HEALTH_MAX = 5;

	public int damageAmt = 1;

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
