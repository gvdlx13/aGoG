using UnityEngine;
using System.Collections;

public class Attacker : MonoBehaviour
{

    // Use this for initialization
    
    private float currentSpeed;
    private GameObject Target;
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * currentSpeed * Time.deltaTime);
        if(!Target)
        {
            animator.SetBool("Is Attacking", false);
        }
    }


    void OnTriggerEnter2D()
    {
        Debug.Log(name + " trigger event");
    }

    public void SetSpeed(float speed)
    {
        currentSpeed = speed;
    }

    public void StrikeCurrentTarget (float damage)
    {
        if (Target)
        {
            Health health = Target.GetComponent<Health>();
            if (health)
            {
                health.DealDamage(damage);
            }
        }

        Debug.Log(name + " caused damage: " + damage + " to " + Target.name);
    }

    public void Attack (GameObject obj)
    {
        Target = obj;
    }
}
