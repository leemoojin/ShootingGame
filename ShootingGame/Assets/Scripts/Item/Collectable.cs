using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    private ICollectableBehaviour collectableBehaviour;

    private void Awake()
    {
        collectableBehaviour = GetComponent<ICollectableBehaviour>();
    }

    private void Update()
    {
        if (gameObject.transform.position.y < -6)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var player = collision.GetComponent<PlayerMovement>();

       if(player != null )
        {
            collectableBehaviour.OnCollected(player.gameObject);
            Destroy(gameObject);
        }

        
    }
}
