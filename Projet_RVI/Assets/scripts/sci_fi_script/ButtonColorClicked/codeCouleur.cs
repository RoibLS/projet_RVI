using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class codeCouleur : MonoBehaviour
{

    public static bool vert;
    public static bool rouge;
    public static bool marron;
    public static bool bleu;
    public static bool jaune;
    public static bool noir;

    // Start is called before the first frame update
    void Start()
    {
        vert = false;
        rouge = false;
        marron = false;
        bleu = false;
        jaune = false;
        noir = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (noir == true || jaune == true || bleu == true)
        {
            vert = false;
            rouge = false;
            marron = false;
            bleu = false;
            jaune = false;
            noir = false;
        }
        else if(vert == true)
        {
            if(rouge == true)
            {
                if (marron == true)
                {
                    SceneManager.LoadScene("scene3");
                    //UnityEditor.EditorApplication.isPlaying = false;
                }
            }
            else if(marron == true)
            {
                vert = false;
                rouge = false;
                marron = false;
                bleu = false;
                jaune = false;
                noir = false;
            }
        }
        else
        {
            vert = false;
            rouge = false;
            marron = false;
            bleu = false;
            jaune = false;
            noir = false;
        }
    }
        
        
        

}
