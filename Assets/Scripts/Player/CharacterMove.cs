using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    protected Vector3 movePos;
    [SerializeField] protected float moveSpeed;

    protected float moveHorizontal;
    protected float moveVertical;
    private void Update()
    {
        Move();
    }
    protected virtual void Move()
    {
        moveHorizontal = GetInput.Instance.Horizontal;
        moveVertical = GetInput.Instance.Vertical;
        movePos.x = transform.parent.position.x + moveSpeed *moveHorizontal *Time.deltaTime;
        movePos.y = transform.parent.position.y + moveSpeed * moveVertical * Time.deltaTime;
        transform.parent.position = movePos;
    }
}
