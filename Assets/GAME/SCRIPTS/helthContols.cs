using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class helthContols : MonoBehaviour {

    public AudioSource damage;
    public GameObject[] lifes;
    public panelManeger plar;
    int maxLifCount = 6;
    int curLifeCount;
    // Start is called before the first frame update
    void Start () {
        plar = FindObjectOfType<panelManeger> ();

        curLifeCount = maxLifCount;
        for (var i = 0; i < curLifeCount; i++) {
            lifes[i].SetActive (true);
        }
    }

    // Update is called once per frame
    void Update () {
        if (curLifeCount <= 0) {

            plar.activeGameOverpanel ();
        }

    }

    void OnTriggerEnter2D (Collider2D collider) {
        if (collider.gameObject.tag == "enemy") {
            damage.Play ();
            curLifeCount = curLifeCount - 1;
            for (var i = 0; i < maxLifCount; i++) {
                lifes[i].SetActive (false);
            }
            for (var i = 0; i < curLifeCount; i++) {
                lifes[i].SetActive (true);
            }

        }

    }

}