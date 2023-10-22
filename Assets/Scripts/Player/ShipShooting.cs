using UnityEngine;

public class ShipShooting : MonoBehaviour
{
    [SerializeField] protected GameObject bullet;
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
        Instantiate(bullet, transform.position, Quaternion.identity);
        shootTime = 0;
    }



}
