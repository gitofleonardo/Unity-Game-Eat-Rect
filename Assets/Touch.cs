using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch : MonoBehaviour {
    public GameObject player;
    public GameObject touchBlock;
    private Vector2 startPos;
    private Vector3 thisPos;
    private Vector2 originPos;
    // Use this for initialization
    void Start () {
        thisPos = transform.position;
        originPos = touchBlock.transform.position;
	}
	// Update is called once per frame
	void Update () {
        if (Input.touchCount > 0 && Global.enableScene)
        {
            
            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                startPos = Input.GetTouch(0).position;
                return;
            }
            Vector2 pos = Input.GetTouch(0).position;
            Vector2 delta = pos - startPos;
            if (delta.y>0)
            {
                //move up
                moveUp();
            }
            else
            {
                //move down
                moveDown();
            }
            if (delta.x>0)
            {
                //move right
                moveRight();
            }
            else
            {
                //move left
                moveLeft();
            }
            moveTo(pos,startPos);
        }
        else
        {
            touchBlock.transform.position = originPos;
        }
    }
    private void moveTo(Vector2 vec,Vector2 start)
    {
        touchBlock.transform.position = vec;
        /*if (distance(vec.x,start.x,vec.y,start.y) < 300)
        {
            
        }
        */
        
    }
    private float distance(float x1,float x2,float y1,float y2)
    {
        return Mathf.Pow(Mathf.Pow(x1 - x2, 2) - Mathf.Pow(y1 - y2, 2), 0.5f);
    }
    private void moveUp()
    {
        player.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, 10));
    }
    private void moveDown()
    {
        player.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, -10));
    }
    private void moveLeft()
    {
        player.GetComponent<Rigidbody>().AddForce(new Vector3(-10, 0, 0));
    }
    private void moveRight()
    {
        player.GetComponent<Rigidbody>().AddForce(new Vector3(10, 0, 0));
    }
}
