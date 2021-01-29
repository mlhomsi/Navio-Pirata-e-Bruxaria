using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[RequireComponent(typeof(Rigidbody2D))] maybe not ?
[RequireComponent(typeof(Collider2D))]
public class Spell : MonoBehaviour
{
    //protected GameController controller;
    //protected SpellSpawner spawner => controller.Spawner;

    [SerializeField]
    [Tooltip("Efeito da magia")]
    private Effect effect;

    private SpriteRenderer spriteRenderer;
    public SpriteRenderer SpellSprite => spriteRenderer;

    public static Spell CreateSpellItem(Spell prefab, Vector3 Pos0 /*,GameController controller*/)
    {
        Spell spell = Instantiate(prefab, Pos0, Quaternion.identity);
        //spell.controller = controller; possibly not needed
        return spell;
    }
    public void OnPickup()
    {
        //Maybe more things later ?
        gameObject.SetActive(false);
    }
}
