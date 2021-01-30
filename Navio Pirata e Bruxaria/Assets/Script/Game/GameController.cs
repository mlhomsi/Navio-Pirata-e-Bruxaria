using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField]
    private GameSettings gameSettings;

    [SerializeField]
    private SpellSpawner spawner;

    [SerializeField]
    SelectSpell selectSpell;

    [SerializeField]
    public Spell SpellSelected; //dps trocar pra Private

    public bool isSelected = false;

    public void Chant(Effect effect)
    {
        effect.WhenChant(this.gameObject);
    }

    private void SelectHandler (object sender, InventoryArgs s)
    {
        SpellSelected = s.Spell;
        isSelected = true;
    }
    private void Start()
    {
        //spawner.ClearSpells(spells);
        spawner.AddSpells(gameSettings.ListSpells, gameSettings.Locations);
        selectSpell.Spellselected += SelectHandler;
    }
    private void Update()
    {
        if (isSelected & Input.GetKeyDown(KeyCode.Space))
        {
            Chant(SpellSelected.Geteffect);
            isSelected = false;
        }
    }
}
