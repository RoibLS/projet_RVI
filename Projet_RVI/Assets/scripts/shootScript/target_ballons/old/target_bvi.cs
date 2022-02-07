using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target_bvi : Target
{
    public GameObject ascenseur;

    public override void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0f && variablesBallons.ballonBEclate){
            variablesBallons.ballonViEclate=true;
            ascenseur.SetActive(true);
            die();
        }
    }

    void die()
    {
        Destroy(gameObject);
    }
}
