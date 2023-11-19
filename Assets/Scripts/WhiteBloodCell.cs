using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteBloodCell : MonoBehaviour
{
    public Sprite[] sprites;
    public string[] whiteBloodCellTypes = new string[] {"bcell", "macrophage", "helpert", "neutrophil"};
    private SpriteRenderer _spriteRenderer;
    private Rigidbody2D _rigidbody;

    void TheStart(string w)
    {   
        Debug.Log(w);
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _rigidbody = GetComponent<Rigidbody2D>();

        if (w == "bcell"){
            _spriteRenderer.sprite = sprites[0];
            Debug.Log("bcell if statement");
        }else if (w == "macrophage"){
            _spriteRenderer.sprite = sprites[1];
            Debug.Log("macrophage if statement");
        }else if (w == "helpert"){
            _spriteRenderer.sprite = sprites[2];
            Debug.Log("helpert if statement");
        }else if (w == "neutrophil"){
            _spriteRenderer.sprite = sprites[3];
            Debug.Log("neutrophil if statement");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
