using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clignoteLumiere : MonoBehaviour
{
    public float timerMax;
    public float timerMin;
    public Light light;
    public float timer;
    // Start is called before the first frame update
    void Start()
    {
        timer= Random.Range(timerMin,timerMax);
    }

    // Update is called once per frame
    void Update()
    {
        blink();
    	
    }

    void blink(){
        if (timer>0){
            timer-=Time.deltaTime;
        }
        if (timer<=0){
            light.enabled = !light.enabled;
            timer=Random.Range(timerMin,timerMax);
        }
    }
}
