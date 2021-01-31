using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryArgs : EventArgs
{
   public InventoryArgs (Spell spell)
    {
        Spell = spell;
    }
    public Spell Spell;

    //QUE COISA HORROROSA É ESSA Q EU CRIEI DEUS.
}
