using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TitleControl : MonoBehaviour {

	//Image background;


	public static TitleControl control;
	void Awake(){
		control = this;
		//background = transform.FindChild("TitleBackground").GetComponent<Image>().

	}
}
