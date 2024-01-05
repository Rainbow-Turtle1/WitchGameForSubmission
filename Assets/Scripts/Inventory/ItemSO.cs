using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Inventory.Data
{
    [CreateAssetMenu]
    public class ItemSO : ScriptableObject
    {
        public int ID => GetInstanceID();

        [field: SerializeField] public string Name { get; set; }

        [field: SerializeField] public Sprite ItemIcon { get; set; }

    }
}
