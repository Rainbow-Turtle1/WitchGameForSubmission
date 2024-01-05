using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Inventory.Data;

public class PickUp : MonoBehaviour
{
    [SerializeField] private InventorySO inventoryData;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("TriggerEntered");
        Item colidedItem = other.GetComponent<Item>();
        if (colidedItem != null)
        {
            inventoryData.AddItem(colidedItem.ItemObject, colidedItem.Quantity);
            colidedItem.DestroyThisItem();
        }

    }

}
