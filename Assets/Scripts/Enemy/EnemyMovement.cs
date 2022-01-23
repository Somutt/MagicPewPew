using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    
    private GameObject gameManager;
    private GridMovement movementScript;

    void Start()
    {
        gameManager = GameObject.Find("Game Manager");
        movementScript = gameManager.GetComponent<GridMovement>();
    }

    void Update()
    {
        /*ENEMY MOVEMENT*/
        if(Input.GetKeyDown("j")) //Goes to Pos1 when J is pressed
        {
            movementScript.MoveEnemy(1);
        }else if(Input.GetKeyDown("k")) //Goes to Pos2 when K is pressed
        {
            movementScript.MoveEnemy(2);
        }else if(Input.GetKeyDown("l")) //Goes to Pos3 when L is pressed
        {
            movementScript.MoveEnemy(3);
        }


    }
}
