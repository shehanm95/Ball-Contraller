using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class speedmanager : MonoBehaviour {
    public float setSpeed;
    public float setUpDownSpeed;
    Slider setSpeedSlider;
    Slider setUpDownSpeedSlider;
    public Text setSpeedText;
    public Text setUpDownSpeedText;

    private void Awake () {
        setSpeedSlider = GameObject.Find ("SpeedSLIDER").GetComponent<Slider> ();
        setUpDownSpeedSlider = GameObject.Find ("updownspeedSLIDER").GetComponent<Slider> ();
        setSpeed = PlayerPrefs.GetFloat ("speedseted");
        setUpDownSpeed = PlayerPrefs.GetFloat ("UpDownSpeedseted");
    }

    // Start is called before the first frame update
    void Start () {

        if(setSpeed == 0){
            setSpeed = 500;
            setUpDownSpeed = 280;
        }
        setSpeedSlider.value = setSpeed;
        setUpDownSpeedSlider.value = setUpDownSpeed;
    }

    // Update is called once per frame
    void Update () {

        setvalues ();

    }

    public void setvalues () {

        setUpDownSpeed = setUpDownSpeedSlider.value;
        setSpeed = setSpeedSlider.value;
        setSpeedText.text = setSpeed.ToString ("0");
        setUpDownSpeedText.text = setUpDownSpeed.ToString ("0");

    }

    public void resetValues () {
        setUpDownSpeed = 280;
        setSpeed = 600;
        setSpeedSlider.value = setSpeed;
        setUpDownSpeedSlider.value = setUpDownSpeed;
        setSpeedText.text = setSpeed.ToString ("0");
        setUpDownSpeedText.text = setUpDownSpeed.ToString ("0");

    }

    public void saveData () {
        deleteData ();
        PlayerPrefs.SetFloat ("speedseted", setSpeed);
        PlayerPrefs.SetFloat ("UpDownSpeedseted", setUpDownSpeed);
    }
    public void deleteData () {
        PlayerPrefs.DeleteKey ("speedseted");
        PlayerPrefs.DeleteKey ("UpDownSpeedseted");
    }
    public void loadData () {
        setSpeed = PlayerPrefs.GetFloat ("speedseted");
        setUpDownSpeed = PlayerPrefs.GetFloat ("UpDownSpeedseted");
    }

}