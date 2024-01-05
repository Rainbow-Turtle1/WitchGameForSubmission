using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Inventory.UI;
using Inventory.Data;

public class AnimateAddItem : MonoBehaviour
{
    [SerializeField] private GameObject addPrefab;
    [SerializeField] private Image spritesIcon;
    [SerializeField] private Sprite coinSprite;
    [SerializeField] private TMP_Text numberAdded;


    private GameObject animationObject; // Declare animationObject at the class level

    public void AddItemAnimation(ItemSO item, int quantity)
    {
        GameObject player = GameObject.Find("PlayerGraphics");

        animationObject = Instantiate(addPrefab, player.transform.position, Quaternion.identity);

        AnimateAddItem animationComponent = animationObject.GetComponent<AnimateAddItem>();

        animationComponent.spritesIcon.sprite = item.ItemIcon;
        animationComponent.numberAdded.text = "+" + quantity;

        Invoke("SelfDestruct", 2f);
    }

    public void AddCoinsAnimation(int quantity)
    {
        GameObject player = GameObject.Find("PlayerGraphics");

        animationObject = Instantiate(addPrefab, player.transform.position, Quaternion.identity);

        AnimateAddItem animationComponent = animationObject.GetComponent<AnimateAddItem>();

        animationComponent.spritesIcon.sprite = coinSprite;
        animationComponent.numberAdded.text = "+" + quantity;

        Invoke("SelfDestruct", 2f);

    }

    private void SelfDestruct()
    {
        // Called after the animation will finish
        DestroyImmediate(animationObject);
        Debug.Log("DESTROYED");
    }
}
