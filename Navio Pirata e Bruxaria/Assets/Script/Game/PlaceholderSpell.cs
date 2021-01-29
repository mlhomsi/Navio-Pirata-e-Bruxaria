using System;
using UnityEngine;

[CreateAssetMenu(menuName = "Custom/Spells/Placeholder")]
public class PlaceholderSpell :Effect
{
    public override void WhenChant(GameObject target)
    {
        Console.WriteLine("Alo");
    }

}
