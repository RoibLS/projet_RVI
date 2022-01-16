using UnityEngine;

public class gun : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;
    public float impactForce = 30f;
    public float fireRate = 5f;

    public Camera fpsCam;
    public ParticleSystem muzzleflash;
    public GameObject impactEffect;

    private float nextTimeToFire = 0f;

    private AudioSource gun_sound;
    private Recoil recoilComponent;
    void Start(){
        recoilComponent= GetComponent<Recoil>();
        gun_sound=GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && Time.time >= nextTimeToFire)
        {
            nextTimeToFire = Time.time + 1f / fireRate;
            Shoot();
        }
    }

    void Shoot()
    {
        RaycastHit hit;
        recoilComponent.StartRecoil(0.2f, 10f, 10f);
        muzzleflash.Play();
        gun_sound.Play();
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
            Target target = hit.transform.GetComponent<Target>();
            if (target != null)
            {
                target.TakeDamage(damage);
            }
            if (hit.rigidbody != null)
            {
                hit.rigidbody.AddForce(-hit.normal * impactForce);
            }
            GameObject impactGo=Instantiate(impactEffect, hit.point, Quaternion.LookRotation(hit.normal));
            Destroy(impactGo, 2f);
            //muzzleflash.Stop();
        }
    }
}
