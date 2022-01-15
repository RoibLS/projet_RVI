using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target_br : Target 
{
    public override void TakeDamage(float amount)
    {
        Debug.Log(health);
        health -= amount;
        if (health <= 0f) {
            variablesBallons.ballonREclate=true;
            die();
        }
    }
     
    void die()
    {
        Destroy(gameObject);
    }
}
