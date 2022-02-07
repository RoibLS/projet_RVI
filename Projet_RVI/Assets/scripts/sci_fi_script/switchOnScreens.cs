using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using UnityEngine;

public class switchOnScreens : MonoBehaviour
{

    public Material Mat;
    Renderer rand1;
    Renderer rand2;
    Renderer rand3;
    Renderer rand4;
    Renderer rand5;
    Renderer rand6;
    public GameObject ecran1;
    public GameObject ecran2;
    public GameObject ecran3;
    public GameObject ecran4;
    public GameObject ecran5;
    public GameObject ecran6;
    public Texture camera1;
    public Texture camera2;
    public Texture k;
    public Texture mai;
    public Texture rat;
    public Texture explication;



    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
    }

    public void switchOn()
    {
        rand1 = ecran1.GetComponent<Renderer>();
        rand2 = ecran2.GetComponent<Renderer>();
        rand3 = ecran3.GetComponent<Renderer>();
        rand4 = ecran4.GetComponent<Renderer>();
        rand5 = ecran5.GetComponent<Renderer>();
        rand6 = ecran6.GetComponent<Renderer>();

        rand1.material.mainTexture = camera1;
        rand2.material.mainTexture = rat;
        rand5.material.mainTexture = mai;
        rand3.material.mainTexture = explication;
        rand4.material.mainTexture = k;
        rand6.material.mainTexture = camera2;

    }


    void OnMouseDown()
    {
        switchOn();
    }


}
