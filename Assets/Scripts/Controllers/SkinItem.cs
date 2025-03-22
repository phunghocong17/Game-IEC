using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewSkinItem", menuName = "Skin Item")]
public class SkinItem : ScriptableObject
{
    public string skinName; 
    public Sprite skinIcon; 
    public GameObject skinPrefab; 
}