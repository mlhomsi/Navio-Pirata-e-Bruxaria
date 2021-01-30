using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Path : MonoBehaviour
{
    [SerializeField]
    private List<Vector2> visitedPoints;
    private int currentTarget;
    private Rigidbody2D rb;
    private Vector2 currentPos;
    [SerializeField]
    private float speed;
    [SerializeField]
    private float waitTime;
    private float timeCounter;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        currentTarget = 0;
    }
    private IEnumerator waitAndWalk()
    {
        Debug.Log("Wait and walk triggered. Wating...");
        yield return new WaitForSeconds(waitTime);
        Debug.Log("Wait time ended");
        if (currentTarget + 1 == visitedPoints.Count)
        {
            currentTarget = 0;
        }
        else currentTarget++;
        yield break;
    }
    void FixedUpdate()
    {
        currentPos = new Vector2(transform.position.x,transform.position.y);
        if (currentPos == visitedPoints[currentTarget])
        {
            if (timeCounter < waitTime)
            {
                timeCounter += Time.deltaTime;
            }
            else
            {
                timeCounter = 0f;
                if (currentTarget + 1 == visitedPoints.Count)
                {
                    currentTarget = 0;
                }
                else currentTarget++;
            }
        }
        else
        {
            Debug.Log("Its else");
            transform.position = Vector2.MoveTowards(transform.position, visitedPoints[currentTarget], speed * Time.deltaTime);
        }

    }
}
