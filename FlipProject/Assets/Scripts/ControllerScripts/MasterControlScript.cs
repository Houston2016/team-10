using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using System.IO;

public class MasterControlScript : MonoBehaviour {
	public static MasterControlScript control;

	public List<Book> listOfBooks;

	void Awake(){
		control = this;
	}
	void Start () {
		activeBook = new Book ();
		activeBook.name = "Book Name";
		childName = "Child Name";
		level = "level";
		category = "Category";
		activityTitle = "title";
		Parse ("Assets/Resources/Datafiles/Database.sqldb");
		SceneManager.LoadScene ("TitleScreenScene");
	}
	void Parse(string fileName){
		listOfBooks = new List<Book> ();
		int id = 0;
		StreamReader file = new StreamReader (fileName);
		Debug.Log ("file found");
		string line;
		while ((line = file.ReadLine ())!=null) {
			Book tmp = new Book ();
			file.ReadLine ();
			tmp.name = file.ReadLine ();
			tmp.id = id++;
			line = file.ReadLine ();
			if (line.Equals ("<->")) {
				listOfBooks.Add (tmp);
				continue;
			}
			while (!(line = file.ReadLine ()).StartsWith ("<"))
				tmp.Discuss += line + "\n";
			while (!(line = file.ReadLine ()).StartsWith ("<"))
				tmp.Do += line + "\n";
			while (!(line = file.ReadLine ()).StartsWith ("<"))
				tmp.Learn += line + "\n";
			listOfBooks.Add (tmp);

		}
		/*Debug.Log (listOfBooks.Count);
		for (int i = 0; i < listOfBooks.Count; i++)
			Debug.Log (listOfBooks [i].name);*/
	}

	public Book activeBook;
	public string childName;
	public string category;
	public string level;
	public string activityTitle;





	

}
