using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenTiroir : MonoBehaviour
{

    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(switchSceens.rebuFinished == true || switchScreens2.rebuFinished == true || switchSreens3.rebuFinished == true){
            anim.SetBool("rebuFinished", true);
        }
    }
}
