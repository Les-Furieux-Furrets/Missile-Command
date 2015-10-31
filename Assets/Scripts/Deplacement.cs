using UnityEngine;
using System.Collections;

public class Deplacement : MonoBehaviour {

	Vector3 cible;
	float speed;

	void Start () 
	{
		cible = new Vector3(Random.Range(0, Screen.width), 0, 0);
		cible = Camera.main.ScreenToWorldPoint(cible);
		cible.z = 0;
		speed = Random.Range (0.01f, 0.05f);
	}
	
	void Update () 
	{
		transform.position = Vector3.MoveTowards (transform.position, cible, speed);
	}
}
