using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathstar : MonoBehaviour
{
    public GameObject laser3;
    public GameObject laserpoint;
    public GameObject mainlaser;
    void Start()
    {
        laserpoint.SetActive(false);
        laser3.SetActive(false);
        mainlaser.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        

    }
   
}
