using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectSpell : MonoBehaviour
{
    [SerializeField]
    private GameSettings gameSettings;

    public event EventHandler<InventoryArgs> Spellselected;

    private Image slotimage;
    private Inventory inventorystored;
    private Spell spellstored;

    private void Selectspell(Spell spell)
    {
        if (Spellselected != null)
        {
            Spellselected(this, new InventoryArgs(spell));
        }
    }
    public void DeselectSpell()
    {
        slotimage.sprite = null;
        slotimage.enabled = false;
        inventorystored.RemoveSpell(spellstored);
    }
    public void Buttonfunct(int i)
    {
        Transform HUD = transform.parent;
        Transform inventoryPanel = HUD.Find("Inventory");
        Inventory inventory = inventoryPanel.GetComponent<Inventory>();

        Transform slot = inventoryPanel.GetChild(i);

        Image image = slot.GetChild(0).GetChild(0).GetComponent<Image>();

        Spell spell = inventory.Storage.Find(p => p.getSprite == image.sprite);

        if (spell != null)
        {
            Selectspell(spell);
        }
        slotimage = image;
        inventorystored = inventory;
        spellstored = spell;
        
    }
}
