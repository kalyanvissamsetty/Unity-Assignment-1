using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundaries : MonoBehaviour
{
    [SerializeField]
    private GameObject top;

    [SerializeField]
    private GameObject bottom;

    [SerializeField]
    private GameObject right;

    [SerializeField]
    private GameObject left;


    public static float leftb, rightb, topb, bottomb;
    void Start()
    {
        leftb = left.transform.position.x;
        rightb = right.transform.position.x;
        topb = top.transform.position.y;
        bottomb = bottom.transform.position.y;
    }
    void Update()
    {
        
    }
}
