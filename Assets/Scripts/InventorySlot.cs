using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    public Image image;

    public Color selectedColor, notSelectedColor;

    public InventoryManager inventoryManager;

    public void Select()
    {
        image.color = selectedColor;
        inventoryManager.ChangeSelectedSlot(this);
    }

    public void Unselect()
    {
        image.color = notSelectedColor;
    }
}
