using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {

	public GameObject missile;
	Vector3 pos;
	float temps = 0;
	int i;
	int vague;

	void Start () 
	{
		vague = 0;
	}
	
	void Update () 
	{
		temps += Time.deltaTime;
		if(temps > 5 && vague < 4) 
		{
			for (i = 0; i <= 3; i ++)
			{
				Instantiate (missile);
				pos = new Vector3(Random.Range(0, Screen.width), Screen.height, 0);
				pos = Camera.main.ScreenToWorldPoint(pos);
				pos.z = 0;
				missile.transform.position = pos;
			}
			temps = 0;
			vague++;
		}
	}
}