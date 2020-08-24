using System;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField]
    private FloatValue speed = null, damage = null;

    [SerializeField]
    private CurveValue motion;

    private float aliveFor = 0;

    private void Update()
    {
        aliveFor += Time.deltaTime;
        
        transform.position += Vector3.forward * (speed.value * motion.value.Evaluate(aliveFor) * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        var possibleEnemy = other.GetComponent<Enemy>();

        if (null != possibleEnemy)
            possibleEnemy.TakeDamage(damage.value);

        Destroy(gameObject);
    }
}