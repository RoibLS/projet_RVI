using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;
using UnityEngine.XR;

public class startGame : MonoBehaviour
{
    public GameObject camera;
    public GameObject left_hand;
    float range=100f;
    public Material Mat1;
    public Material Mat2;
    public Material Mat3;
    Renderer rand;
    public GameObject cube;

    // Start is called before the first frame update
    void Start()
    {
        rand = cube.GetComponent<Renderer>();
        rand.enabled = true;       
    }

    // Update is called once per frame
    void Update()
    {
        var leftHandDevices = new List<UnityEngine.XR.InputDevice>();
        UnityEngine.XR.InputDevices.GetDevicesAtXRNode(UnityEngine.XR.XRNode.LeftHand, leftHandDevices);

        if(leftHandDevices.Count == 1)
        {
            UnityEngine.XR.InputDevice device = leftHandDevices[0];
            Debug.Log(string.Format("Device name '{0}' with role '{1}'", device.name, device.role.ToString()));
        }
        else if(leftHandDevices.Count > 1)
        {
            Debug.Log("Found more than one left hand!");
        }
        
        RaycastHit hit;
        bool triggerValue;
        if (leftHandDevices[0].TryGetFeatureValue(UnityEngine.XR.CommonUsages.primary2DAxisClick,out triggerValue) && triggerValue)
        {
            Debug.Log("oui appuyé");
            if (Physics.Raycast(left_hand.transform.position, left_hand.transform.forward, out hit, range))
            {
                rand.sharedMaterial = Mat1;
                Debug.Log(hit.transform.name);               
                if(hit.transform.name=="RevovlingDoor_DoorFrame_LOD0"){
                    rand.sharedMaterial = Mat3;
                    //Application.Quit();
                }

            }
        }
        
        // if (Input.GetKey(KeyCode.JoystickButton0)){ // if left button pressed...
        // Ray ray = camera.ScreenPointToRay(Input.mousePosition);
        // RaycastHit hit;
        // if (Physics.Raycast(ray, out hit)){
        // // the object identified by hit.transform was clicked
        // // do whatever you want
        //     Application.Quit();
        //}
    }
    
}


