using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeColor : MonoBehaviour
{
    public void HoverOver(){
        GetComponent<Renderer>().material.EnableKeyword("_EMISSION  ");
    }

}
