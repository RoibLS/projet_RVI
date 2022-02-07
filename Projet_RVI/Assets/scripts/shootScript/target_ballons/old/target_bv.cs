using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target_bv : Target
{
    public override void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0f && variablesBallons.ballonJEclate){
            variablesBallons.ballonVEclate=true;
            die();
        }
    }

    void die()
    {
        Destroy(gameObject);
    }
}
