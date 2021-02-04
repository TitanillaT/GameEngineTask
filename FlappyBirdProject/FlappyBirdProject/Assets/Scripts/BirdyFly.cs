using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
[RequireComponent(typeof(AudioSource))]
public class BirdyFly : MonoBehaviour
{
    //player's points, +1 points 
    [SerializeField]
    private int points = 0;

    [SerializeField]
    private GameObject _shooter;

    [SerializeField]
    private float _fireRate = 0.5f;
    private float _canFire = -1f;

    [SerializeField]
    private GameObject _PausedText;

    // Movement speed
    float speed = 2;

    // Jump 
    float force = 350;

    private static int topPoints;

    private bool isPaused = false;

    AudioSource audioData;

    // Start is called before the first frame update
    void Start()
    {
        _PausedText.SetActive(false);
        Time.timeScale = 0;
      // gets player started
        // GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        audioData = GetComponent<AudioSource>();
      
    }

    // Update jump for every frame
    void Update()
    {
        // start game
        if (Input.GetKeyDown(KeyCode.Space) && isPaused == false) {
            _PausedText.SetActive(false);
            Time.timeScale = 1;
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * force);
        }

         // resume game after pause
        if (Input.GetKeyDown(KeyCode.Space) && isPaused == true ) {
            _PausedText.SetActive(false);
            isPaused = false;
            Time.timeScale = 1;
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * 50);
        }

        // pause game
        if (Input.GetKeyDown(KeyCode.LeftShift)) {
            _PausedText.SetActive(true);
            isPaused = true;
            Time.timeScale = 0;
        }

        // if (Input.GetKeyDown(KeyCode.M)) {
        //     SceneManager.LoadScene("Menu");
        // }

        if(Input.GetKeyDown(KeyCode.Tab) && Time.time > _canFire)
        {
            FireLaser();
        }
    }
    public void IncreaseScore()
    {
    Text showPoints = GameObject.Find("Canvas/Points").GetComponent<Text>();
    

      points += 1;
      // showPoints.text = "" + points + "Pts";
      showPoints.text = "" + points;

      if(points > topPoints) {
          topPoints = points;
      }
      Debug.Log("Player got 1 points! Total : " + points + "; High Score : " + topPoints );

    }
    public static int HighScore() 
    {   
        return topPoints;
    }

    void FireLaser()
    {
        //Debug.Log("Space was pressed");
        //every 0.5 of a second it will allow us to fire
        _canFire = Time.time + _fireRate;

            // Position of player (0,0,0) + (0,1,0) = final position of the laser (0,1,0)
        Instantiate(_shooter,transform.position + new Vector3(1f,0,0), Quaternion.identity);
        audioData.Play(0);


    }





}
