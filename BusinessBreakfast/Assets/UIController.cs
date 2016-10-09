using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class UIController : MonoBehaviour {

	//int currentIndex = 1;
	int totalScenes = 1;

	// Use this for initialization
	void Start () {
		totalScenes = SceneManager.sceneCount;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void NextClicked() {
		/*currentIndex++;
		if (currentIndex > totalScenes) {
			currentIndex = 1;
		}

        Debug.Log("Next button was pressed");
		SceneManager.LoadScene(currentIndex); */

		Debug.Log("Next button was pressed");
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void PreviousClicked() {
		/*currentIndex--;
		if (currentIndex < 1) {
			currentIndex = totalScenes;
		}

        Debug.Log("Previous button was pressed");
		SceneManager.LoadScene(currentIndex); */

		Debug.Log("Previous button was pressed");
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);


    }

    public void HomeClicked()
    {
        SceneManager.LoadScene(0);
    }


}
