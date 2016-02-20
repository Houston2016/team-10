using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MasterControl : MonoBehaviour {

	public static MasterControl control;
	void Awake () {
		control = this;
		DontDestroyOnLoad (control);
		LoadScene ("TitleScene");
	}
	public void LoadScene(string s){
		SceneManager.LoadScene (s);
	}

}
