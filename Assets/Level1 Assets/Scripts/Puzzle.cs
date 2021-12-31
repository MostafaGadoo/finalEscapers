using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Puzzle : MonoBehaviour
{
    public Transform edgeparticles; 
    public string placeStatus = "idle";
    public KeyCode placepiece;
    public string checkplacement = "";
    public float ydiff;
    public Vector2 invPos;
    public KeyCode returninv;
   
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        if (placeStatus == "pickedup")
        {
            Vector2 mouseposition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            Vector2 objposition = Camera.main.ScreenToWorldPoint(mouseposition);
            transform.position = objposition;
        }
        if ((Input.GetKeyDown(placepiece))&&(placeStatus == "pickedup"))
        {
            checkplacement = "y";
        }
        if (Input.GetMouseButtonUp(0))
        {
            placeStatus = null;
        }
    }
    void OnTriggerStay2D(Collider2D other)
    {
        if ((other.gameObject.name == gameObject.name)&& (checkplacement=="y"))
        {
            other.GetComponent<BoxCollider2D>().enabled = false;
            GetComponent<BoxCollider2D>().enabled = false;
            GetComponent<Renderer>().sortingOrder = 0;
            transform.position = other.gameObject.transform.position;
            placeStatus = "locked";
            Instantiate(edgeparticles, other.gameObject.transform.position, edgeparticles.rotation);
            checkplacement = "n";
            GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
            Puzzlegame.remainingpiece -= 1;
        }
        if ((other.gameObject.name != gameObject.name) && (checkplacement == "y"))
        {
            GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, .5f);
            checkplacement = "n";
            Healthbarscript.health -= 10f;
        }
    }
    private void OnMouseDown()
    {
        placeStatus = "pickedup";
        checkplacement = "n";
        GetComponent<Renderer>().sortingOrder = 10;
        invPos = transform.position;
    }
 
    
}
