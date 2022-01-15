using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target_bbc : Target
{
    public override void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0f && variablesBallons.ballonBEclate){
            variablesBallons.ballonBcEclate=true;
            die();
        }
    }

    void die()
    {
        Destroy(gameObject);
    }
}