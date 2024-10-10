using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class mainScript : MonoBehaviour {

    public int currentSavedNumber;

    string buttonName;
    public AudioSource ClickSound;

    // Start is called before the first frame update
    void Start () {
        
        loadData ();
        savelevel ();

    }

    // Update is called once per frame
    void Update () {

    }

    public void loadnextscene () {
        SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
    }

    public void play () {
        SceneManager.LoadScene ("play");
    }

    public void exitscene () {
        SceneManager.LoadScene ("exit");
    }

    public void levels () {
        SceneManager.LoadScene ("levels");
    }

    public void loadButtonsLevel () {
        buttonName = EventSystem.current.currentSelectedGameObject.name;
        SceneManager.LoadScene ("level" + buttonName);
    }

    public void playClickSound () {
        ClickSound.Play ();
    }

  //  public void savelevel () {
  //      int y = SceneManager.GetActiveScene ().buildIndex;
  //      int curruntLevelNumber = y - 2;
//
  //      if (curruntLevelNumber > currentSavedNumber) {
  //          currentSavedNumber = curruntLevelNumber;
  //          print (currentSavedNumber);
  //          PlayerPrefs.SetInt ("savedlevel", currentSavedNumber);
  //      }
  //  }

    public void saveData () {
        deleteData ();
        PlayerPrefs.SetInt ("savedlevel", 1);

    }
    public void deleteData () {
        PlayerPrefs.DeleteKey ("savedlevel");

    }
    public void loadData () {
        currentSavedNumber = PlayerPrefs.GetInt ("savedlevel");

    }

}