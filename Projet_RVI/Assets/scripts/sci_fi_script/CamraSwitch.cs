using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamraSwitch : MonoBehaviour
{

    public GameObject cam1;
    public GameObject cam2;
    public GameObject perso;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            if (cam1.activeSelf)
            {
                cam1.SetActive(false);
                cam2.SetActive(true);
            }
            else
            {

            }

        }
        

    }
}
