using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayButtonScript : MonoBehaviour {
	Text childname;
	Text level;
	// Use this for initialization
	void Start () {
		childname = transform.parent.transform.FindChild ("ChildName").FindChild ("Text").GetComponent<Text> ();
		level = transform.parent.transform.FindChild ("GradeLevel").FindChild ("Text").GetComponent<Text> ();
		//Debug.Log ("abc");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnMouseDown(){
		MasterControlScript.control.childName = childname.text;
		MasterControlScript.control.level = level.text;
		SceneManager.LoadScene ("ThemePinWheelScene");
	}
}
