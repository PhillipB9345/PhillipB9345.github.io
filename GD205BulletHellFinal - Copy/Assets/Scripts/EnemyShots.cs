using System.Collections;
using UnityEngine;

public class EnemyShots : MonoBehaviour
{
    public GameObject Shots; // variables made to make actions happen
    public Transform BulletSpawn;
    public float fireRate;

    private float nextFire;

    void Update()
    {
        if (Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(Shots, BulletSpawn.position, BulletSpawn.rotation);

        }
    }

}

