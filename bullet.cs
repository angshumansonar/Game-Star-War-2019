using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public GameObject expo;
    AudioSource AudioClip;

    void Start()
    {
        expo.SetActive(false);
        AudioClip = GetComponent<AudioSource>();
    }

    public void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "enemy")
        {
            expo.SetActive(true);
            AudioClip.Play();
            Destroy(this.gameObject);
        }

    }

}
