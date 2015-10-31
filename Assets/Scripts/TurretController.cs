using UnityEngine;
using System.Collections;


public class TurretController : MonoBehaviour {


	void Update () 
	{
		Vector3 mousePos = Input.mousePosition;
		mousePos.z = 100.0f;
		mousePos = Camera.main.ScreenToWorldPoint(mousePos);
		Vector3 objectPos = Camera.main.WorldToScreenPoint (transform.position);
		objectPos.z = 100.0f;
		objectPos = Camera.main.ScreenToWorldPoint(objectPos);
		mousePos.x = mousePos.x - objectPos.x;
		mousePos.y = mousePos.y - objectPos.y;
		float angle = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg - 90;
		Vector3 direction = new Vector3 (0, 0, angle);
		transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(direction), Time.deltaTime * 300f);
	}
}