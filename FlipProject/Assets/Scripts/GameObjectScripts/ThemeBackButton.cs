using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ThemeBackButton : MonoBehaviour {


	void OnMouseDown(){
		SceneManager.LoadScene ("TitleScreenScene");
	}
}
