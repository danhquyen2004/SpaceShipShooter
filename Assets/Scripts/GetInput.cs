using UnityEngine;

public class GetInput : MonoBehaviour
{
    protected static GetInput instance;
    [SerializeField] protected float horizontal;
    [SerializeField] protected float vertical;
    [SerializeField] protected float fire1;

    public static GetInput Instance { get { return instance; } }
    public float Horizontal { get { return horizontal; } }
    public float Vertical { get { return vertical; } }
    public float Fire1 { get { return fire1; } }
    private void Awake()
    {
        instance = this;
    }
    private void Update()
    {
        GetInputMove();
        GetInputShoot();
    }
    protected void GetInputMove()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
    }
    protected void GetInputShoot()
    {
        fire1 = Input.GetAxis("Fire1");
    }

}
