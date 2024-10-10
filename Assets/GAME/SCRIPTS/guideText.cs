using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class guideText : MonoBehaviour {
    public Text GuideText;
    private playerContraller cont;
    float dist;
    // Start is called before the first frame update
    void Start () {
        cont = FindObjectOfType<playerContraller> ();

    }

    // Update is called once per frame
    void Update () {
        displayguides ();

    }

    private void displayguides () {
        if (cont.distance > 390f && cont.distance < 470f) {
            GuideText.text = "Swipe the screen to control the ball";
        } else if (cont.distance > 267f && cont.distance < 330f) {
            GuideText.text = "avoid the red balls to win..!";
        } else {
            GuideText.text = "";
        }
    }
}