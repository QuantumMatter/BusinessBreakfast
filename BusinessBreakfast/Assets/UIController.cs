using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class UIController : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //NextClicked();
        Debug.Log(SceneManager.GetActiveScene().buildIndex);
        if(SceneManager.GetActiveScene().buildIndex == 0){

        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void NextClicked() {
        Debug.Log("Next button was pressed");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void PreviousClicked()
    {
        Debug.Log("Next button was pressed");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    /*public void HomeClicked()
    {
        Debug.Log("Next button was pressed");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }*/


}
