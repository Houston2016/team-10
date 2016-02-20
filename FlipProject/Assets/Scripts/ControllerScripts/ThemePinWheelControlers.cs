using UnityEngine;
using System.Collections;

public class ThemePinWheelControlers : MonoBehaviour {
    public Transform pinwheel;
    public float time, speed;
    public float totalTime;
    public float friction;
	Transform bone;

   // public Random random;

   // public static ThemePinWheelControlers control;

	// Use this for initialization
	void Start () {
        //random = new Random();
        pinwheel=transform.FindChild("SpinWheel").GetComponent<Transform>();
        time = 0;
        speed = 0;
        totalTime = 0;
		bone = transform.FindChild ("BoneBack").GetComponent<Transform>();
        friction = Random.Range(10, 15);

	}
	
	// Update is called once per frame
	void Update () {
        if(speed > 0)
        {
            pinwheel.Rotate(new Vector3(0, 0, speed * Time.deltaTime));
            if(totalTime > 3)
            {
                speed -= (10*friction) * Time.deltaTime;
            } else if(totalTime > 5)
            {
                speed -= (30*friction) * Time.deltaTime;
            } else
            {
                speed -= (friction) * Time.deltaTime;
            }
            
            totalTime += Time.deltaTime;        // DEBUGGING
            Debug.Log(totalTime);               // DEBUGGING
  
        }
		time += Time.deltaTime;

		if (time%1 <= .5)
			bone.localScale-=new Vector3(.1f,.1f,0)*Time.deltaTime;

		if (time%1 >= .5)
			bone.localScale+=new Vector3(.1f,.1f,0)*Time.deltaTime;
	}

    public void spin()
    {
        if(speed <= 0)
        {
            totalTime = 0;
            speed = 1000;
            friction = Random.Range(8, 15);
        }
        
    }
}
