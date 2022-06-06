using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManaTracker : MonoBehaviour
{
    #region Singleton
    public static ManaTracker instance;

    void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("More than one instance of ManaTracker found");
            return;
        }
        instance = this;
    }
    #endregion

    public int maxMana, currMana;

    Slider manaSlider;

    void Start()
    {
        manaSlider = GetComponent<Slider>();
        manaSlider.maxValue = maxMana;
        manaSlider.value = maxMana;
        currMana = maxMana;
    }

    void Update()
    {

    }

    public void RemoveMana(int amount)
    {
        currMana -= amount;
        manaSlider.value = currMana;
    }

    public void AddMana(int amount)
    {

    }
}
