using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class gunXR : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;
    public float impactForce = 30f;
    public float fireRate = 15f;

    public ParticleSystem muzzleflash;
    public GameObject impactEffect;
    

    private Recoil recoilComponent;
    private AudioSource gun_sound;
    private float nextTimeToFire = 0f;
    

    void Start(){
        recoilComponent= GetComponent<Recoil>();
        gun_sound=GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void Update()
    {
        var leftHandDevices = new List<UnityEngine.XR.InputDevice>();
        UnityEngine.XR.InputDevices.GetDevicesAtXRNode(UnityEngine.XR.XRNode.LeftHand, leftHandDevices);

        bool triggerValue;
        if (leftHandDevices[0].TryGetFeatureValue(UnityEngine.XR.CommonUsages.triggerButton ,out triggerValue) && triggerValue && Time.time >= nextTimeToFire)
        {
            nextTimeToFire = Time.time + 1f / fireRate;
            Shoot();
        }
    }

    void Shoot()
    {
        recoilComponent.StartRecoil(0.2f, 10f, 10f);
        muzzleflash.Play();
        gun_sound.Play();
    }
    
}
