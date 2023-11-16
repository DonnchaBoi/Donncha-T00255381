using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    Rigidbody rb;
    float kickStrength = 800;
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
        rb.AddExplosionForce(kickStrength, kicker.position, 10);
    }


    private void OnCollisionEnter(Collision collision)
    {
        ZombieControl testIfZombie = collision.gameObject.GetComponent<ZombieControl>();
        if (testIfZombie != null)
        {
            print("Zombie");
            testIfZombie.dieNow();
        }
        else
            print("not zombie");




        if (collision.gameObject.name == "Plane")
        { print("Boing!!"); }
        else
        {

            print("Ouch");

            KickBall(collision.transform);
        }
        Destroy(gameObject, 1);

    }
}
