using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exitpanel : MonoBehaviour
{
    public GameObject exitPnel;
     public GameObject normalPanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void activeExitPanel(){

        exitPnel.SetActive(true);
        normalPanel.SetActive(false);
    }

    public void activeNormalPanel(){

        exitPnel.SetActive(false);
        normalPanel.SetActive(true);
    }

    public void exitgame(){
        Application.Quit();
    }

    

}
