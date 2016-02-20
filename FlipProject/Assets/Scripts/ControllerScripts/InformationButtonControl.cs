using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InformationButtonControl : MonoBehaviour {
	Text bookName;
	Transform bone;
	Transform sun;
	Image paw1;
	Image paw2;
	Image paw3;
	Image paw4;
	Image paw5;
	Image paw6;
	Image paw7;
	Image paw8;
	Image paw9;
	Image paw10;
	Image paw11;
	float time;



	// Use this for initialization
	void Start () {
		paw1 = transform.FindChild ("paw1").GetComponent<Image>();
		paw2 = transform.FindChild ("paw2").GetComponent<Image>();
		paw3 = transform.FindChild ("paw3").GetComponent<Image>();
		paw4 = transform.FindChild ("paw4").GetComponent<Image>();
		paw5 = transform.FindChild ("paw5").GetComponent<Image>();
		paw6 = transform.FindChild ("paw6").GetComponent<Image>();
		paw7 = transform.FindChild ("paw7").GetComponent<Image>();
		paw8 = transform.FindChild ("paw8").GetComponent<Image>();
		paw9 = transform.FindChild ("paw9").GetComponent<Image>();
		paw10 = transform.FindChild ("paw10").GetComponent<Image>();
		paw11 = transform.FindChild ("paw11").GetComponent<Image>();
		time = 0;
		paw1.gameObject.SetActive(false);
		paw2.gameObject.SetActive(false);
		paw3.gameObject.SetActive(false);
		paw4.gameObject.SetActive(false);
		paw5.gameObject.SetActive(false);
		paw6.gameObject.SetActive(false);
		paw7.gameObject.SetActive(false);
		paw8.gameObject.SetActive(false);
		paw9.gameObject.SetActive(false);
		paw10.gameObject.SetActive(false);
		paw11.gameObject.SetActive(false);

		bookName = transform.FindChild ("BookNameText").GetComponent<Text> ();
		bone = transform.FindChild ("BoneBack").GetComponent<Transform>();
		sun = transform.FindChild ("Sun").GetComponent<Transform> ();
		bookName.text = MasterControlScript.control.activeBook.name;
	}

	// Update is called once per frame
	public void Update () {
		time += Time.deltaTime;

		//for the sun
		if (time%1 <= .5)
			sun.localScale-=new Vector3(.1f,.1f,0)*Time.deltaTime;

		if (time%1 >= .5)
			sun.localScale+=new Vector3(.1f,.1f,0)*Time.deltaTime;
	
		//for the paws
		if (time >= .5 && time<=6.5)
			paw1.gameObject.SetActive (true);
		if (time >= 1 && time<=6.5)
			paw2.gameObject.SetActive (true);
		if (time >= 1.5 && time<=6.5)
			paw3.gameObject.SetActive (true);
		if (time >= 2 && time<=6.5)
			paw4.gameObject.SetActive (true);
		if (time >= 2.5 && time <= 6.5)
			paw5.gameObject.SetActive (true);
		if (time >= 3 && time <= 6.5)
			paw6.gameObject.SetActive (true);
		if (time >= 3.5 && time <= 6.5)
			paw7.gameObject.SetActive (true);
		if (time >= 4 && time <= 6.5)
			paw8.gameObject.SetActive (true);
		if (time >= 4.5 && time <= 6.5)
			paw9.gameObject.SetActive (true);
		if (time >= 5 && time <= 6.5)
			paw10.gameObject.SetActive (true);
		if (time >= 5.5 && time <= 6.5)
			paw11.gameObject.SetActive (true);


		if (time >= 8) 
			paw1.gameObject.SetActive (false);
		if(time>=9)
			paw2.gameObject.SetActive (false);
		if(time>=10)
			paw3.gameObject.SetActive (false);
		if (time >= 11) 
			paw4.gameObject.SetActive (false);
		if (time >= 12) 
			paw5.gameObject.SetActive (false);
		if (time >= 13) 
			paw6.gameObject.SetActive (false);
		if (time >= 14) 
			paw7.gameObject.SetActive (false);
		if (time >= 15) 
			paw8.gameObject.SetActive (false);
		if (time >= 16) 
			paw9.gameObject.SetActive (false);
		if (time >= 17) 
			paw10.gameObject.SetActive (false);
		if (time >= 18) 
			paw11.gameObject.SetActive (false);


		if (time%1 <= .5)
			bone.localScale-=new Vector3(.1f,.1f,0)*Time.deltaTime;

		if (time%1 >= .5)
			bone.localScale+=new Vector3(.1f,.1f,0)*Time.deltaTime;


		if(time >=20)
			time = 0;

	}




	public void Explore(){
		MasterControlScript.control.activityTitle = "Explore the book Together";
		SceneManager.LoadScene ("ActivityScene");
	}
	public void Do(){
		MasterControlScript.control.activityTitle = "Have fun with the Activity Together";
		SceneManager.LoadScene ("ActivityScene");
	}
	public void Learn(){
		MasterControlScript.control.activityTitle = "Learn more Together";
		SceneManager.LoadScene ("ActivityScene");
	}


}
