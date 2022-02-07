using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveLift : MonoBehaviour
{

    public GameObject plane;
    public GameObject lift;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void removeDoors()
    {
        Destroy(plane);
        Destroy(lift);
    }

    void OnMouseDown()
    {
        removeDoors();
    }
}
