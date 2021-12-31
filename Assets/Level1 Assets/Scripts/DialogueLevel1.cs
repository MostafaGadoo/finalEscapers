using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class DialogueLevel1 : MonoBehaviour
{
    public GameObject Panel;
    public TextMeshProUGUI textdisplay;
    public string[] sentences;
    private int index;
    public float typingspeed;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Type());
    }
    IEnumerator Type()
    {
        foreach (char letter in sentences[index].ToCharArray())
        {
            textdisplay.text += letter;
            yield return new WaitForSeconds(typingspeed);
        }
    }
    public void NextSentence()
    {
        if (index < sentences.Length - 1)
        {
            index++;
            textdisplay.text = "";
            StartCoroutine(Type());
        }
        else
        {
            textdisplay.text = "";
            Panel.SetActive(false);

        }
    }

}
