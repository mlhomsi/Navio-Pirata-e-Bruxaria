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
    private void Selectspell(Spell spell)
    {
        if (Spellselected != null)
        {
            Spellselected(this, new InventoryArgs(spell));
        }
    }
    public void Buttonfunct(int i)
    {
        Transform HUD = transform.parent;
        Transform inventoryPanel = HUD.Find("Inventory");

        Transform slot = inventoryPanel.GetChild(i);

        Image image = slot.GetChild(0).GetChild(0).GetComponent<Image>();
        Spell spell = gameSettings.ListSpells.Find(p => p.getSprite == image.sprite);
        Selectspell(spell);

    }
}
