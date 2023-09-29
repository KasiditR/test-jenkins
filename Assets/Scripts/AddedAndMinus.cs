using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AddedAndMinus : MonoBehaviour
{
    [SerializeField] private int amount;
    [SerializeField] private TMP_Text textAmount;
    [SerializeField] private Button btnIncrease;
    [SerializeField] private Button btnDecrease;
    private void OnEnable()
    {
        btnIncrease.onClick.AddListener(OnClickIncease);
		btnDecrease.onClick.AddListener(OnClickDecease);
	}
    private void OnDisable()
    {
        btnIncrease.onClick.RemoveAllListeners();
		btnDecrease.onClick.RemoveAllListeners();
    }
    private void OnClickIncease()
    {
        amount++;
        HandleTextAmount(amount.ToString());
	}
    private void OnClickDecease()
    {
        amount--;
        HandleTextAmount(amount.ToString());
    }
    private void HandleTextAmount(string value) 
    {
        textAmount.text = value;    
    }
}
