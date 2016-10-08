using UnityEngine;
using System.Collections;

public class PrevTransScript : MonoBehaviour, IGvrGazeResponder {

	bool isActive;
	float activeTime;
	UIController controller;

	// Use this for initialization
	void Start () {
		isActive = false;
		controller = new UIController ();
	}
	
	// Update is called once per frame
	void Update () {
		if (isActive) {
			activeTime += Time.deltaTime;
		}

		if (activeTime >= 3) {
			previous ();
		}

		if (!isActive) {
			activeTime = 0;
		}
	}

	public void OnGazeEnter() {
		isActive = true;
		Debug.Log ("PrevTransScript: OnGazeEnter");
		GameObject sphere = GameObject.CreatePrimitive (PrimitiveType.Sphere);
		sphere.transform.position = new Vector3 (2, 0, 2);
	}

	public void OnGazeExit() {
		isActive = false;
		Debug.Log ("PrevTransScript: OnGazeExit");
	}

	public void OnGazeTrigger() {
		Debug.Log ("PrevTransScript: OnGazeTrigger");
		previous ();
	}

	public void previous() {
		controller.PreviousClicked ();
	}

	public void test() {

	}
}
