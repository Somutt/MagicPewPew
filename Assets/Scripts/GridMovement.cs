using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridMovement : MonoBehaviour
{
    private GameObject player;
    private GameObject enemy;
    private Vector3 pPos1, pPos2, pPos3, ePos1, ePos2, ePos3;
    public GameObject movementPoint;
    void Start()
    {
        //Search for the Player and Enemy GO
        player = GameObject.Find("Player");
        enemy = GameObject.FindGameObjectWithTag("Enemy");

        //Getting exactly one-third of the screen width
        Vector2 edgeVector = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));
        float widthThird = (edgeVector.x * 2)/3;
        float heightThird = (edgeVector.y * 2)/3;

        //Set the positions where the Player and the
        //Enemy can go using the previous variable
        pPos1 = new Vector3(-widthThird, -heightThird-1f);
        pPos2 = new Vector3(          0, -heightThird-1f);
        pPos3 = new Vector3( widthThird, -heightThird-1f);
        ePos1 = new Vector3(-widthThird,  heightThird-1f);
        ePos2 = new Vector3(          0,  heightThird-1f);
        ePos3 = new Vector3( widthThird,  heightThird-1f);

        //Instantiate the Movement Points
        Instantiate(movementPoint, ePos1, Quaternion.identity);
        Instantiate(movementPoint, ePos2, Quaternion.identity);
        Instantiate(movementPoint, ePos3, Quaternion.identity);
        Instantiate(movementPoint, pPos1, Quaternion.identity);
        Instantiate(movementPoint, pPos2, Quaternion.identity);
        Instantiate(movementPoint, pPos3, Quaternion.identity);

        //Player and Enemy start in the middle
        //of the screen (aka middle position);
        player.transform.position = pPos2;
        enemy.transform.position = ePos2;
    }

    void Update()
    {
        //Try again to find the Enemy GO if this die
        if(enemy == null)
        {
            enemy = GameObject.FindGameObjectWithTag("Enemy");
        }

        //Show a Error Message on the console
        //while the Enemy GO is not found
        if(enemy == null) Debug.Log("Object 'Enemy' not found.");
    }

    public void MovePlayer(int n) //Player movement function
    {
        switch (n)
        {
            case 1:
                player.transform.position = pPos1;
                break;
            case 2:
                player.transform.position = pPos2;
                break;
            case 3:
                player.transform.position = pPos3;
                break;
        }
    }

    public void MoveEnemy(int n) //Enemy movement function
    {
        switch (n)
        {
            case 1:
                enemy.transform.position = ePos1;
                break;
            case 2:
                enemy.transform.position = ePos2;
                break;
            case 3:
                enemy.transform.position = ePos3;
                break;
        }
    }
}
