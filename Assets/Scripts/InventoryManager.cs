using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public int maxSlotSpace = 5;

    public InventorySlot[] inventorySlots;

    public GameObject inventoryItemPrefab;

    public bool AddItem(Item item)
    {
        for (int i = 0; i < inventorySlots.Length; i++) // For stacking
        {
            InventorySlot slot = inventorySlots[i];
            InventoryItem itemInSlot = slot.GetComponentInChildren<InventoryItem>();

            if (itemInSlot != null && itemInSlot.item == item && itemInSlot.count < maxSlotSpace && itemInSlot.item.stackable == true)
            {
                itemInSlot.count++;
                itemInSlot.RefreshCount();
                return true;
            }

        }

        for (int i=0; i<inventorySlots.Length; i++) // For finding free slots
        { 
            InventorySlot slot = inventorySlots[i]; 
            InventoryItem itemInSlot = slot.GetComponentInChildren<InventoryItem>();

            if(itemInSlot == null) 
            {
                SpawnNewItem(item, slot);
                return true;
            }

        }

        return false;

    }

    private void SpawnNewItem(Item item, InventorySlot slot)
    {
        GameObject newItem = Instantiate(inventoryItemPrefab, slot.transform);
        InventoryItem inventoryItem = newItem.GetComponent<InventoryItem>();

        inventoryItem.InitializeItem(item);
    }
}
