using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[RequireComponent(typeof(Rigidbody2D))] maybe not ?
[RequireComponent(typeof(Collider2D))]
[RequireComponent(typeof(SpriteRenderer))]
public class Spell : MonoBehaviour
{
    //protected GameController controller;
    //protected SpellSpawner spawner => controller.Spawner;

    [SerializeField]
    [Tooltip("Efeito da magia")]
    private Effect effect;
    public Effect Geteffect => effect;

    private SpriteRenderer spriteRenderer;
    public Sprite getSprite => spriteRenderer.sprite;


    public static Spell CreateSpellItem(Spell prefab, Vector3 Pos0 /*,GameController controller*/)
    {
        Spell spell = Instantiate(prefab, Pos0, Quaternion.identity);
        //spell.controller = controller; possibly not needed
        //spell.spriteRenderer.sprite = prefab.spriteRenderer.sprite;
        return spell;
    }
    public void OnPickup()
    {
        //Maybe more things later ?
        gameObject.SetActive(false);
        print("Fui chamado");
    }
    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
}
