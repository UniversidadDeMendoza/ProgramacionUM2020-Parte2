using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float hp;

    private float HP
    {
        get => hp;
        set
        {
            hp = value;
            if (0 >= hp)
                Destroy(gameObject);
            else
            {
                transform.localScale = Vector3.one * (hp / maxHP);
            }
        }
    }

    [SerializeField]
    private float maxHP = 100;

    private void Start()
    {
        HP = maxHP;
    }

    public void TakeDamage(float damage)
    {
        HP -= damage;
    }
}