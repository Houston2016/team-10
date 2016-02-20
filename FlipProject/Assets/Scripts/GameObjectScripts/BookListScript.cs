using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BookListScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnMouseDown(){
		int index = int.Parse(transform.FindChild ("id").GetComponent<Text> ().text);
		MasterControlScript.control.activeBook = MasterControlScript.control.listOfBooks [index];
		SceneManager.LoadScene ("InformationButtonsScene");
	}
}
