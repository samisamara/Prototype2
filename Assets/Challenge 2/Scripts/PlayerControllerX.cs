using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    [SerializeField] private float dogTimer = 0.2f;
    private float prevShot;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Time.time - prevShot >= dogTimer)
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                prevShot = Time.time;
            }
            
        }
    }
}
