using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class playerContraller : MonoBehaviour {
    public AudioSource backgroundMusic;
    public bool backplay = true;
    public GameObject object1, object2;
    public Text distancetext, LevelText;
    public float distance;
    float direction;
    private Rigidbody2D rb;
    public float speed = 500;
    public float dirspeed = 280;

    private bool touchStart = false;
    private Vector2 pointB;
    private Vector2 pointa;
    private speedmanager speedmanager;
    private panelManeger panelManeger;

    float startTime , endTime , mintime  = 0.05f, mindist  = 0.05f , movedTime , movedDist ;
    Vector2 startpos, endpos;
    private void Awake () {
        speedmanager = FindObjectOfType<speedmanager> ();
        panelManeger = FindObjectOfType<panelManeger> ();
        //        LevelText = GameObject.Find ("LEVEL").GetComponent<Text> ();
    }

    void Start () {
        backgroundMusic.Pause ();
        int y = SceneManager.GetActiveScene ().buildIndex;
        int x = y - 2;
        LevelText.text = "Level - " + x.ToString ("00");
       
          
       
        rb = GetComponent<Rigidbody2D> ();
        speed = speedmanager.setSpeed;
        dirspeed = speedmanager.setUpDownSpeed;
      

    }

    // Update is called once per frame
    void Update () {


        if(Input.touchCount > 0)
            {
            Touch touch = Input.GetTouch(0);

            if(touch.phase == TouchPhase.Began)
                {
                startTime = Time.time;
                startpos = touch.position;
                }
            else if(touch.phase == TouchPhase.Ended)
                {
                endTime = Time.time;
                endpos = touch.position;
                }
            calculateMove ( );
        }



        
        calculateDistance ();
        if (Input.GetMouseButtonDown (0)) {
            pointa = Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, Camera.main.transform.position.z));
           // print (pointa);

        }
        if (Input.GetMouseButton (0)) {

            
            touchStart = true;
            if (backplay == true) {
                backplay = false;
                backgroundMusic.Play ();
            }
            pointB = Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, Camera.main.transform.position.z));
            

            
        } else {
            // touchStart = false;
        }
    }

    void FixedUpdate () {
        if (touchStart) {
            // print(direction);
            rb.velocity = new Vector2 (speed * Time.deltaTime, direction * dirspeed * Time.deltaTime);

        }

    }

    public void calculateDistance () {
        distance = Vector3.Distance (object1.transform.position, object2.transform.position);

        distancetext.text = "Distance : " + distance.ToString ("0");

    }
    void OnTriggerEnter2D (Collider2D collider) {
        if (collider.gameObject.tag == "Finish") {
            panelManeger.activeWinpanel ();
        }
    }

  
    void calculateMove ( )
        {

        movedTime = endTime - startTime;
        movedDist = startpos.y - endpos.y;
        if(Mathf.Abs( movedDist) > mindist && movedTime > mintime)
            {
            if(movedDist > 0)
                {

                direction = -1;
                }
            else
                {
                direction =  1;
                }
            }
        }


}