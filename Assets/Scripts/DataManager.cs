using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public Data data;
    public static DataManager instance;
    public void Awake()
    {
        instance = this;
    }
}
