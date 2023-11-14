using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvaderSpawner : MonoBehaviour
{
    public Invader invaderPrefab;
    public int spawnAmount = 2;
    
    //movement targets for invader
    private Transform targetOne;
    public Transform[] targetOnes;
    private Transform targetTwo;
    public Transform[] targetTwos;
    private Transform targetThree;
    public Transform[] targetThrees;
    private Transform targetFour;
    public Transform[] targetFours;
    private Transform targetFive;
    public Transform[] targetFives;
    private Transform targetSix;
    public Transform[] targetSixes;
    private Transform targetSeven;
    public Transform[] targetSevens;
    private Transform targetFinal;
    public Transform[] targetFinals;
    public List<Transform> targets = new List<Transform>(); //use a list if you want to manipulate the inside

    // Start is called before the first frame update
    void Start()
    {
        // Quaternion.identity means no rotation            
        Invader invader = Instantiate(this.invaderPrefab, this.transform.position, Quaternion.identity); 
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
