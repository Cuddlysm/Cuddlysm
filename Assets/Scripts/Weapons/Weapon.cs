using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    public abstract void Attack();
    
    public abstract void StopAttack();
    
    public abstract void StartReloading(bool forceReload = false);
}
