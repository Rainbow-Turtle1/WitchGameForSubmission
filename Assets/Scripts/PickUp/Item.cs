using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Inventory.Data;


public class Item : MonoBehaviour
{
    [field: SerializeField]
    public ItemSO ItemObject { get; private set; }

    [field: SerializeField]
    public int Quantity { get; set; } = 1;

    [SerializeField] private bool isPackage = true;

    [SerializeField] private Sprite packageSprite;

    private float animationDuration = 0.2f;

    private void Start()
    {
        if (isPackage)
        {
            GetComponent<SpriteRenderer>().sprite = packageSprite;
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
        else
        {
            GetComponent<SpriteRenderer>().sprite = ItemObject.ItemIcon;
            transform.localScale = new Vector3(0.5f, 0.5f, 1f);
        }
    }

    public void DestroyThisItem()
    {
        Debug.Log("item.DestroyThisItem Running");
        GetComponent<Collider2D>().enabled = false;
        StartCoroutine(PickUpItem());
    }

    private IEnumerator PickUpItem()
    {
        Debug.Log("item.PickUpItem Running");
        Vector3 startScale = transform.localScale;
        Vector3 endScale = Vector3.zero;
        float currentTime = 0;
        while (currentTime < animationDuration)
        {
            currentTime += Time.deltaTime;
            transform.localScale = Vector3.Lerp(startScale, endScale, currentTime / animationDuration);
            yield return null;
        }
        Destroy(gameObject);
    }


}
