using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    private Vector2 lastClickPosition;
    private bool moving;
    private Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    // private void Update()
    // {
    //     if (Input.GetMouseButtonDown(1))
    //     {
    //         lastClickPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    //         if (lastClickPosition.y > transform.position.y)
    //         {
    //             animator.SetBool("back", true);
    //         }
    //         else
    //             animator.SetBool("back", false);
    //         moving = true;

    //     }
    //     if (moving && (Vector2)transform.position != lastClickPosition)
    //     {
    //         transform.position = Vector2.MoveTowards(transform.position, lastClickPosition, speed * Time.deltaTime);
    //     }
    // }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position += new Vector3(Input.GetAxisRaw("Horizontal") * Time.deltaTime * speed, Input.GetAxisRaw("Vertical") * Time.deltaTime * speed, 0);
    }
}
