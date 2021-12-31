using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public Slider timerslider;
    public Text timertext;
    private bool stoptimer;
    public float gametime;
  
    

    // Start is called before the first frame update
    void Start()
    {
        stoptimer = false;
        timerslider.maxValue = gametime;
        timerslider.value = gametime;
    }

    // Update is called once per frame
    void Update()
    {
        float time = gametime -Time.time;
        int mins = Mathf.FloorToInt(time / 60);
        int secs = Mathf.FloorToInt(time - mins * 60f);
        string texttime = string.Format("{0:0}:{1:00}", mins, secs);
        if(time <= 0) {
            stoptimer = true;
            SceneManager.LoadScene("TryAgain");
        }
        if (stoptimer == false)
        {
            timertext.text = texttime;
            timerslider.value = time;
        }
    }
}
