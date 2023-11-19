using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems; // Required for UI event handling
using UnityEngine.UI;

public class GoodGuyHud : MonoBehaviour, IPointerClickHandler
{
    private Camera cam; //need this to use ScreenToWorldPoint to spawn the white blood cells where the mouse gets clicked
    public WhiteBloodCell white_blood_cell_prefab;
    private Image _image_component;
    private Sprite currentSprite;
    public Texture2D cursorArrowBCell;
    public Texture2D cursorArrowMacrophage;
    public Texture2D cursorArrowHelperT;
    public Texture2D cursorArrowNeutrophil;
    public string mouseState; 

    public void Start()
    {
        cam = Camera.main; //need this to use ScreenToWorldPoint to spawn the white blood cells where the mouse gets clicked
    }

    public void placeWhiteBloodCell(Vector3 spawn, string s){
        // Quaternion.identity means no rotation            
        WhiteBloodCell wbc = Instantiate(this.white_blood_cell_prefab, spawn, Quaternion.identity);
        Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
        wbc.SendMessage("TheStart", s);
        mouseState = null;
    }

    public void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Check for left mouse click
        {
            //mousePos is the screen position
            Vector3 mousePos = Input.mousePosition;
            //spawnPos is the world position
            Vector3 spawnPos = cam.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, cam.nearClipPlane + 1)); 

            //something off is with spawnPos because when I use this.transform.position, it's fine 
            if (mouseState == "bcell"){
                placeWhiteBloodCell(spawnPos, "bcell");
            } else if (mouseState == "macrophage"){
                placeWhiteBloodCell(spawnPos, "macrophage");
            } else if (mouseState == "helperT"){
                placeWhiteBloodCell(spawnPos, "helpert");
            } else if (mouseState == "neutrophil"){
                placeWhiteBloodCell(spawnPos, "neutrophil");
            }
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        // Action to perform on click
        var go = eventData.pointerPress;

        if (go.tag == "bcelltag"){
            Cursor.SetCursor(cursorArrowBCell, Vector2.zero, CursorMode.Auto);
            mouseState = "bcell";
        }else if (go.tag == "macrophagetag"){
            Cursor.SetCursor(cursorArrowMacrophage, Vector2.zero, CursorMode.Auto);
            mouseState = "macrophage";
        }else if (go.tag == "helperttag"){
            Cursor.SetCursor(cursorArrowHelperT, Vector2.zero, CursorMode.Auto);
            mouseState = "helperT";
        }else if (go.tag == "neutrophiltag"){
            Cursor.SetCursor(cursorArrowNeutrophil, Vector2.zero, CursorMode.Auto);
            mouseState = "neutrophil";
        }
    }
}
