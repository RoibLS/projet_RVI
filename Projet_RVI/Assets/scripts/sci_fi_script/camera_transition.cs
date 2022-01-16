using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_transition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
 //on mouse down

 /*
 1° Tu créer un gameObject représentant ta zone, tu le met en trigger et tu désactive son renderer.
2° Tu place un script dans lequel tu créer deux variable camera, l'une où tu affecteras ta cam joueur, et l'autre la statique
3° tu te sers des fonctions OnTriggerEnter et OnTriggerExit dans lesquels tu active désactive les cameras en utilisant leurs méthodes enabled (ou quelque chose du genre, j'ai un doute je t'invite à regarder la doc).
*/