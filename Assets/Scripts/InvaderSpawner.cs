using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Random=UnityEngine.Random;

public class InvaderSpawner : MonoBehaviour
{    
    public AudioManager am;
    public Invader invaderPrefab;
    public int spawnAmount = 2;
    public float spawnRate = 2.5f;
    
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

    public List<Transform> createRandomTargets(){
        var targets = new List<Transform>(); //use a list if you want to manipulate the inside

        //randomize targets
        targetOne = targetOnes[Random.Range(0, targetOnes.Length)];
        targetTwo = targetTwos[Random.Range(0, targetTwos.Length)];
        targetThree = targetThrees[Random.Range(0, targetThrees.Length)];
        targetFour = targetFours[Random.Range(0, targetFours.Length)];
        targetFive = targetFives[Random.Range(0, targetFives.Length)];
        targetSix = targetSixes[Random.Range(0, targetSixes.Length)];
        targetSeven = targetSevens[Random.Range(0, targetSevens.Length)];
        targetFinal = targetFinals[Random.Range(0, targetFinals.Length)];

        //add randomized targets to the targets list
        targets.Add(targetOne);
        targets.Add(targetTwo);
        targets.Add(targetThree);
        targets.Add(targetFour);
        targets.Add(targetFive);
        targets.Add(targetSix);
        targets.Add(targetSeven);
        targets.Add(targetFinal);

        return targets;
    }

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(Spawn), this.spawnRate, this.spawnRate);
        //play intro voice 
        this.Invoke(() => am.PlayAudio(am.vo5, 1f), 7f);
        //then play music
        this.Invoke(() => am.PlayAudio(am.backgroundMusic, 1f), 20f);
    }

    //it does spawn but it's slow!
    private void Spawn()
    {
        Debug.Log("spawn");
        // Quaternion.identity means no rotation            
        Invader invader = Instantiate(this.invaderPrefab, this.transform.position, Quaternion.identity);
        var t = createRandomTargets(); 
        invader.SendMessage("TheStart", t);    

        // for (int i = 0; i < this.spawnAmount; i++)
        // {
        //     // Quaternion.identity means no rotation            
        //     Invader invader = Instantiate(this.invaderPrefab, this.transform.position, Quaternion.identity);
        //     var t = createRandomTargets(); 
        //     invader.SendMessage("TheStart", t);           
        // }
    }
}

public static class Utility
{
    public static void Invoke(this MonoBehaviour mb, Action f, float delay)
    {
        mb.StartCoroutine(InvokeRoutine(f, delay));
    }
 
    private static IEnumerator InvokeRoutine(System.Action f, float delay)
    {
        yield return new WaitForSeconds(delay);
        f();
    }
}