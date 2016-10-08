using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NextTransScript : MonoBehaviour, IGvrGazeResponder {

	// Use this for initialization
	bool isActive;
	float activeTime;
	UIController controller;
	Image selectionProgress;
	public float selectionTime = 2;

	// Use this for initialization
	void Start () {
		isActive = false;
		controller = new UIController ();

		foreach (Image image in gameObject.GetComponentsInChildren<Image>()) {
			Debug.Log ("Found Image");
			selectionProgress = image;
		}
		selectionProgress.fillAmount = 0;
	}

	// Update is called once per frame
	void Update () {
		if (isActive) {
			activeTime += Time.deltaTime;

			selectionProgress.fillAmount = (activeTime / selectionTime);
		}

		if (activeTime >= selectionTime) {
			next ();
		}

		if (!isActive) {
			activeTime = 0;
			selectionProgress.fillAmount = 0;
		}
	}

	public void OnGazeEnter() {
		isActive = true;
	}

	public void OnGazeExit() {
		isActive = false;
	}

	public void OnGazeTrigger() {
		next ();
	}

	public void next() {
		controller.NextClicked ();
	}
}
