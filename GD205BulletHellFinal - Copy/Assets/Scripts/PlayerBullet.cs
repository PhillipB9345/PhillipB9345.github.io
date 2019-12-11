using UnityEngine;
using System.Collections;

[System.Serializable]
public class Boundary1
{
    public float xMin, xMax, zMin, zMax;
}

public class PlayerBullet : MonoBehaviour
{
    public float speed;

    public Boundary1 boundary;

    public GameObject Shots;
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

    void FixedUpdate()
    {

        float moveHorizontal = Input.GetAxis("Horizontal"); // allows movement
        float moveVertical = Input.GetAxis("Vertical"); // allows movement

        var movement = new Vector3(moveHorizontal, 0.0f, moveVertical); // movement for player
        var rigidbody = GetComponent<Rigidbody>(); // makes rigidbody(physics) active
        rigidbody.velocity = movement * speed; // force of which player moves

        rigidbody.position = new Vector3
            (
            Mathf.Clamp(rigidbody.position.x, boundary.xMin, boundary.xMax),
            0.0f,
            Mathf.Clamp(rigidbody.position.z, boundary.zMin, boundary.zMax)
            );
    }
}