using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private Projectile projectilePrefab = null;

    [SerializeField]
    private Transform projectileParent = null;

    private string projectilesParentsName = "Projectiles";

    private Transform GetProjectilesParent
    {
        get
        {
            if (null == projectileParent)
            {
                var projectilesParentGO = GameObject.Find(projectilesParentsName);

                if (null == projectilesParentGO)
                    projectileParent = new GameObject(projectilesParentsName).transform;
                else
                    projectileParent = projectilesParentGO.transform;
            }

            return projectileParent;
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        Instantiate(projectilePrefab, GetProjectilesParent);
    }
}