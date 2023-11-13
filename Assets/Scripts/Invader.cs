using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//https://www.youtube.com/watch?v=6tMwi-hBxnE 
// do it this way with positions 
public class Invader : MonoBehaviour
{
    //movement targets for invader
    private Rigidbody2D targetOne;
    public Rigidbody2D[] targetOnes;
    private Rigidbody2D targetTwo;
    public Rigidbody2D[] targetTwos;
    private Rigidbody2D targetThree;
    public Rigidbody2D[] targetThrees;
    private Rigidbody2D targetFour;
    public Rigidbody2D[] targetFours;
    private Rigidbody2D targetFive;
    public Rigidbody2D[] targetFives;
    private Rigidbody2D targetSix;
    public Rigidbody2D[] targetSixes;
    private Rigidbody2D targetSeven;
    public Rigidbody2D[] targetSevens;
    private Rigidbody2D targetFinal;
    public Rigidbody2D[] targetFinals;
    public List<Rigidbody2D> targets = new List<Rigidbody2D>(); //use a list if you want to manipulate the inside
    int NextPosIndex;
    Rigidbody2D NextPos;
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
    }
    // Start is called before the first frame update
    void Start()
    {
        //randomize target one
        targetOne = targetOnes[Random.Range(0, targetOnes.Length)];
        targetTwo = targetTwos[Random.Range(0, targetTwos.Length)];
        targetThree = targetThrees[Random.Range(0, targetThrees.Length)];
        targetFour = targetFours[Random.Range(0, targetFours.Length)];
        targetFive = targetFives[Random.Range(0, targetFives.Length)];
        targetSix = targetSixes[Random.Range(0, targetSixes.Length)];
        targetSeven = targetSevens[Random.Range(0, targetSevens.Length)];
        targetFinal = targetFinals[Random.Range(0, targetFinals.Length)];
        targets.Add(targetOne);
        targets.Add(targetTwo);
        targets.Add(targetThree);
        targets.Add(targetFour);
        targets.Add(targetFive);
        targets.Add(targetSix);
        targets.Add(targetSeven);
        targets.Add(targetFinal);

        NextPos = targetOne;

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
        if (_rigidbody.position == NextPos.position)
        {
            NextPosIndex++;
            NextPos = targets[NextPosIndex];
            if (NextPosIndex == targets.Count){
                Destroy(this.gameObject);
            }else{
                NextPos = targets[NextPosIndex];
            }
        }else
        {
            _rigidbody.position = Vector3.MoveTowards(_rigidbody.position, NextPos.position, speed * Time.deltaTime);
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