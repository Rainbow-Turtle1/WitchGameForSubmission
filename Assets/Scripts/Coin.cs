using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int value;

    [SerializeField] private Animator animator;
    //[SerializeField] private Animator UIanimator;
    [SerializeField] private AnimateAddItem animateAddItemPrefab;

    void Start()
    {
        value = Random.Range(4, 13);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Coin Collected! +" + value.ToString());

            animator.SetTrigger("Collected");
            //UIanimator.SetTrigger("Collected");

            CoinCounter.instance.IncreaseCoins(value);

            animateAddItemPrefab.AddCoinsAnimation(value);

            Invoke("DestroyCoin", 1f);
        }
    }

    void DestroyCoin()
    {
        Destroy(gameObject);
    }
}
