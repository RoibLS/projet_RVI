using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class variablesBallons : MonoBehaviour
{
    public static bool ballonREclate =false;
    public static bool ballonOEclate =false;
    public static bool ballonJEclate =false;
    public static bool ballonVEclate =false;
    public static bool ballonBEclate =false;
    public static bool ballonBcEclate =false;
    public static bool ballonViEclate =false;

    // Start is called before the first frame update
    void Start()
    {
        ballonREclate =false;
        ballonOEclate =false;
        ballonJEclate =false;
        ballonVEclate =false;
        ballonBEclate =false;
        ballonBcEclate =false;
        ballonViEclate =false;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(ballonREclate);
    }
}
