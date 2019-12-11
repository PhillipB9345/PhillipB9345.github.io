using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OurBullet : MonoBehaviour
{
    public float speed; // float created for speed
    void Start()
    {
        GetComponent<Rigidbody>().velocity = transform.forward * speed; // this is muliplied by speed so that we can adjust the speed ourselves, the rigidbody collision is multiplied by the speed set by editor.
    }
}