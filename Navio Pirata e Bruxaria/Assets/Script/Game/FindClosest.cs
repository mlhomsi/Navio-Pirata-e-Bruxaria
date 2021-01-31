using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindClosest : MonoBehaviour
{
    [SerializeField]
    private float rangeDistance;

    [SerializeField]
    private GameController gameController;


    void Update()
    {
        FindClosestEnemy();
    }
    
    void FindClosestEnemy()
    {
        float distanceToClosestEnemy = Mathf.Infinity;
        Target closestEnemy = null;
        Target[] allEnemies = GameObject.FindObjectsOfType<Target>();

        foreach (Target currentEnemy in allEnemies)
        {
            float distanceToEnemy = (currentEnemy.transform.position - this.transform.position).sqrMagnitude;
            if (distanceToEnemy < distanceToClosestEnemy)
            {
                distanceToClosestEnemy = distanceToEnemy;
                closestEnemy = currentEnemy;
            }
        }
        if (distanceToClosestEnemy <= rangeDistance)
        {
            Debug.DrawLine(this.transform.position, closestEnemy.transform.position, Color.blue);
            gameController.SetTarget(closestEnemy);
        }
    }

}