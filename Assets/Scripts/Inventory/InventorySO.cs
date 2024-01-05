using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Inventory.Data
{
    [CreateAssetMenu]
    public class InventorySO : ScriptableObject
    {

        [SerializeField] private List<InventoryItem> inventory;

        [SerializeField] private AnimateAddItem animateAddItemPrefab;

        [field: SerializeField] public int Size { get; private set; } = 50;

        public event Action<Dictionary<int, InventoryItem>> OnInventoryUpdated;

        public void Initialize()
        {
            inventory = new List<InventoryItem>();
            for (int i = 0; i < Size; i++)
            {
                inventory.Add(InventoryItem.EmptyItem());
            }
        }

        public void AddItem(ItemSO item, int quantity)
        {
            if (IsInventoryFull())
            {
                InventoryIncreaseSize(); // increase inventory size if the inventory is full
            }

            if (!AddStackableItem(item, quantity))
            {
                AddNewItem(item, quantity);
            }

            animateAddItemPrefab.AddItemAnimation(item, quantity);
        }

        private void AddNewItem(ItemSO item, int quantity)
        {
            InventoryItem newItem = new InventoryItem
            {
                item = item,
                quantity = quantity
            };

            for (int i = 0; i < inventory.Count; i++)
            {
                if (inventory[i].IsEmpty)
                {
                    inventory[i] = newItem;
                    InformAboutChange();
                    return; // Return after adding the item to the first available slot
                }
            }
        }


        private void InventoryIncreaseSize()
        {
            //increase size of inventory
            Debug.Log("Should increase inventory size");
            return;
        }

        private bool IsInventoryFull() => inventory.Where(AddItem => AddItem.IsEmpty).Any() == false;

        private bool AddStackableItem(ItemSO item, int quantity)
        {
            for (int i = 0; i < inventory.Count; i++)
            {
                if (!inventory[i].IsEmpty && inventory[i].item.ID == item.ID)
                {
                    inventory[i] = inventory[i].ChangeQuantity(inventory[i].quantity + quantity);
                    InformAboutChange();
                    return true; // Item added successfully
                }
            }
            return false; // Item not added
        }



        public Dictionary<int, InventoryItem> GetInventoryState()
        {
            Dictionary<int, InventoryItem> returnValue = new Dictionary<int, InventoryItem>();
            for (int i = 0; i < inventory.Count; i++)
            {
                if (inventory[i].IsEmpty) continue;
                returnValue[i] = inventory[i];
            }
            return returnValue;
        }


        private void InformAboutChange()
        {
            OnInventoryUpdated?.Invoke(GetInventoryState());
        }
    }

    [Serializable]
    public struct InventoryItem
    {
        public int quantity;
        public ItemSO item;
        public bool IsEmpty => item == null;

        public InventoryItem ChangeQuantity(int newQuantity)
        {
            return new InventoryItem
            {
                item = this.item,
                quantity = newQuantity,
            };
        }
        public static InventoryItem EmptyItem()
        => new InventoryItem
        {
            item = null,
            quantity = 0,
        };
    }
}
