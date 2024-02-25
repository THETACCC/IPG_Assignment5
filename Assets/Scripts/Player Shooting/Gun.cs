using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField]
    private GameObject KineticBullet;
    [SerializeField] private GameObject GravityBullet;
    [SerializeField] private GameObject LiftBullet;
    [SerializeField]
    private GameObject firingPoint;
    [SerializeField]
    private float bulletSpeed;

    public GunChangeMode gunChangeMode;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }

    }

    public void Shoot()
    {
        Debug.Log("ShooTING");
        if(gunChangeMode.mode == 0)
        {
            GameObject bullet = Instantiate(KineticBullet, firingPoint.transform.position, transform.rotation);
        }
        else if(gunChangeMode.mode == 1)
        {
            GameObject bullet = Instantiate(GravityBullet, firingPoint.transform.position, transform.rotation);
        }
        else if (gunChangeMode.mode == 2)
        {
            GameObject bullet = Instantiate(LiftBullet, firingPoint.transform.position, transform.rotation);
        }

    }



}
