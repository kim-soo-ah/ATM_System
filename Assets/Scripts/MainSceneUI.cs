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
        Refresh();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // �Աݱ�� �����
    public void Deposit(int value)
    {
        if (value > DataManager.instance.data.cash)
        {
            Debug.Log("�Ա��� �ܾ��� �����մϴ�");
            return;
        }
        DataManager.instance.data.cash -= value;
        DataManager.instance.data.banlance += value;

        Refresh();
    }
    
    //��ݱ�� �����
    public void Withdraw(int value)
    {
        if(value > DataManager.instance.data.banlance)
        {
            Debug.Log("����� �ܾ��� �����մϴ�");
            return;
        }
        DataManager.instance.data.cash += value;
        DataManager.instance.data.banlance -= value;

        Refresh();
    }

    public void Refresh()
    {
        cash.text = DataManager.instance.data.cash.ToString();
        banlance.text = DataManager.instance.data.banlance.ToString();
    }
}
