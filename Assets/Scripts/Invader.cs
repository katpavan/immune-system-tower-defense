using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//https://www.youtube.com/watch?v=6tMwi-hBxnE 
// do it this way with positions 
public class Invader : MonoBehaviour
{
    //movement targets for invader
    public List<Transform> targets = new List<Transform>(); //use a list if you want to manipulate the inside
    bool invaderIsLoaded;
    int NextPosIndex;
    Transform NextPos;
    public float speed = 1f;
    public Sprite[] sprites;
    public string[] invaderTypes = new string[] {"virus", "bacteria", "fungi"};
    public string invaderType;
    private SpriteRenderer _spriteRenderer;
    private Rigidbody2D _rigidbody;

    // Start is called before the first frame update, but since this is a prefab, we don't have access to the scene.  
    void TheStart (List<Transform> t) {   // you can't use start. But this is just as good.
        this.targets = t;

        _spriteRenderer = GetComponent<SpriteRenderer>();
        _rigidbody = GetComponent<Rigidbody2D>();
        NextPos = this.targets[0];

        //randomize invader
        //invaderTypes and sprites are in the same order
        int invaderindex = Random.Range(0, invaderTypes.Length);
        invaderType = invaderTypes[invaderindex];
        _spriteRenderer.sprite = sprites[invaderindex];

        //randomize rotation
        this.transform.eulerAngles = new Vector3(0.0f, 0.0f, Random.value * 90.0f);

        //let the FixedUpdate function run the MoveGameObject function
        this.invaderIsLoaded = true;
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
        if (this.invaderIsLoaded){
            MoveGameObject();
        }
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