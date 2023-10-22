using UnityEngine;

public class BackGroundMove : CharacterMove
{
    [SerializeField] protected float default_y; //1
    [SerializeField] protected float rollback_y; //-19
    private void Update()
    {
        Move();
        RollBack();
    }
    protected override void Move()
    {
        moveVertical = -1;
        movePos.y = transform.position.y + moveSpeed * moveVertical * Time.deltaTime;
        movePos.x = transform.position.x;
        transform.position = movePos;
    }
    protected virtual void RollBack()
    {
        if (transform.position.y >= rollback_y) return;
        transform.position = new Vector3(transform.position.x, default_y, 0);
    }
}
