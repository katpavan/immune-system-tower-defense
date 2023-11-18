using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems; // Required for UI event handling
using UnityEngine.UI;

public class GoodGuyHud : MonoBehaviour, IPointerClickHandler
{
    private Image _image_component;
    private Sprite currentSprite;
    public Texture2D cursorArrowBCell;
    public Texture2D cursorArrowMacrophage;
    public Texture2D cursorArrowHelperT;
    public Texture2D cursorArrowNeutrophil;

    public void Start()
    {
        // newCursorArrowBCell = new Texture2D(cursorArrowBCell.width, cursorArrowBCell.height, TextureFormat.RGBA32, false);
        // Color[] pixels = cursorArrowBCell.GetPixels(); //ArgumentException: Texture2D.GetPixels: texture data is either not readable, corrupted or does not exist. (Texture 'b cell')
        // newCursorArrowBCell.SetPixels(pixels); 
        // newCursorArrowBCell.Apply();
    }

    // public void Awake()
    // {
    //     _image_component = GetComponent<Image>(); //this grabs the rigid body 2d component from the player game object

    //     currentSprite = _image_component.sprite;
    //     cursorArrow = new Texture2D((int)currentSprite.rect.width, (int)currentSprite.rect.height);
    // }

    // public void Update()
    // {
    //     if (Input.GetMouseButtonDown(0)) // Check for left mouse click
    //     {
    //         Debug.Log("left mouse button clicked"); 
    //         /*
    //             1. spawn the good guy wherever was clicked
    //             2. change the cursor to a hand cursor 
    //         */
    //     }
    // }

    public void OnPointerClick(PointerEventData eventData)
    {
        // Action to perform on click
        var go = eventData.pointerPress;

        if (go.tag == "bcelltag"){
            Cursor.SetCursor(cursorArrowBCell, Vector2.zero, CursorMode.Auto);
        }else if (go.tag == "macrophagetag"){
            Cursor.SetCursor(cursorArrowMacrophage, Vector2.zero, CursorMode.Auto);
        }else if (go.tag == "helperttag"){
            Cursor.SetCursor(cursorArrowHelperT, Vector2.zero, CursorMode.Auto);
        }else if (go.tag == "neutrophiltag"){
            Cursor.SetCursor(cursorArrowNeutrophil, Vector2.zero, CursorMode.Auto);
        }
    }
    
    // Cursor.SetCursor(null, Vector2.zero, cursorMode);

}
