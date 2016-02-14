//2D Shooter 
//Last Modified by Ninghan Huang
//Date last Modified :2.12.2016
// Program description:shoot enemy 
//Revision History:V1.00
//
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class gamectrl : MonoBehaviour
{


    private int _scoreValue;
    private int _livesValue;


    


    
    public int ScoreValue
    {
        get
        {
            return this._scoreValue;
        }

        set
        {
            this._scoreValue = value;
            this.ScoreLabel.text = "Score: " + this._scoreValue;

        }
    }

    public int LivesValue
    {
        get
        {
            return this._livesValue;
        }

        set
        {
            this._livesValue = value;
            if (this._livesValue <= 0)
            {
                
                this._endGame();
            }
            else
            {
                this.LivesLabel.text = "lives: " + this._livesValue;
            }
        }
    }
     




    

    public Text LivesLabel;
    public Text ScoreLabel;
    public Text GameOverLabel;
    public playerScript player;
    public Text HighScoreLabel;
    public Button restart;
    public enemyctrl Rock;
    public enemyctrl health;
    public enemyctrl enemy;
    public enemyctrl enemy1;
    public enemyctrl enemy2;

    // Use this for initialization
    void Start()
    {
        this._initialize();
        this.player.gameObject.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {

    }

   


    private void _initialize()
    {
        this.ScoreValue = 0;
        this.LivesValue = 100;
        
       this.GameOverLabel.gameObject.SetActive(false);
        this.HighScoreLabel.gameObject.SetActive(false);
        this.restart.gameObject.SetActive(false);

    }


    private void _endGame()
    {
        this.GameOverLabel.gameObject.SetActive(true);
        this.player.gameObject.SetActive(false);
        this.Rock.gameObject.SetActive(false);
        this.health.gameObject.SetActive(false);
        this.enemy.gameObject.SetActive(false);
        this.enemy1.gameObject.SetActive(false);
        this.enemy2.gameObject.SetActive(false);
        this.LivesLabel.gameObject.SetActive(false);
        this.ScoreLabel.gameObject.SetActive(false);
        this.HighScoreLabel.gameObject.SetActive(true);
        this.HighScoreLabel.text = "High Score: " + this._scoreValue;
        this.restart.gameObject.SetActive(true);
          
    }
      public void restartbuttom()
    {
        Application.LoadLevel("main");
    }
    
}










