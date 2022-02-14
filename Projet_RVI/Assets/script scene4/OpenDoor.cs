using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    private Animator anim;
    public static bool goodcode;

    // Start is called before the first frame update
    void Start()
    {
        goodcode = false;
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(goodcode){
            anim.SetBool("goodcode", true);
        }
    }
}
