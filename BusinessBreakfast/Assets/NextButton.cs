﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NextButton : MonoBehaviour, IGvrGazeResponder {

	public Image selectionImage;
	public float selectionTime = 2;

	UIController controller;
	bool isActive = false;
	float activeTime = 0;

	// Use this for initialization
	void Start () {
		controller = new UIController ();

		selectionImage.fillAmount = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (isActive) {
			activeTime += Time.deltaTime;
			selectionImage.fillAmount = (activeTime / selectionTime);
		}

		if(isActive && (activeTime > selectionTime)) {
			OnGazeTrigger ();
		}

		if (!isActive) {
			activeTime = 0;
			selectionImage.fillAmount = 0;
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
