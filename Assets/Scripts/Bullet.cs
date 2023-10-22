using UnityEngine;

public class Bullet : CharacterMove
{

    private void Update()
    {
        Move();
        DestroyBullet();
    }
    protected override void Move()
    {
        moveVertical = 1;
        movePos.y = transform.position.y + moveSpeed * moveVertical * Time.deltaTime;
        movePos.x = transform.position.x;
        transform.position = movePos;
    }
    protected void DestroyBullet()
    {
        Destroy(gameObject,3);
    }
}
