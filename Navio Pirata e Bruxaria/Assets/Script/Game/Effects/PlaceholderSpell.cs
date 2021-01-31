using System;
using UnityEngine;

[CreateAssetMenu(menuName = "Custom/Spells/Placeholder")]
public class PlaceholderSpell :Effect
{
    public override void WhenChant(Target target)
    {
        Debug.Log("Shazam carai");
    }

}
