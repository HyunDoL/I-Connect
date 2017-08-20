﻿using System;
using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif

[Serializable]
public class TipData
{
    
    public Sprite tip;
}

public class TipSheet : Sheet<TipData>
{
#if UNITY_EDITOR
    [MenuItem("DataSheet/TipSheet")]
    public static void CreateData()
    {
        ScriptableObjectUtillity.CreateAsset<TipSheet>();
    }
#endif
}