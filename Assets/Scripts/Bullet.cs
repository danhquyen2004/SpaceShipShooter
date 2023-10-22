using UnityEngine;

public class Bullet : CharacterMove
{
    [SerializeField] protected float timeDespawn = 3;
    protected float timeCount = 0;
    private void Update()
    {
        Move();
        //DestroyBullet();
        DeSpawn();
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
    protected void DeSpawn()
    {
        timeCount += Time.deltaTime;
        if(timeCount >= timeDespawn)
        {
            gameObject.SetActive(false);
            Spawner.Instance.poolObjs.Add(gameObject.transform);
            timeCount = 0;
        }
    }
}
