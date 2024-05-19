using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;

    SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"))).normalized * speed * Time.deltaTime;

        spriteRenderer.flipX = (Input.mousePosition.x < Screen.width / 2);
    }
}
