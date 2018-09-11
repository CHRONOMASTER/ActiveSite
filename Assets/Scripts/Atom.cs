using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atom {

    //static Dictionary<string, Properties> atomList;
    //struct Properties
    //{
        public string atomName;
        public uint   atomicNumber;
        public string symbol;
        public float radiiWaals;
        public float covalentSingle;
        public float covalentTripple;
        public float metallic;
    //}

    //static Atom()
    //{
        //atomList = new Dictionary<string, Properties>();
        //JsonUtility.FromJson<Properties>(Resources.Load<TextAsset>("/Resources/DisplayAtoms").text);
    //}

        
    public string GetName()
    {
        return atomName;
    }

    public string GetSymbol()
    {
        return symbol;
    }

    public uint GetElectronCount()
    {
        return atomicNumber;
    }

    public float GetRadiiWaals()
    {
        return radiiWaals;
    }
}
