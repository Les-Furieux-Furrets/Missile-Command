using UnityEngine;
using System.Collections;

public class Life : MonoBehaviour {

  public bool useTime = false;
  public float lifetime = 10;
  float timer;

  public int lifePointsStart = 1;
  public int lifePointsMax = 100;
  int currentLifePoints;

	// Use this for initialization
	void Start () {
    currentLifePoints = lifePointsStart;
	}

  public void restorePoint(int nbPoints){
    currentLifePoints = Mathf.Min(currentLifePoints + nbPoints, lifePointsMax);
  }
	
	// Update is called once per frame
	void Update () {
    if(useTime){
      timer += Time.deltaTime;
      if(timer >= lifetime){
        kill ();
      }
    }

    if(currentLifePoints <= 0){
      kill();
    }
	}

  void OnTriggerEnter(Collider other){
    //Debug.Log ("> " + name+" received trigger enter from "+other.name);
    // due to a bug in Triggers we have to double check that colliders intersects (it seems that if a trigger is activated, OnTriggerEnter is also sent to parents that are on the same layer...)
    if(GetComponent<Collider>().bounds.Intersects(other.bounds)) currentLifePoints--;
  }

  void kill(){
    //Debug.Log ("SCheduling "+name+ " for destroy");
    Destroy(gameObject);
  }
}
