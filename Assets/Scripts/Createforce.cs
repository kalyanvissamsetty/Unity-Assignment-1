using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Createforce : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private Vector3 force;
    void Start()
    {
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        force = new Vector3(Random.Range(-2, 2), Random.Range(-2, 2), 0);
        rigidbody.AddForce(force, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
