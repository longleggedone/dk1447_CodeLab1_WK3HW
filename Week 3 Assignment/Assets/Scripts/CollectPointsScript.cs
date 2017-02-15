using UnityEngine;
using System.Collections;

public class CollectPointsScript : MonoBehaviour {

	public GameManagerScript gameManager;

	public int pointsValue = 10;

	public int damageValue = 1;

	void OnCollisionEnter2D (Collision2D other){
		//Debug.Log ("collided");
		if (other.gameObject.tag == "Points")
		{
			Destroy(other.gameObject);
			gameManager.Score += pointsValue;
		}
		if (other.gameObject.tag == "Obstacle"){
			gameManager.Health -= damageValue;
		}
	}
}
