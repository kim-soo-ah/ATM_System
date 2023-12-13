using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MainSceneUI : MonoBehaviour
{
    public TMP_Text cash;
    public TMP_Text banlance;
    public GameObject popupObject;
    public TMP_InputField depositInputField;
    public TMP_InputField withdrawInputField;
    // Start is called before the first frame update
    void Start()
    {
        Refresh();
    }

    

    // 입금기능 만들기
    public void Deposit(int value)
    {
        if (value > DataManager.instance.data.cash)
        {
            return;
        }
        DataManager.instance.data.cash -= value;
        DataManager.instance.data.banlance += value;
        
        Refresh();
    }
    
    //출금기능 만들기
    public void Withdraw(int value)
    {
        if(value > DataManager.instance.data.banlance)
        {
            popupObject.SetActive(true);
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

    public void DepositInput()
    {
        Deposit(int.Parse(depositInputField.text));
    }

    public void WithdrawInput()
    {
        Withdraw(int.Parse(withdrawInputField.text));
    }
}
