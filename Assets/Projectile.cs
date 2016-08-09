using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {

    public float speed;
    public float damage;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
	}

    void OnTriggerEnter2D(Collider2D collider)
    {
        GameObject target = collider.gameObject;
        Debug.Log(target.name);
        if (target) {
            Health enemyHealth = target.GetComponent<Health>();
            Attacker attacker = target.GetComponent<Attacker>();
            if (enemyHealth && attacker)
            {
                enemyHealth.DealDamage(damage);
                Destroy(gameObject);
            }
        }
        
    }

}
