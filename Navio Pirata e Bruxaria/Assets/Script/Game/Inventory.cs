using System;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private const int Slots = 3;

    private List<Spell> nSpells = new List<Spell>();
    public List<Spell> Storage => nSpells;

    public event EventHandler<InventoryArgs> SpellAdded;

    public void AddSpell(Spell spell)
    {
        if (nSpells.Count < Slots)
        {
            Collider2D collider = spell.GetComponent<Collider2D>();
            if (collider.enabled)
            {
                collider.enabled = false;

                nSpells.Add(spell);

                spell.OnPickup();
            }
            if (SpellAdded != null)
            {
                SpellAdded(this, new InventoryArgs(spell));
            }
        }
    }
    public void RemoveSpell(Spell spell)
    {
        nSpells.Remove(spell);
    }
}