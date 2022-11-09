using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private Texture2D cursorTexture = null;

    private void Start()
    {
        SetcursorIcon();
    }

    private void SetcursorIcon()
    {
        Cursor.SetCursor(cursorTexture, new Vector2(cursorTexture.width / 2f, 
            cursorTexture.height / 2f), CursorMode.Auto);
    }
}
