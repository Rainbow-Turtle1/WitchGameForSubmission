using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Inventory.UI;
using Inventory.Data;

namespace Inventory
{
    public class InventoryUIManager : MonoBehaviour
    {
        [SerializeField] private UIInventoryPage inventoryUI;
        [SerializeField] private InventorySO inventoryData;

        private void Start()
        {
            inventoryUI.InitializeInventoryUI(inventoryData.Size);
            //IF !save file THEN
            //  inventoryData.Initialize();
            //  Debug.Log("initialized inventory");
            //ELSE 
            //  inventoryData.LoadData();
            //  Debug.Log("initialized inventory");

        }
        private void Update()
        {
            if (inventoryUI.isActiveAndEnabled == true)
            {
                foreach (var item in inventoryData.GetInventoryState())
                {
                    inventoryUI.UpdateData(
                    item.Key,
                    item.Value.item.ItemIcon,
                    item.Value.quantity,
                    item.Value.item.Name);
                }

            }
        }
    }
}