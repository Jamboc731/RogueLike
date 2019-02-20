using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerMovement))]
[RequireComponent(typeof(PlayerAim))]
public class PlayerInputs : MonoBehaviour {

    PlayerMovement move;
    PlayerAim aim;
    Vector2 moveDirection;
    float xIn;
    float yIn;

    private void Start()
    {
        move = GetComponent<PlayerMovement>();
        aim = GetComponent<PlayerAim>();
    }

    private void Update()
    {
        #region Movement
        xIn = Input.GetAxisRaw("Horizontal");
        yIn = Input.GetAxisRaw("Vertical");

        moveDirection.x = xIn;
        moveDirection.y = yIn;
        #endregion

        #region Dodge
        if (Input.GetButtonDown("Dodge"))
        {
            move.Dodge();
        }
        #endregion

        #region Shoot
        if (Input.GetButton("Shoot"))
        {
            
        }
        #endregion
    }

    private void FixedUpdate()
    {
        move.MovePlayer(moveDirection);
        
    }

}
