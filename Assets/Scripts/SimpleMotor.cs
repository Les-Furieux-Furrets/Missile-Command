using UnityEngine;
using System.Collections;

public class SimpleMotor : MonoBehaviour {

 	public float speed = 0;
 	public bool useLocalDirection = true;
 	public Vector3 direction = Vector3.zero;
	
	void Update () 
	{
    	if(useLocalDirection) transform.position += transform.TransformDirection(direction) * speed * Time.deltaTime;
    	else transform.position += direction * speed * Time.deltaTime;
	}
}