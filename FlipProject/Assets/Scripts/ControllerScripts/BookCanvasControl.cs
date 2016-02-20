using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System;

public class BookCanvasControl : MonoBehaviour {
	//public static BookCanvasControl control;
	GameObject copyBook;
	List<GameObject> books;
	List<string> booksText;
	List<Vector3> positions;
	Text searchBarText;
	Transform bone;
	Image paw1;
	Image paw2;
	Image paw3;
	Image paw4;
	Image paw5;


	Text childName;
	Text gradeLevel;
	Text category;
	float time;

	void Awake(){
		//control = this;
		//Input.eatKeyPressOnTextFieldFocus = false;
		//transform.FindChild("SearchBar").GetComponent<Sea
	}
	void Start () {
		copyBook = transform.FindChild ("Book").gameObject;
		searchBarText = transform.FindChild ("SearchBar").FindChild ("Text").GetComponent<Text> ();
		books = new List<GameObject> ();
		positions = new List<Vector3> ();
		booksText = new List<string> ();
		childName = transform.FindChild ("Child Name").GetComponent<Text> ();
		gradeLevel = transform.FindChild ("GradeLevel").GetComponent<Text> ();
		category = transform.FindChild ("Category").GetComponent<Text> ();
		childName.text = MasterControlScript.control.childName;
		gradeLevel.text = MasterControlScript.control.level;
		category.text = MasterControlScript.control.category;

		int count = 0;
		//GameObject tmp;
		for (int k = 150; k >= -200; k -= 240)
			for (int i = -700; i <= 700; i += 200){
				positions.Add (new Vector3 (i, k, -1));
				/*GameObject tmp = Instantiate (copyBook);
				//tmp.transform.SetParent (transform);
				//tmp.transform.localPosition = new Vector3 (i, k, -1);
				SpriteRenderer sp = tmp.GetComponent<SpriteRenderer> ();
				if(count%4==0)
					tmp.transform.FindChild ("Name").GetComponent<Text> ().text= "Bean Thirteen";
				if(count%4==1)
					tmp.transform.FindChild ("Name").GetComponent<Text> ().text= "BookName";
				if(count%4==2)
					tmp.transform.FindChild ("Name").GetComponent<Text> ().text= "Aunt Flossie's Hats";
				if(count%4==3)
					tmp.transform.FindChild ("Name").GetComponent<Text> ().text= "Velma Gratch";
				booksText.Add (tmp.transform.FindChild("Name").GetComponent<Text> ().text);
				Sprite spr = Resources.Load<Sprite> ("Sprites/" + booksText [booksText.Count - 1]);
				if (spr == null)
					spr = Resources.Load<Sprite> ("Sprites/bookImage");
				sp.sprite = spr;
				books.Add (tmp);
				count++;*/
			}
		GameObject tmp;
		Text tmpText;
		Sprite tmpSprite;
		SpriteRenderer tmpSR;
		for (int i = 0; i <MasterControlScript.control.listOfBooks.Count; i++) {
			tmp = Instantiate (copyBook);
			//tmp.transform.SetParent (transform);
			tmpText = tmp.transform.FindChild ("Name").GetComponent<Text> ();
			tmpSR = tmp.GetComponent<SpriteRenderer> ();
			tmpText.text = MasterControlScript.control.listOfBooks [i].name;
			tmp.transform.FindChild ("id").GetComponent<Text> ().text = ""+MasterControlScript.control.listOfBooks [i].id;
			//Debug.Log ("|" + tmpText.text + "|");
			tmpSprite = Resources.Load<Sprite> ("Sprites/" + tmpText.text);
			if(tmpSprite==null)
				tmpSprite = Resources.Load<Sprite> ("Sprites/bookImage");
			tmpSR.sprite = tmpSprite;
			books.Add (tmp);
			booksText.Add (tmpText.text);
		}
		//for the paw prints
		paw1 = transform.FindChild ("paw1").GetComponent<Image>();
		paw2 = transform.FindChild ("paw2").GetComponent<Image>();
		paw3 = transform.FindChild ("paw3").GetComponent<Image>();
		paw4 = transform.FindChild ("paw4").GetComponent<Image>();
		paw5 = transform.FindChild ("paw5").GetComponent<Image>();
		bone = transform.FindChild ("BoneBack").GetComponent<Transform>();
		time = 0;
		paw1.gameObject.SetActive(false);
		paw2.gameObject.SetActive(false);
		paw3.gameObject.SetActive(false);
		paw4.gameObject.SetActive(false);
		paw5.gameObject.SetActive(false);


	}
	
	// Update is called once per frame
	void Update () {
		int pos = 0;
		for (int i = 0; i < Math.Min(books.Count,positions.Count); i++) {
			books [i].SetActive (booksText [i].ToLower().Contains (searchBarText.text.ToLower()));
			if (books [i].activeSelf == true) {
				books [i].transform.localPosition = positions [pos++];
			}
		}

		//for the paw prints
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
