using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MainSceneUI : MonoBehaviour
{
    public TMP_Text cash;
    public TMP_Text banlance;
    // Start is called before the first frame update
    void Start()
    {
        cash.text = DataManager.instance.data.cash.ToString();
        banlance.text = DataManager.instance.data.banlance.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
