using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ActivityBackButton : MonoBehaviour {

	// Use this for initialization
	void OnMouseDown(){
		SceneManager.LoadScene ("InformationButtonsScene");
	}
}
