using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Inventory.UI
{
    public class UIInventoryItem : MonoBehaviour
    {
        [SerializeField] private Image itemIcon;
        [SerializeField] private TMP_Text numberText;
        [SerializeField] private TMP_Text nameText;

        public void Awake()
        {
            ResetData();
        }
        public void ResetData()
        {
            this.itemIcon.gameObject.SetActive(false);
        }
        public void SetData(Sprite sprite, int quantity, string Name)
        {
            this.itemIcon.gameObject.SetActive(true);
            this.itemIcon.sprite = sprite;
            this.numberText.text = "X" + quantity;
            this.nameText.text = Name;
        }


    }
}
