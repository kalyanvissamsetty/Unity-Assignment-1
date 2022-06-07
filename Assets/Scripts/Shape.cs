using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 screenPoint;
    private Vector3 offset;
    private Rigidbody rg;
    

    
    private void Start()
    {
        
        rg = GetComponent<Rigidbody>();
        
    }
    void OnMouseDown()
    {
        screenPoint = Camera.main.WorldToScreenPoint(new Vector3(gameObject.transform.position.x, gameObject.transform.position.y,0));

        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));

    }


    private void Update()
    {
        checkBoundaries();
    }
    void checkBoundaries()
    {
        if (transform.position.x >= 7.0f)
        {
            transform.position = new Vector3(7.0f, transform.position.y, 0);
        }

        if (transform.position.x <= -3.02f)
        {
            transform.position = new Vector3(-3.02f, transform.position.y, 0); 
        }

        if (transform.position.y >= 3.5f)
        {
            transform.position = new Vector3(transform.position.x, 3.5f, 0);
        }

        if (transform.position.y <= -2.2f)
        {
            transform.position = new Vector3(transform.position.x, -2.2f, 0);
        }

    }
    void OnMouseDrag()
    {
        Debug.Log(Boundaries.leftb);
        Debug.Log(Boundaries.rightb);
        Debug.Log(Boundaries.bottomb);
        Debug.Log(Boundaries.topb);
        //Vector3 curScreenPoint = new Vector3(Mathf.Clamp(Input.mousePosition.x,Boundaries.leftb,Boundaries.rightb), Mathf.Clamp(Input.mousePosition.x, Boundaries.bottomb, Boundaries.topb), 0);
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
        transform.position = curPosition;

    }

    private void OnCollisionEnter(Collision collision)
    {
        if(this.tag == collision.gameObject.tag)
        {
            if (collision.rigidbody.velocity.magnitude > rg.velocity.magnitude)
            {
                Destroy(this.gameObject);
            }
            else
            {
                Destroy(collision.gameObject);
            }
        }
       
    }

}
