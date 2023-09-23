using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : MonoBehaviour
{
    RaycastHit hit;

    [SerializeField]
    Transform shootPoint;

    [SerializeField]
    int currentAmmo;

    [SerializeField]
    float rateOfFire;
    float nextFire = 0;

    [SerializeField]
    float weaponRange;

    void Shoot()
    {
        if(Time.time>nextFire)
        {
            nextFire = Time.time + rateOfFire;
            currentAmmo--;

            if (Physics.Raycast(shootPoint.position, shootPoint.forward, out hit, weaponRange))
            {
                if(hit.transform.tag=="Enemy")
                {
                    Debug.Log("Hit Enemy");
                }
                else
                {
                    Debug.Log("Hit something else");
                }
            }
        }
    }

     void Update()
    {
        if(Input.GetButton("Fire1")&&currentAmmo>0)
        {
            Shoot();
        }
    }

}
