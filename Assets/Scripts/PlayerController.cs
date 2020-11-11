using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Sprite playerSprite;

    Rigidbody2D rigidbody;
    CircleCollider2D circleCollider;
    SpriteRenderer spriteRenderer;

    private void Awake()
    {
        rigidbody = this.gameObject.AddComponent<Rigidbody2D>();
        circleCollider = this.gameObject.AddComponent<CircleCollider2D>();
        circleCollider.radius = 0.1f;
        spriteRenderer = this.gameObject.AddComponent<SpriteRenderer>();
    }

    private void Start()
    {
        spriteRenderer.sprite = playerSprite;
        spriteRenderer.color = new Color(1, 0, 0);

        float xVelocity = Random.Range(10.0f, 20.0f);
        float yVelocity = Random.Range(10.0f, 20.0f);
        rigidbody.velocity = new Vector2(xVelocity, yVelocity) * Time.deltaTime;
    }
}
