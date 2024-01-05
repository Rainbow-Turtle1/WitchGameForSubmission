using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Inventory.UI
{
    public class UIInventoryPage : MonoBehaviour
    {
        [SerializeField] private UIInventoryItem itemPrefab;
        [SerializeField] private RectTransform contentPanel;
        [SerializeField] private Sprite[] spriteArray;

        List<UIInventoryItem> listOfUIItems = new List<UIInventoryItem>();

        public void InitializeInventoryUI(int inventorysize)
        {
            for (int i = 0; i < inventorysize; i++)
            {
                UIInventoryItem uiItem = Instantiate(itemPrefab, Vector3.zero, Quaternion.identity);

                // Set the parent to contentPanel and maintain local position and scale.
                uiItem.transform.SetParent(contentPanel, false);

                // Ensure the scale is set to (1, 1, 1).
                uiItem.transform.localScale = Vector3.one;

                listOfUIItems.Add(uiItem);
            }
        }
        public void UpdateData(int index, Sprite icon, int quantity, string name)
        {
            if (listOfUIItems.Count > index)
            {
                listOfUIItems[index].SetData(icon, quantity, name);
            }

        }

    }
}
