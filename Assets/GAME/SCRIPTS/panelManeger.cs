using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class panelManeger : MonoBehaviour {
    playerContraller player;
    public GameObject pausePanel, gameOverPanel, settingsPanel, gamePanel, game, winpanel;
    // Start is called before the first frame update
    void Start () {
        player = FindObjectOfType<playerContraller> ();
        allpanelsarefalse ();
        gamePanel.SetActive (true);
        game.SetActive (true);
        ContinueGame ();

    }

    // Update is called once per frame
    void Update () {

    }

    public void PauseGame () {
        player.backgroundMusic.Pause ();
        Time.timeScale = 0;
        allpanelsarefalse ();
        pausePanel.SetActive (true);
    }
    public void ContinueGame () {
        if (player.backplay == false) {
            player.backgroundMusic.Play ();
        }
        Time.timeScale = 1;
        allpanelsarefalse ();
        gamePanel.SetActive (true);
        game.SetActive (true);
        //enable the scripts again
    }

    public void restartgame () {
        player.backgroundMusic.Pause ();
        ContinueGame ();
        SceneManager.LoadSceneAsync (SceneManager.GetActiveScene ().buildIndex);
    }

    public void activeSettingspanel () {

        allpanelsarefalse ();
        settingsPanel.SetActive (true);

        //enable the scripts again
    }

    public void activeGameOverpanel () {
        player.backgroundMusic.Pause ();
        allpanelsarefalse ();
        gameOverPanel.SetActive (true);
        //enable the scripts again
    }
    public void activeWinpanel () {
        player.backgroundMusic.Pause ();
        allpanelsarefalse ();
        winpanel.SetActive (true);
        //enable the scripts again
    }

    private void allpanelsarefalse () {
        pausePanel.SetActive (false);
        gamePanel.SetActive (false);
        gameOverPanel.SetActive (false);
        settingsPanel.SetActive (false);
        game.SetActive (false);
        winpanel.SetActive (false);

    }

}