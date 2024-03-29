using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private int _damage = 5;
    [SerializeField] private Entity.DamageDealerType _damageDealerType;
    [SerializeField] private float _lifespan = 10;

    public void Start()
    {
        Destroy(gameObject, _lifespan);
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent<Entity>(out Entity entityComponent))
        {
            entityComponent.DamageEntity(_damage, _damageDealerType);
        }
        Destroy(gameObject);
    }
}
