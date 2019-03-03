using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerMovement))]
[RequireComponent(typeof(PlayerAim))]
public class PlayerInputs : MonoBehaviour {

    PlayerMovement move;
    PlayerAim aim;
    Vector2 moveDirection;
    Vector2 aimDirection;
    float xIn;
    float yIn;
    float xAim;
    float yAim;
    [SerializeField] float weight = 1;

    private void Start()
    {
        //get components of other scripts on the player
        move = GetComponent<PlayerMovement>();
        aim = GetComponent<PlayerAim>();
    }

    private void Update()
    {
        //the inputs from the player
        #region Inputs
        xIn = Input.GetAxisRaw("Horizontal");
        yIn = Input.GetAxisRaw("Vertical");
        xAim = Input.GetAxisRaw ("AimHorizontal");
        yAim = Input.GetAxisRaw ("AimVertical");
        #endregion

        //set x and y components of the move direction function
        #region Movement
        moveDirection.x = xIn;
        moveDirection.y = yIn;
        #endregion

        //if the player pressed dodge button then call dodge function in movement script
        #region Dodge
        if (Input.GetButtonDown("Dodge"))
        {
            move.Dodge();
        }
        #endregion

        //if the player is pressing an aim direction set x and y componenets of aimDirection, normalize it, add players velocity * deltaTime then shoot the ball
        #region Shoot

        if (xAim != 0 || yAim != 0)
        {
            aimDirection.x = xAim;
            aimDirection.y = yAim;
            aimDirection = aimDirection.normalized;
            //multiplying this by weight to make the shots be affected by your velocity more
            aimDirection += move.GetRBVelocity () * Time.deltaTime * weight;
            aim.Shoot (aimDirection);
        }
        #endregion
    }

    private void FixedUpdate()
    {
        //move the player
        move.MovePlayer(moveDirection);
        
    }

}
