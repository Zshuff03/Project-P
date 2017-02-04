using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToScript : MonoBehaviour {
  public UnityEngine.AI.NavMeshAgent agent;
  // Use this for initialization;
	void Start () {
	}

  public void setDestination (GameObject target) {
    agent.destination = target.transform.position;
  }
}
