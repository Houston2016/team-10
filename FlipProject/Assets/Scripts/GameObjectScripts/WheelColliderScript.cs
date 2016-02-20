using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WheelColliderScript : MonoBehaviour {
    public string theme;

    void Start()
    {
        theme = transform.GetComponent<Text>().text;
    }

	void OnMouseDown()
    {
		MasterControlScript.control.category = theme;
		SceneManager.LoadScene ("BookListScene");

    }

    
}
