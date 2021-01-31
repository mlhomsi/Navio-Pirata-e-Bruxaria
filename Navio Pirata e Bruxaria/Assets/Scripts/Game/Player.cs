using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField]
    private float speed = 5f;
    Vector2 direction;

    public Animator PlayerAnim;

    [SerializeField]
    private Inventory inventory;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //inventory = GetComponent<Inventory>();
    }

    // Update is called once per frame
    void Update()
    {
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.y = Input.GetAxisRaw("Vertical");

    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + direction * speed * Time.fixedDeltaTime);

        if(direction.x != 0 || direction.y != 0)
        {
            if(direction.x >0)
            {
                PlayerAnim.SetBool("Idle", false);
                PlayerAnim.Play("PlayerWalkDir");
            }else 
            {
                PlayerAnim.SetBool("Idle", false);
                PlayerAnim.Play("PlayerWalkFront");
            }

        } else PlayerAnim.SetBool("Idle", true);
    }

    private void OnTriggerEnter2D (Collider2D collider2D)
    {
        Spell spell = collider2D.GetComponent<Spell>();
        if (spell != null)
        {
            inventory.AddSpell(spell);
        }
    }
}
