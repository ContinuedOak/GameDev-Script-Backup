using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletProjectile : MonoBehaviour
{
    //[SerializeField] private Transform sfxHitGreen;
    //[SerializeField] private Transform sfxHitRed;
    private Rigidbody bulletRigidBody;
    public GameObject bullet;


    private void Awake()
    {
        bulletRigidBody = GetComponent<Rigidbody>();
        
    }

    private void Start()
    {
        float speed = 100f;
        bulletRigidBody.velocity = transform.forward * speed;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<BulletTarget>() != null)
        {
            //Hit Target
            //Instantiate(sfxHitGreen, transform.position, Quaternion.identity);
        }
        else
        {
            //Hit Something Else
            //Instantiate(sfxHitGreen, transform.position, Quaternion.identity);
        }
        Destroy(bullet);
    }
}
