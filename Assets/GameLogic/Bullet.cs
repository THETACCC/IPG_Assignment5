using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed;
    public float bulletLifetime;
    public void DestroyWhenTooLong()
    {
        Destroy(gameObject);
    }
}
