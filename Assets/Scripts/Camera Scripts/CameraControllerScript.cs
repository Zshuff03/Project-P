using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControllerScript : MonoBehaviour {
  Vector3 up = new Vector3(0,0,3);
  Vector3 down = new Vector3(0,0,-3);
  Vector3 left = new Vector3(-3,0,0);
  Vector3 right = new Vector3(3,0,0);
  bool scrollUp = false;
  bool scrollDown = false;
  bool scrollLeft = false;
  bool scrollRight = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
    if (Input.GetKey ("up") || scrollUp)   transform.Translate (up);
    if (Input.GetKey ("down") || scrollDown)   transform.Translate (down);
    if (Input.GetKey ("left") || scrollLeft)   transform.Translate (left);
    if (Input.GetKey ("right") || scrollRight)   transform.Translate (right);
	}
  public void toggleUp () { scrollUp = !scrollUp; } 
  public void toggleDown () { scrollDown = !scrollDown; } 
  public void toggleLeft () { scrollLeft = !scrollLeft; } 
  public void toggleRight () { scrollRight = !scrollRight; } 
}
