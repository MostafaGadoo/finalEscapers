using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzlegame : MonoBehaviour
{
    public static int remainingpiece = 9;
    public GameObject Panel;
    public GameObject Text;
    public static bool exittext;
    // Start is called before the first frame update
    void Start()
    {
        Panel.SetActive(false);
        //Text.SetActive(false);
        //exittext = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (remainingpiece == 0)

        {
            //exittext = true;
            //Text.SetActive(true);
            Panel.SetActive(true);
        }  
    }
}
