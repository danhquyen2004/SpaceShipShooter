using System;
using Unity.VisualScripting;
using UnityEngine;

public class ShipShooting : MonoBehaviour
{
    //[SerializeField] protected GameObject bullet;
    [SerializeField] protected float shootDelay;
    protected float shootTime = 0;

    private void Update()
    {
        Shooting();
    }
    protected virtual void Shooting()
    {
        shootTime += Time.deltaTime;
        if (shootTime < shootDelay) return;
        if (GetInput.Instance.Fire1 != 1) return;
        GameObject newBullet = Spawner.Instance.Spawn("Bullet_1(Clone)",transform.position, Quaternion.identity).gameObject;
        newBullet.SetActive(true);
        shootTime = 0;
    }



}
