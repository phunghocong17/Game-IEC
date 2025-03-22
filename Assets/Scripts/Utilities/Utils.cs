﻿using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using URandom = UnityEngine.Random;

public class Utils
{
    public static NormalItem.eNormalType GetRandomNormalTypeExcept(NormalItem.eNormalType[] types)
    {
        List<NormalItem.eNormalType> list = Enum.GetValues(typeof(NormalItem.eNormalType)).Cast<NormalItem.eNormalType>().Except(types).ToList();

        int rnd = URandom.Range(0, list.Count);
        NormalItem.eNormalType result = list[rnd];

        return result;
    }
    public static NormalItem.eNormalType GetRandomNormalType()
    {
        NormalItem.eNormalType[] values = (NormalItem.eNormalType[])Enum.GetValues(typeof(NormalItem.eNormalType));
        int randomIndex = UnityEngine.Random.Range(0, values.Length);
        return values[randomIndex];
    }
   
}
