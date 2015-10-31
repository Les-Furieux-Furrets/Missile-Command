using UnityEngine;
using System.Collections;

public class Target : MonoBehaviour {

	float dist;
	public GameObject missile;
	public Explode explosion;

	void Start () 
	{

	}
	
	void Update () 
	{
		dist = Vector3.Distance(transform.position, missile.transform.position);
		if (dist < 0.1f) 
		{
			explosion.enabled = true;
			Destroy(gameObject);
		}
	}
}
