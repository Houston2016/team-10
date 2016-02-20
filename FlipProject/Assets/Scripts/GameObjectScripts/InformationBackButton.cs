using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class InformationBackButton : MonoBehaviour {

	// Use this for initialization
	void OnMouseDown(){
		SceneManager.LoadScene ("BookListScene");
	}
}
