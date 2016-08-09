using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

    public float health = 100f;
	// Use this for initialization
    public void DealDamage (float damage)
    {
        health -= damage;
        if(health <= 0)
        {
            DestroyObject();
        }

    }

    public void DestroyObject()
    {
        Destroy(gameObject);
    }
	// Update is called once per frame
}
