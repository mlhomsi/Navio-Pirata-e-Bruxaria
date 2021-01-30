using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Custom/GameSettings")]

public class GameSettings : ScriptableObject
{
    [SerializeField]
    private List<Spell> spells;
    public List<Spell> ListSpells => spells;

    [SerializeField]
    private List<Vector2> locations;
    public List<Vector2> Locations => locations;

}
