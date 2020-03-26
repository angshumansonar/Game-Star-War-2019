using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunpoint11 : MonoBehaviour
{

    public float bulletSpeed = 2500;
    public GameObject bullet111;



    // Use this for initialization
    void Start()
    {



    }

    void Fire()
    {
        //Shoot
        GameObject tempBullet = Instantiate(bullet111, transform.position, transform.rotation) as GameObject;
        Rigidbody tempRigidBodyBullet = tempBullet.GetComponent<Rigidbody>();
        tempRigidBodyBullet.AddForce(tempRigidBodyBullet.transform.forward * bulletSpeed);
        Destroy(tempBullet, 5f);



    }


    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Jump"))
            Fire();


    }
}
