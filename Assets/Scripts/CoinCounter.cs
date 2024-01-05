using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinCounter : MonoBehaviour
{
    public static CoinCounter instance;

    public TMP_Text coinText;
    public int currentCoins = 0;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        currentCoins = PlayerPrefs.GetInt("PlayerStoredCoins", 0);
        coinText.text = FormatForDisplay(currentCoins);
    }

    public void IncreaseCoins(int number){
        currentCoins += number;
        SaveCoins();
        coinText.text = FormatForDisplay(currentCoins);
    }

    public void DecreaseCoings(int number){
        currentCoins -= number;
        SaveCoins();
        coinText.text = FormatForDisplay(currentCoins);
    }

    public string FormatForDisplay(int number)
    {
        string formattedNumber = string.Format("{0:n0}", number);

        if (formattedNumber.Length < 7)
        {
            formattedNumber = formattedNumber.PadLeft(10, '0');
        }
        return formattedNumber;
    }

    public void SaveCoins(){
        PlayerPrefs.SetInt("PlayerStoredCoins", currentCoins);
    }
}
