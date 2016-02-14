//2D Shooter 
//Last Modified by Ninghan Huang
//Date last Modified :2.12.2016
// Program description:shoot enemy 
//Revision History:V1.00
//
using UnityEngine;
using System.Collections;

public class playerScript : MonoBehaviour {
    public float speed = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


       Vector3 origin =  Camera.main.ViewportToWorldPoint(Vector3.zero);

        Vector3 end = Camera.main.ViewportToWorldPoint(Vector3.one);
        float bottom = origin.y;
        float top = end.y;
        float left = origin.x;
        float right = end.x;

        Vector3 pos = gameObject.transform.position;

        if (Input.GetKey(KeyCode.A) 
            && (pos.x - speed)>left + gameObject.GetComponent<SpriteRenderer>().bounds.size.x/2
          )
        {
            Vector3 newPostion = gameObject.transform.position;
            

            gameObject.transform.Translate(-speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.D)&& (pos.x + speed) < right - gameObject.GetComponent<SpriteRenderer>().bounds.size.x / 2)
        {
            Vector3 newPostion = gameObject.transform.position;
            

            gameObject.transform.Translate(speed,0,0);
        }
        if (Input.GetKey(KeyCode.W)&& (pos.y + speed) < top - gameObject.GetComponent<SpriteRenderer>().bounds.size.y / 2)
        {
            Vector3 newPostion = gameObject.transform.position;


            gameObject.transform.Translate(0, speed, 0);
            
        }
        if (Input.GetKey(KeyCode.S)&& (pos.y - speed) > bottom + gameObject.GetComponent<SpriteRenderer>().bounds.size.y / 2)
        {
            Vector3 newPostion = gameObject.transform.position;


            gameObject.transform.Translate(0, -speed, 0);
            
        }



       
    }
}
