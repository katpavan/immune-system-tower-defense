using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//https://www.youtube.com/watch?v=6tMwi-hBxnE 
// do it this way with positions 
public class Invader : MonoBehaviour
{
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
    int NextPosIndex;
    Transform NextPos;
    public float speed = 1f;
    public Sprite[] sprites;
    public string[] invaderTypes = new string[] {"virus", "bacteria", "fungi"};
    public string invaderType;
    private SpriteRenderer _spriteRenderer;
    private Rigidbody2D _rigidbody;
    void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _rigidbody = GetComponent<Rigidbody2D>();

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

        NextPos = targetOne;
    }
    // Start is called before the first frame update
    void Start()
    {
        //randomize invader
        //invaderTypes and sprites are in the same order
        int invaderindex = Random.Range(0, invaderTypes.Length);
        invaderType = invaderTypes[invaderindex];
        _spriteRenderer.sprite = sprites[invaderindex];

        //randomize rotation
        // this.transform.eulerAngles = new Vector3(0.0f, 0.0f, Random.value * 90.0f);
    }

    public void MoveGameObject()
    {
        if (this.transform.position == NextPos.position){
            NextPosIndex++;

            if (NextPosIndex == targets.Count) //use Count for a list, use Length for an array
            {
                // NextPosIndex = 0; //if you want to loop

                //really slow function
                //really bad to use this inside an update
                //it looks through every game object in the game
                FindObjectOfType<GameManager>().InvaderReachedThroat();

                Destroy(this.gameObject);
            }else{
                NextPos = targets[NextPosIndex];
            }
        }else{
            transform.position = Vector3.MoveTowards(this.transform.position, NextPos.position, this.speed * Time.deltaTime);
        }
    }

    public void FixedUpdate()
    {
        MoveGameObject();
    }

    // private void OnCollisionEnter2D(Collision2D collision)
    // {
    //     Debug.Log("hello");

    //     if (collision.gameObject.CompareTag("Target"))
    //     {
    //         Debug.Log("collision inv");
    //     }else{
    //         Debug.Log("collision else inv");
    //     }
    // } 
}