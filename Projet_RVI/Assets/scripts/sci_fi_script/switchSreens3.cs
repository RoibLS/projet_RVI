using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchSreens3 : MonoBehaviour
{

    Renderer rand1;
    Renderer rand2;
    Renderer rand3;
    Renderer rand4;


    public GameObject ecran1;
    public GameObject ecran2;
    public GameObject ecran3;
    public GameObject ecran4;

    public Texture k;
    public Texture mai;
    public Texture rat;

    public Texture nonValide;
    public Texture valide;

    Texture temp;

    public static bool rebuFinished;

    

    // Start is called before the first frame update
    void Start()
    {
        rand1 = ecran1.GetComponent<Renderer>();
        rand2 = ecran2.GetComponent<Renderer>();
        rand3 = ecran3.GetComponent<Renderer>();
        rand4 = ecran4.GetComponent<Renderer>();

        rebuFinished=false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void success()
    {

        
        if (rand1.material.mainTexture == k && rand2.material.mainTexture == mai && rand3.material.mainTexture == rat)
        {
            rand4.material.mainTexture = valide;
            rebuFinished=true;

        }
        else
        {
            rand4.material.mainTexture = nonValide;
        }
    }

    public void switchPictures()
    {
        if (!(rand1.material.mainTexture == k && rand2.material.mainTexture == mai && rand3.material.mainTexture == rat))
        {
            temp = rand1.material.mainTexture;
            rand1.material.mainTexture = rand3.material.mainTexture;
            rand3.material.mainTexture = temp;

            success();
        }
        else
        {

        }
    }


    void OnMouseDown()
    {
        switchPictures();
    }


}
