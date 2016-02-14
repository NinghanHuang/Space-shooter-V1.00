//2D Shooter 
//Last Modified by Ninghan Huang
//Date last Modified :2.12.2016
// Program description:shoot enemy 
//Revision History:V1.00
//
using UnityEngine;
using System.Collections;

public class backGround : MonoBehaviour {
    public float speed = 0;
    private Transform _transform;
    private Vector2 _currectPosition;
	// Use this for initialization
	void Start () {
        this._transform = gameObject.GetComponent<Transform>();
        this.Reset();

	}
	
	// Update is called once per frame
	void Update () {
        this._currectPosition = this._transform.position;
        this._currectPosition -= new Vector2(0, this.speed);
        this._transform.position = this._currectPosition;
        if(_currectPosition.y<=-310)
        {
            Reset();
        }
	}
    public void Reset()
    {
        this._transform.position = new Vector2(0, 340);
    }
}
