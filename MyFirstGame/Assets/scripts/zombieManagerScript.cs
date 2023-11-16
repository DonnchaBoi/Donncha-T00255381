using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombieManagerScript : MonoBehaviour
{
    public Transform zombieCloneTemplate;

    int numberOfZombies = 30;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numberOfZombies; i++) 
        {
            Vector3 position = new Vector3(
                Random.Range(16f, 13.5f),
                  0f,
            Random.Range(-6f, 6f));

            Instantiate(zombieCloneTemplate, position, Quaternion.identity);
        }
        for (int i = 0; i < numberOfZombies; i++)
        {
            Vector3 position = new Vector3(
                Random.Range(18f, -15f),
                  0f,
            Random.Range(30f, 28));

            Instantiate(zombieCloneTemplate, position, Quaternion.identity);
        }
        for (int i = 0; i < numberOfZombies; i++)
        {
            Vector3 position = new Vector3(
                Random.Range(-15f, -12f),
                  0f,
            Random.Range(30f, 4));

            Instantiate(zombieCloneTemplate, position, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
 
    }
}
