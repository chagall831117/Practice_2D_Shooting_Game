using UnityEngine;
using UnityEngine.UI;

public class Black : MonoBehaviour
{
    #region 練習區域 - 在此區域內練習

    public int Hp = 10;
    public Text HpText;
    public AudioSource Aud;
    public AudioClip Auc;
    public GameObject HPT;

    public void Hurt()
    {
        Hp -= 1;
        HpText.text = Hp +"";//運用空字串將Hp轉成string
        Aud.PlayOneShot(Auc);
        if (Hp <=0)
        {
            Death();
        }
    }
    public void Death()
    {
        gameObject.SetActive(false);
        HPT.SetActive(false);


    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "子彈")
        {
            Hurt();
        }
        print(collision.gameObject.tag);
    }
    #endregion
}
