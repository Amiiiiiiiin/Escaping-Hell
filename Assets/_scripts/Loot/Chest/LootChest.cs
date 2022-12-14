using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
[RequireComponent(typeof(SpriteRenderer))]
public class LootChest : MonoBehaviour
{
    public DroptableDataSO DroptableData;

    public BoxCollider2D Collider;

    protected SpriteRenderer _SpriteRenderer;
    public Sprite OpenChest;


    public void Awake()
    {
        Collider = GetComponent<BoxCollider2D>();
        Collider.isTrigger = true;
        _SpriteRenderer = GetComponent<SpriteRenderer>();
        DroptableData.BuildDropTable();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            do
            {
                int x = Random.Range(0, DroptableData.droptable.Count);
                Instantiate(DroptableData.droptable[x], transform.position, transform.rotation);
            }
            while (DroptableData.ChanceForExtraDrops >= Random.Range(0, 101));
            _SpriteRenderer.sprite = OpenChest;
            Collider.enabled = false;
        }
    }
}
