using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target_bo : Target
{
    public override void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0f && variablesBallons.ballonREclate){
            variablesBallons.ballonOEclate=true;
            die();
        }
    }

    void die()
    {
        Destroy(gameObject);
    }
}
