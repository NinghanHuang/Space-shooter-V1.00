//2D Shooter 
//Last Modified by Ninghan Huang
//Date last Modified :2.12.2016
// Program description:shoot enemy 
//Revision History:V1.00
//
using UnityEngine;
using System.Collections;

public class Lazerctrl : MonoBehaviour
{
    public float speed = 20;
    private AudioSource[] Sound;
    private Transform _transform;
    private Vector2 currectPosition;
    private Vector2 newPosition;



    private AudioSource enemy;
    private AudioSource Rock;
    private AudioSource health;
    private AudioSource hurt;
    private AudioSource laser;
    // Use this for initialization
    void Start()
    {
        this._transform = gameObject.GetComponent<Transform>();
        this.enemy = this.Sound[1];
        this.Rock = this.Sound[2];
      
        this.laser = this.Sound[3];
    }

    // Update is called once per frame
    void Update()
    {
        this.currectPosition = this._transform.position;
        if (Input.GetKey(KeyCode.Backspace))
        {
            this.laser.Play();
            this.newPosition = this._transform.position;
            this.newPosition -= new Vector2(0, this.speed);
            this._transform.position = this.newPosition;



        }
    }




    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("enemy"))
        {
            this.enemy.Play();
            Debug.Log("enemy collider");
        }
        if (other.CompareTag("health"))
        {
           
            Debug.Log("health collider");
        }
        if (other.CompareTag("Rock"))
        {
            this.Rock.Play();
            Debug.Log("Rock collider");
        }

    }
    public void Reset()
    {
        this._transform.position = this.currectPosition;
    }
}
