using UnityEngine;
using System.Collections;
 
public class Recoil : MonoBehaviour
{

    private float recoil = 0.0f;
    private float maxRecoil_x = -10f;
    private float maxRecoil_y = 0f;
    private float maxRecoil_z = 0f;
    private float recoilSpeed = 2f;
    private Vector3 base_pos;

    //private float maxTrans_x = 1.0f;
    private float maxTrans_z = -0.1f;

    public void StartRecoil (float recoilParam, float maxRecoil_xParam, float recoilSpeedParam)
    {
        // in seconds
        recoil = recoilParam;
        //maxRecoil_x = maxRecoil_xParam;
        recoilSpeed = recoilSpeedParam;
        //maxRecoil_y = Random.Range(-maxRecoil_xParam, maxRecoil_xParam);
    }
 
    void recoiling ()
    {

        if (recoil > 0f) {
            Quaternion maxRecoil = Quaternion.Euler (maxRecoil_x, maxRecoil_y,maxRecoil_z);
            // Dampen towards the target rotation
            transform.localRotation = Quaternion.Slerp (transform.localRotation, maxRecoil, Time.deltaTime * recoilSpeed);
            recoil -= Time.deltaTime;
        } else {
            recoil = 0f;
            // Dampen towards the target rotation
            transform.localRotation = Quaternion.Slerp (transform.localRotation, Quaternion.identity, Time.deltaTime * recoilSpeed / 2);
        }
    }
 
    // Update is called once per frame
    void Update ()
    {
        recoiling ();
    }
}