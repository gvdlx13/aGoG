using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour {

    public GameObject projectile, projectileParent, gun;
	// Use this for initialization
    private void Fire()
    {
        GameObject newProjectile = Instantiate(projectile) as GameObject;
        Debug.Log(projectileParent.name);
        newProjectile.transform.parent = projectileParent.transform;
        newProjectile.transform.position = gun.transform.position;
    }
}
