using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellSpawner : MonoBehaviour
{
   public void AddSpells (List<Spell> spells,List<Vector2> locals)
    {
        spells.Shuffle();
        for (int i = 0; i< spells.Count; i++)
        {
            Spell.CreateSpellItem(spells[i],locals[i]);
        }
    }

    public void ClearSpells (List<Spell> spells)
    {
        foreach(Spell s in spells)
        {
            Destroy(s.gameObject);
        }
        spells.Clear();
    }
}
