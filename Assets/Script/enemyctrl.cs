//2D Shooter 
//Last Modified by Ninghan Huang
//Date last Modified :2.12.2016
// Program description:shoot enemy 
//Revision History:V1.00
//
using UnityEngine;
using System.Collections;

public class enemyctrl : MonoBehaviour {
    
    private float xspeed = 0;
    private float ySpeed = 0;
    private float speed = 3f;
    private float minX = -3f;
    private float maxX = 3f;
    private float maxy = 3f;
    private float miny = 1f;

    private Transform _transform;
    private Vector3 _horizenPosition;
    private Vector3 _verticalPosition;
    // Use this for initialization
    void Start () {
        this._transform = gameObject.GetComponent<Transform>();
        this.Reset();
    }

    // Update is called once per frame
    void Update()
    {
        

        this._horizenPosition = this._transform.position;
        this._horizenPosition -= new Vector3(this.xspeed, this.ySpeed, 0);
        this._transform.position = this._horizenPosition;
        if (_horizenPosition.y <= -170 || _verticalPosition.x<=-270f || _verticalPosition.x>= 280f)
        {
            Reset();
        }
    }
    public void Reset()
{
        xspeed = Random.Range(minX, maxX);

               ySpeed = Random.Range(miny, maxy);
        this._transform.position = new Vector3(Random.Range(-260f, 260f), 200f, 0);
        
    }
}
