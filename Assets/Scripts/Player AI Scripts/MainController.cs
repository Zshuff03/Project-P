using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : MonoBehaviour {
  //publics
  public GameObject gameManager;

  //privates
  string currentAction;
  MoveToScript moveToScript;
  public GameManagerScript gmScript;
  public GameObject[] targets;

	void Start () {
    // Get needed scripts
    gmScript = gameManager.GetComponent<GameManagerScript> ();
    moveToScript = gameObject.GetComponent<MoveToScript>();

    // Initialize dummy data this should come in from a different source in the future
    List<string> gambits = new List<string>();
    gambits.Add("gather");
    currentAction = gambits [0];

    determineAction ();
	}
	
	// Update is called once per frame
	void Update () {
	}
  void determineAction() {
    switch (currentAction) {

    case "gather":
      targets = GameObject.FindGameObjectsWithTag("Resource");
      if(targets != null) moveToScript.setDestination(targets[0]);
      break;

    default:
      break;
    }
  }
}
