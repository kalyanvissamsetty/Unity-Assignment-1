using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIManager : MonoBehaviour
{
    [SerializeField]
    private GameObject cube;

    [SerializeField]
    private GameObject sphere;

    [SerializeField]
    private GameObject capsule;

    private int cubeCount;
    private int sphereCount;
    private int capsuleCount;
    //private UIManager ui;
    [SerializeField]
    private GameObject boxCube;

    [SerializeField]
    private GameObject boxSphere;

    [SerializeField]
    private GameObject boxCapsule;

    [SerializeField]
    private Toggle cubeToggle;

    [SerializeField]
    private Toggle sphereToggle;

    [SerializeField]
    private Toggle capsuleToggle;


    private Renderer cubeRenderer;
    private Renderer sphereRenderer;
    private Renderer capsuleRenderer;
    private Color cubecolor;
    private Color spherecolor;
    private Color capsulecolor;
    [SerializeField]
    private GameObject _cubeManger;

    [SerializeField]
    private GameObject _sphereManger;

    [SerializeField]
    private GameObject _capsuleManger;
    void Start()
    {
        cubeCount = 0;
        sphereCount = 0;
       
        capsuleCount = 0;
        cubeRenderer = cube.GetComponent<Renderer>();
        sphereRenderer = sphere.GetComponent<Renderer>();
        capsuleRenderer = capsule.GetComponent<Renderer>();
    }
    

    // Update is called once per frame

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) { 
            Application.Quit();

        }
        if(cubeCount >= 1)
        {
            boxCube.SetActive(true);
        }
        else
        {
            boxCube.SetActive(false);
        }

        if (sphereCount >= 1)
        {
            boxSphere.SetActive(true);
        }
        else
        {
            boxSphere.SetActive(false);
        }

        if (capsuleCount >= 1)
        {
            boxCapsule.SetActive(true);
        }
        else
        {
            boxCapsule.SetActive(false);
        }
    }

    public void callCube()
    {
        float x;
        float y;
        float z;
        Vector3 pos;
        x = Random.Range(-2.11f,6.31f);
        y = Random.Range(-1.46f, 2.93f);
        z = 0;
        pos = new Vector3(x, y, z);
        GameObject obj = Instantiate(cube, pos, Quaternion.identity);
        obj.transform.parent = _cubeManger.transform;
        cubeCount++;
        
    }
    public void callSphere()
    {
        float x;
        float y;
        float z;
        Vector3 pos;
        x = Random.Range(-2.11f, 6.31f);
        y = Random.Range(-1.46f, 2.93f);
        z = 0;
        pos = new Vector3(x, y, z);
        GameObject obj = Instantiate(sphere, pos, Quaternion.identity);
        obj.transform.parent = _sphereManger.transform;
        sphereCount++;
    }
    public void callCapsule()
    {
        float x;
        float y;
        float z;
        Vector3 pos;
        x = Random.Range(-2.11f, 6.31f);
        y = Random.Range(-1.46f, 2.93f);
        z = 0;
        pos = new Vector3(x, y, z);

        GameObject obj = Instantiate(capsule, pos, Quaternion.identity);
        obj.transform.parent = _capsuleManger.transform;
        capsuleCount++;
    }


    public void changeCube()
    {
        if (cubeToggle.isOn)
        {
            cubecolor = new Color(124, 252, 0, 1f);
            cubeRenderer.sharedMaterial.SetColor("_Color",cubecolor);
        }
        else
        {
            cubecolor = new Color(255, 255, 255, 1f);
            cubeRenderer.sharedMaterial.SetColor("_Color", cubecolor);
        }
    }

    public void changeSphere()
    {
        if (sphereToggle.isOn)
        {
            spherecolor = new Color(124, 252, 0, 1f);
            sphereRenderer.sharedMaterial.SetColor("_Color", spherecolor);
        }
        else
        {
            spherecolor = new Color(255, 255, 255, 1f);
            sphereRenderer.sharedMaterial.SetColor("_Color", spherecolor);
        }
    }

    public void changeCapsule()
    {
        if (capsuleToggle.isOn)
        {
            capsulecolor = new Color(124, 252, 0, 1f);
            capsuleRenderer.sharedMaterial.SetColor("_Color", capsulecolor);
        }
        else
        {
            capsulecolor = new Color(255, 255, 255, 1f);
            capsuleRenderer.sharedMaterial.SetColor("_Color", capsulecolor);
        }
    }
}
