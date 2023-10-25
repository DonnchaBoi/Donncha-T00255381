using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieControl : MonoBehaviour
{
    Animator zombieAnimator;
    enum ZombieState {Idle, Attack, Follow }
    ZombieState currentlyIs = ZombieState.Idle;

    // Start is called before the first frame update
    void Start()
    {
        zombieAnimator = GetComponent<Animator>();
        player = FindObjectOfType
    }

    // Update is called once per frame
    void Update()
    {
    

    }
}
