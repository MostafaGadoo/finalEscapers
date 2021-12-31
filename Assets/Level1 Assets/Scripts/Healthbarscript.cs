using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Healthbarscript : MonoBehaviour
{
    Image healthimage;
    float max = 100f;
    public static float health;
    void Start()
    {
        healthimage = GetComponent<Image>();
        health = max;
    }

    // Update is called once per frame
    void Update()
    {
        healthimage.fillAmount = health / max;
        if (health == 0)
        {
            SceneManager.LoadScene("TryAgain");
        }
    }
}
