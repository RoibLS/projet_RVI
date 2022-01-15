
using UnityEngine;

public abstract class Target : MonoBehaviour
{
    public float health = 1f;

    public abstract void TakeDamage(float amount);
    /*
    {
        health -= amount;
        if (health <= 0f) die();
    }*/

    void die()
    {
        Destroy(gameObject);
    }
}
