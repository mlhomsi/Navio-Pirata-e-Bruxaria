using System;
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

    public event Action Spelldeselect;

    private Target target;
    public void Chant(Effect effect)
    {
        effect.WhenChant(target);
    }

    private void SelectHandler (object sender, InventoryArgs s)
    {
        SpellSelected = s.Spell;
        //print("Alo");
        isSelected = true;
    }
    public void SetTarget (Target targeted)
    {
        target = targeted;
    }
    private void Start()
    {
        //spawner.ClearSpells(spells);
        spawner.AddSpells(gameSettings.ListSpells, gameSettings.Locations);
        selectSpell.Spellselected += SelectHandler;
        Spelldeselect += selectSpell.DeselectSpell;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && SpellSelected && isSelected)
        {
            print("CASTING " + isSelected);
            Chant(SpellSelected.Geteffect);
            isSelected = false;
            SpellSelected = null;
            Spelldeselect?.Invoke();
        }
    }
}
