using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicShot : Shots
{

    Vector2 dir;

    public void SetDir(Vector2 _dir)
    {
        dir = _dir;
    }

    private void Update ()
    {
        Move (dir);
    }

}
