using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class password : MonoBehaviour
{

    public GameObject lum1;
    public GameObject lum2;
    public GameObject lum3;
    public GameObject lum4;
    public GameObject door;
    public GameObject pivot;
    public GameObject colliderLift;
    //private static GameObject[] lums= {lum1,lum2,lum3,lum4};

    public Material matv;
    public Material mato;
    public Material matr;

    private int[] pwd = {6,9,2,7} ;
    private static int[] result = {-1,0,0,0} ;
    //prendre en paramètres les 4 lettres indicatives du remplissage des chiffres

    private bool goodpwd = false;
    public static int cpt = 0;

    // Start is called before the first frame update
    void Start()
    {
        colliderLift.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(cpt == 4){
            for(int i = 0; i< pwd.Length; i++){
                goodpwd = pwd[i] == result[i];
                if(goodpwd==false){
                    cpt = 0;
                    lum1.GetComponent<Renderer>().material = matr;
                    lum2.GetComponent<Renderer>().material = matr;
                    lum3.GetComponent<Renderer>().material = matr;
                    lum4.GetComponent<Renderer>().material = matr;
                    break;
                }

            }
            if(goodpwd==true){
                lum1.GetComponent<Renderer>().material = matv;
                lum2.GetComponent<Renderer>().material = matv;
                lum3.GetComponent<Renderer>().material = matv;
                lum4.GetComponent<Renderer>().material = matv;

                //si le code est bon on veut ouvrir la porte
                //door.transform.RotateAround(pivot.transform.position, Vector3.up,90);
                //lancer l'animation
                OpenDoor.goodcode = true;

                //on active le cube qui sert de collider à l'ascenseur
                colliderLift.SetActive(true);
                
            }
        }        

    }
    public static void clicked(int num){
        //j'allume la led
        result[cpt] = num;
        cpt = cpt+1;
    }



}
