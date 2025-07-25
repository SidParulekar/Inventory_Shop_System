using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopItem : MonoBehaviour
{
    public Item shopItem;

    public InventoryManager inventoryManager;

    public void GetShopItem()
    {
        bool result = inventoryManager.AddItem(shopItem);

        if(result == true)
        {
            Debug.Log("Item has been added");
        }

        else
        {
            Debug.Log("Cannot add item! No more space in inventory!");
        }
    }



}
