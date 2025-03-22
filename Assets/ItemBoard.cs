using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBoard : MonoBehaviour
{
    public SkinItem skinData; 

    void Start()
    {
        if (skinData != null)
        {
            SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
            if (spriteRenderer != null && skinData.skinIcon != null)
            {
                spriteRenderer.sprite = skinData.skinIcon;
            }
        }
    }
}
