using UnityEngine;

public class White : MonoBehaviour
{
    #region 練習區域 - 在此區域內練習
    public GameObject Bullet;
    public Transform cannon;
    public AudioSource Aud;
    public AudioClip Auc;

    public void Shoot()
    {
        if (Input.GetKeyDown(Code.Mouse0))
        {
            Bullet.SetActive(true);
        }
    void Update()
        {
            Shoot();
        }

    }
    #endregion

    #region KID 區域 - 不要偷看 @3@
    [Header("移動速度"), Range(0f, 100f)]
    public float speed = 1.5f;

    private Rigidbody2D rig;

    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Move();
    }

    /// <summary>
    /// 移動
    /// </summary>
    private void Move()
    {
        rig.AddForce(transform.right * Input.GetAxisRaw("Horizontal") * speed);
    }
    #endregion
}
