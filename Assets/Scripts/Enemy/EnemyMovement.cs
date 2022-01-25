using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    
    private GameObject gameManager;
    private GridMovement movementScript;
    private float cooldownEnemy = 1.5f;
    private float nextEnemyAction;

    void Start()
    {
        gameManager = GameObject.Find("Game Manager");
        movementScript = gameManager.GetComponent<GridMovement>();
    }

    void Update()
    {
        EnemyIA();
    }

    //IA

    void EnemyIA()
    {
        if(Time.time >= nextEnemyAction)
        {
            int rng = Random.Range(1, 2); //To him be able to shoot,
                                          //just change the 2 to 3;
            if(rng == 1) {EnemyMove();}
            else if (rng == 2) {EnemyShoot();}

            nextEnemyAction = Time.time + cooldownEnemy;
        }
    }

    void EnemyShoot()
    {
        Debug.Log("Enemy shot.");
    }

    void EnemyMove()
    {
        int rng = Random.Range(1, 4);

        /*ENEMY MOVEMENT*/
        if(rng == 1) //Goes to Pos1
        {
            movementScript.MoveEnemy(1);
        }else if(rng == 2) //Goes to Pos2
        {
            movementScript.MoveEnemy(2);
        }else if(rng == 3) //Goes to Pos3
        {
            movementScript.MoveEnemy(3);
        }
    }
}
