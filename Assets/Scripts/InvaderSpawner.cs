using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvaderSpawner : MonoBehaviour
{
    public Invader invaderPrefab;
    public float spawnRate = 5.0f;
    public float spawnDistance = 5.0f;
    public int spawnAmount = 2;

    // Start is called before the first frame update
    void Start()
    {
        Invader invader = Instantiate(this.invaderPrefab, this.transform.position, Quaternion.identity); //no rotation            
        // InvokeRepeating(nameof(Spawn), this.spawnRate, this.spawnRate);
    }

    // private void Spawn()
    // {
        // for (int i = 0; i < this.spawnAmount; i++)
        // {
            // Invader invader = Instantiate(this.invaderPrefab, this.transform.position, Quaternion.identity); //no rotation            
        // }
    // }
}
