using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class popUpText : MonoBehaviour
{
    public Level4Text DManager  ;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Player")
        {
            string[] dialogue = {
           "2 Down 2 too goo!!",
           "Beating the monsters wont be as easy as you think take care for the traps.",
           "They kill you with only on touch.",
           "GOOD LUCK WORRIOR!!!"
            };

            DManager.SetSentence(dialogue);
            DManager.StartCoroutine(DManager.TypeDialogue());            
        }
    }
}

        
            
                

        
