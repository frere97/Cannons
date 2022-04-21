using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointUp : MonoBehaviour
{
    public int point;
    public string text;
    public Text pointText;

    void Start()
    {
        pointText.text = text +": " + point;
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.gameObject.tag == "Disk")
        {
            point++;
            pointText.text = text +": " + point;
            coll.transform.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            coll.transform.position = new Vector2(0, 0);
        }

    }

    void OnTriggerExit2D(Collider2D coll){
        if(coll.gameObject.GetComponent<CannonBall>() != null){
            Destroy(coll.gameObject);
        }
    }
}
