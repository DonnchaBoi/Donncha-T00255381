using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    Rigidbody rb;
    float kickStrength = 2;
    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void KickBall(Transform kicker)
    {
        rb.AddExplosionForce(kickStrength, kicker.position, 4);
    }


    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.name == "Plane")
        { print("Boing!!"); }
        else
        {
            ZombieControl testIfZombie = gameObject.GetComponent<ZombieControl>();
            if (testIfZombie != null) 
            {
                testIfZombie.dieNow();
            }
            print("Ouch");

            KickBall(collision.transform);
        }


    }
}
