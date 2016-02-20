using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleControl : MonoBehaviour {

	//Image background;
	Image paw1;
	Image paw2;
	Image paw3;
	Image paw4;
	Image paw5;

	Transform bone;

	public static TitleControl control;
	float time;
	void Awake(){
		control = this;
		//background = transform.FindChild("TitleBackground").GetComponent<Image>().

	}

	void Start(){
		paw1 = transform.FindChild("TitleBackground").FindChild ("paw1").GetComponent<Image>();
		paw2 = transform.FindChild("TitleBackground").FindChild ("paw2").GetComponent<Image>();
		paw3 = transform.FindChild("TitleBackground").FindChild ("paw3").GetComponent<Image>();
		paw4 = transform.FindChild("TitleBackground").FindChild ("paw4").GetComponent<Image>();
		paw5 = transform.FindChild("TitleBackground").FindChild ("paw5").GetComponent<Image>();
		bone = transform.FindChild("TitleBackground").FindChild ("PlayButton").GetComponent<Transform>();
		time = 0;
		paw1.gameObject.SetActive(false);
		paw2.gameObject.SetActive(false);
		paw3.gameObject.SetActive(false);
		paw4.gameObject.SetActive(false);
		paw5.gameObject.SetActive(false);
		//SceneManager.LoadScene ("BookListScene");


	}
	void Update(){
		time += Time.deltaTime;
		if (time >= .5 && time<=2.5)
			paw1.gameObject.SetActive (true);
		if (time >= 1 && time<=2.5)
			paw2.gameObject.SetActive (true);
		if (time >= 1.5 && time<=2.5)
			paw3.gameObject.SetActive (true);
		if (time >= 2 && time<=2.5)
			paw4.gameObject.SetActive (true);
		if (time >= 2.5 && time <= 3)
			paw5.gameObject.SetActive (true);


		if (time >= 4) 
			paw1.gameObject.SetActive (false);
		if(time>=5)
			paw2.gameObject.SetActive (false);
		if(time>=6)
			paw3.gameObject.SetActive (false);
		if (time >= 7) 
			paw4.gameObject.SetActive (false);
		if (time >= 8) 
			paw5.gameObject.SetActive (false);
		if (time%1 <= .5)
			bone.localScale-=new Vector3(.1f,.1f,0)*Time.deltaTime;
		
		if (time%1 >= .5)
			bone.localScale+=new Vector3(.1f,.1f,0)*Time.deltaTime;
		

			if(time >=9)
				time = 0;
	}
}
