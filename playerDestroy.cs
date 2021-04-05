using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerDestroy : MonoBehaviour
{
    public GameObject[] alienPrefabs;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider alienPrefabs)
    {
        Destroy(gameObject); //Destroy the gameObject the script is attached to 
        Destroy(alienPrefabs.gameObject);
    }
}
