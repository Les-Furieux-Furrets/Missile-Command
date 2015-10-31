using UnityEngine;
using System.Collections;

public class Explode : MonoBehaviour 
{
	public GameObject entity;
	GameObject entityContainer;
	int y;
	int z;

	void Awake () 
	{
		entityContainer = new GameObject(name+"-container");
	}

	void Start () 
	{
		for(int i = 0; i < 18; i++)
		{
			GameObject clone = (GameObject)Instantiate(entity);
			SimpleMotor direction = clone.GetComponent<SimpleMotor>();
			direction.direction = Quaternion.AngleAxis(i*20, Vector3.forward) * Vector3.down;
			direction.speed = 7;
			clone.transform.position = transform.position;
			clone.transform.rotation = transform.rotation;
			clone.transform.parent = entityContainer.transform;
			Destroy(gameObject);
		}
	}
}
