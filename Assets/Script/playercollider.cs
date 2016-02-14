//2D Shooter 
//Last Modified by Ninghan Huang
//Date last Modified :2.12.2016
// Program description:shoot enemy 
//Revision History:V1.00
//
using UnityEngine;
using System.Collections;

public class playercollider : MonoBehaviour {
    private AudioSource[] Sound;
    private AudioSource enemy;
    private AudioSource Rock;
    private AudioSource health;
    private AudioSource hurt;
    private AudioSource laser;
    public gamectrl gameController;
    // Use this for initialization
    void Start () {
        
        this.Sound = gameObject.GetComponents<AudioSource>();
        this.enemy = this.Sound[2];
        this.Rock = this.Sound[1];
        this.health = this.Sound[3];
    }
	
	// Update is called once per frame
	void Update () {
	
	}
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("enemy"))
        {
            this.enemy.Play();
            Debug.Log("enemy collider");
            
            this.gameController.LivesValue -= 10;
            enemyctrl c = other.GetComponent<enemyctrl>();
            c.Reset();

        }
        if (other.CompareTag("health"))
        {
            this.health.Play();
            Debug.Log("health collider");
            this.gameController.LivesValue += 10;
            enemyctrl c = other.GetComponent<enemyctrl>();
            c.Reset();
        }
        if (other.CompareTag("Rock"))
        {
            this.Rock.Play();
            Debug.Log("Rock collider");
            this.gameController.ScoreValue += 20;
            enemyctrl c = other.GetComponent<enemyctrl>();
            c.Reset();
        }

    }

}
