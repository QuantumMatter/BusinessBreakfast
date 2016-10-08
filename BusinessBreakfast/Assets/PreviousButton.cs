using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PreviousButton : MonoBehaviour, IGvrGazeResponder {

	public Image selectionImage;
	public float selectionTime = 2;

	UIController controller;
	bool isActive;
	float activeTime = 0;
	//Image selectionImage;

	void Start () {
		controller = new UIController ();
		/*GameObject test = new GameObject ();
		selectionImage = test.AddComponent<Image> ();
		selectionImage.transform.position = new Vector3 (0, 0, 0);
		selectionImage.sprite = selectionSprite;
		selectionImage.fillMethod = Image.FillMethod.Radial360;*/
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
		previous ();
	}

	public void previous() {
		controller.PreviousClicked ();
	}
}
