using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

 	public GameObject missile;
	public GameObject objective;
	GameObject currentMissile;
	float temps = 2;
	Explode explode;
	Target target;
	
  GameObject missileContainer;
  
  // Use this for initialization
  void Awake () 
	{
    missileContainer = new GameObject(name+"-container");
  }
	
  
  // spawn in late Update to wait for position calculations
  void Update () 
	{
		if (Input.GetMouseButtonDown(0) && temps > 2) 
		{
    		Launch();
			Target();
			temps = 0;
		}
		temps = temps + Time.deltaTime;
  }
  
	void Launch()
	{
		GameObject clone = (GameObject)Instantiate(missile);
		clone.transform.position = transform.position;
		clone.transform.rotation = transform.rotation;
		clone.transform.parent = missileContainer.transform;
		currentMissile = clone;
		explode = clone.GetComponent<Explode> ();
  	}

	void Target()
	{
		Vector3 pos = Input.mousePosition;
		pos = Camera.main.ScreenToWorldPoint(pos);
		pos.z = 0;
		GameObject clone = (GameObject)Instantiate(objective);
		clone.transform.position = pos;
		clone.transform.rotation = transform.rotation;
		clone.transform.parent = missileContainer.transform;
		target = clone.GetComponent<Target>();
		target.missile = currentMissile;
		target.explosion = explode;
	}
}
