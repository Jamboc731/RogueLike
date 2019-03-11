using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room
{

    Vector2 worldPos;
    int roomType;
    bool [] doors;

    public Room(Vector2 pos, int type)
    {
        worldPos = pos;
        roomType = type;
    }

    public Vector2 GetPosition ()
    {
        return worldPos;
    }

}
