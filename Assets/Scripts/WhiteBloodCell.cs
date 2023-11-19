using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteBloodCell : MonoBehaviour
{
    public AudioManager am;
    public Sprite[] sprites;
    public string[] whiteBloodCellTypes = new string[] {"bcell", "macrophage", "helpert", "neutrophil"};
    private SpriteRenderer _spriteRenderer;
    private Rigidbody2D _rigidbody;
    public float health;

    void TheStart(string w)
    {   
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _rigidbody = GetComponent<Rigidbody2D>();

        if (w == "bcell"){
            _spriteRenderer.sprite = sprites[0];
            health = 5;
            Debug.Log("bcell if statement");
        }else if (w == "macrophage"){
            _spriteRenderer.sprite = sprites[1];
            health = 5;
            Debug.Log("macrophage if statement");
        }else if (w == "helpert"){
            _spriteRenderer.sprite = sprites[2];
            health = 4;
            Debug.Log("helpert if statement");
        }else if (w == "neutrophil"){
            _spriteRenderer.sprite = sprites[3];
            health = 3;
            Debug.Log("neutrophil if statement");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
