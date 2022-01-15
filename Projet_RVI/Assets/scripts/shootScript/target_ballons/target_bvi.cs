using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target_bvi : Target
{
    public override void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0f && variablesBallons.ballonBcEclate){
            variablesBallons.ballonViEclate=true;
            die();
        }
    }

    void die()
    {
        Destroy(gameObject);
    }
}
