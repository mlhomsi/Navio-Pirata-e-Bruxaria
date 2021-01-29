using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    [SerializeField]
    private Inventory inventory;

    private void Start()
    {
        inventory.SpellAdded += InventoryAdding;
    }

    private void InventoryAdding (object sender,InventoryArgs target)
    {
        Transform inventoryPanel = transform.Find("InventoryPanel");
        foreach(Transform slot in inventoryPanel)
        {
            Image image = slot.GetChild(0).GetChild(0).GetComponent<Image>();

            if (!image.enabled)
            {
                image.enabled = true;
                image.sprite = target.Spell.SpellSprite.sprite;

                break;
            }

        }
    }
}
