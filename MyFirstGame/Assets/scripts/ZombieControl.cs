using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class ZombieControl : MonoBehaviour
{
    CubeControl player;
    NavMeshAgent agent;
    Animator zombieAnimator;
    enum ZombieState { Idle, Attack, Follow,
        Dying
    }
    ZombieState currentlyIs = ZombieState.Idle;
    private float aggroRadius = 100;
    private float walkingSpeed = 0.3f;
    private float meleeDistance = 1;

    // Start is called before the first frame update
    void Start()
    {
        zombieAnimator = GetComponent<Animator>();
        player = FindObjectOfType<CubeControl>();

        agent = this.GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (currentlyIs)
        {
            case ZombieState.Idle:
                transform.position += transform.forward * walkingSpeed * Time.deltaTime;

                if (Vector3.Distance(player.transform.position, transform.position) < aggroRadius)
                {
                    currentlyIs = ZombieState.Follow;
                    zombieAnimator.SetBool("isWalking", true);


                }


                break;

            case ZombieState.Attack:


                break;

            case ZombieState.Follow:
                transform.LookAt(player.transform.position);
                transform.position += transform.forward * walkingSpeed * Time.deltaTime;


                if (Vector3.Distance(player.transform.position, transform.position) < meleeDistance)
                {
                    zombieAnimator.SetBool("IsAttacking", true);
                    currentlyIs = ZombieState.Attack;
                }
                break;

        }


    }
    internal void dieNow()
    {
        zombieAnimator.SetBool("IsDying", true);
        Destroy(gameObject,5);
        currentlyIs = ZombieState.Dying;
    }
}