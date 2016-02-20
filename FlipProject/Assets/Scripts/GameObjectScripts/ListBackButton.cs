using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ListBackButton : MonoBehaviour {

	void OnMouseDown(){
		SceneManager.LoadScene ("ThemePinWheelScene");
	}
}
