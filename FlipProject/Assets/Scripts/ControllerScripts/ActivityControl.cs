using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ActivityControl : MonoBehaviour {
	Text title;
	Text body;
	Transform bone;
	float time;

	void Start () {
		time = 0;
		title = transform.FindChild ("TitleText").GetComponent<Text> ();
		body = transform.FindChild ("Paragraph").GetComponent<Text> ();
		bone = transform.FindChild ("BoneBack").GetComponent<Transform>();
		title.text = MasterControlScript.control.activityTitle;
		if(title.text.Equals("Explore the book Together"))
			body.text = MasterControlScript.control.activeBook.Discuss;
		if(title.text.Equals("Have fun with the Activity Together"))
			body.text = MasterControlScript.control.activeBook.Do;
		if(title.text.Equals("Learn more Together"))
			body.text = MasterControlScript.control.activeBook.Learn;
		

	}
	
	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;

		if (time%1 <= .5)
			bone.localScale-=new Vector3(.1f,.1f,0)*Time.deltaTime;

		if (time%1 >= .5)
			bone.localScale+=new Vector3(.1f,.1f,0)*Time.deltaTime;
	}
}
