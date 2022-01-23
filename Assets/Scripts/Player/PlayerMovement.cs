using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
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
        /*PLAYER MOVEMENT*/
        if(Input.GetKeyDown("a")) //Goes to Pos1 when A is pressed
        {
            movementScript.MovePlayer(1);
        }else if(Input.GetKeyDown("s")) //Goes to Pos2 when S is pressed
        {
            movementScript.MovePlayer(2);
        }else if(Input.GetKeyDown("d")) //Goes to Pos3 when D is pressed
        {
            movementScript.MovePlayer(3);
        }


    }
}
