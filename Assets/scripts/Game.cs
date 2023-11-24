using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    void Start()
    {
        SpawnTetriminos();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnTetriminos()
    {
        Objects newObject = GetComponent<Objects>();

        Instantiate(newObject.GetRandomTetriminos(), new Vector3(-0.5f, 0f, 0f), Quaternion.identity);
    }
}
