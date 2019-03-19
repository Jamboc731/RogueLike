using System;
using System.Collections.Generic;
using UnityEngine;

public class GenerateMap : MonoBehaviour
{

    [SerializeField] int worldHalfExtents;
    Room [,] world;
    Vector2 currentPos;
    List<Vector2> takenPositions = new List<Vector2> ();
    Vector2 [] compass = new Vector2 [] { Vector2.up, Vector2.down, Vector2.right, Vector2.left };
    [SerializeField] GameObject cub;
    [SerializeField] int numberOfRooms;

    List<Room> viablePostions = new List<Room> ();

    int roomGenAttempt = 0;
    const int GenAttemptMax = 10;

    #region FirstMethod
    /*
    Vector2 [] directions = new Vector2[] { new Vector2(0, 1), new Vector2(0, -1), new Vector2(1, 0), new Vector2(-1, 0) };

	public Color[][] GetMap(int w, int h)
    {
        Color[][] map = new Color[w][];
        for (int i = 0; i < map.Length; i++)
        {
            map[i] = new Color[h];
        }



        return map;
    }

    private int[][] CreateArray(int w, int h)
    {
        int[][] array = new int[w][];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = new int[h];
        }

        return array;

    }

    private int[][] Propagate(int[][] _map)
    {
        int[][] map = _map;



        return map;
    }

    private int[][] Backtrack(int[][] _map)
    {
        int[][] map = _map;


        return map;
    }

    private Vector2[] LookAroundForAvailableSpaces(int[][] _map, Vector2 _pos)
    {
        List<Vector2> availableSpaces = new List<Vector2>() { };
        int[][] map = _map;
        Vector2 pos = _pos;


        for (int i = 0; i < directions.Length; i++)
        {
            if(map[Mathf.RoundToInt(pos.x + directions[i].x)][Mathf.RoundToInt(pos.y + directions[i].y)] == 0)
            {
                availableSpaces.Add(directions[i]);
            }
        }
        
        return availableSpaces.ToArray();
    }
    */
    #endregion

    private void Start ()
    {
        GeneratWorldArray ();
        PopulateWorld ();
        //if (world [worldHalfExtents, worldHalfExtents] == null)
        //    Debug.Log ("true");
        //else Debug.Log ("False");
        DisplayWorld ();

    }

    private void DisplayWorld ()
    {
        //Debug.Log (takenPositions.Count);
        foreach (Room r in world)
        {
            //Debug.Log (world.Length);
            if (r != null)
                Instantiate (cub, r.GetPosition (), Quaternion.identity);
        }

    }

    private void PopulateWorld ()
    {
        for (int i = 0; i < numberOfRooms; i++)
        {
            int roomcount = 0;
            foreach (Room r in world)
            {
                if (r != null)
                {
                    roomcount++;
                    if (GetNeighbourCount (r) <= 2)
                    {
                        Debug.Log ("correct number of neighbours");
                        viablePostions.Add (r);
                    }
                }
            }
            Debug.Log (i + "viable count " + viablePostions.Count);
            MakeNeighbour (viablePostions[UnityEngine.Random.Range(0, viablePostions.Count - 1)].GetPosition(), 1);
            viablePostions = new List<Room> ();
        }
    }

    #region GetNeighbourCount (2 overloaded methods)
    private int GetNeighbourCount (Room r)
    {

        int count = 0;
        try
        {
            if (world [Mathf.RoundToInt (r.GetPosition ().x + Vector2.up.x), Mathf.RoundToInt (r.GetPosition ().y + Vector2.up.y)] != null)
                count++;
        }
        catch
        {
            Debug.Log ("Out of world range up");
        }
        try
        {
            if (world [Mathf.RoundToInt (r.GetPosition ().x + Vector2.down.x), Mathf.RoundToInt (r.GetPosition ().y + Vector2.down.y)] != null)
                count++;
        }
        catch
        {
            Debug.Log ("Out of world range down");
        }
        try
        {
            if (world [Mathf.RoundToInt (r.GetPosition ().x + Vector2.left.x), Mathf.RoundToInt (r.GetPosition ().y + Vector2.left.y)] != null)
                count++;
        }
        catch
        {
            Debug.Log ("Out of world range left");
        }
        try
        {
            if (world [Mathf.RoundToInt (r.GetPosition ().x + Vector2.right.x), Mathf.RoundToInt (r.GetPosition ().y + Vector2.right.y)] != null)
                count++;
        }
        catch
        {
            Debug.Log ("Out of world range right");
        }
        Debug.Log (count);
        return count;

    }

    private int GetNeighbourCount (Vector2 pos)
    {

        int count = 0;
        try
        {
            if (world [Mathf.RoundToInt (pos.x + Vector2.up.x), Mathf.RoundToInt (pos.y + Vector2.up.y)] != null)
                count++;
        }
        catch
        {
            Debug.Log ("Out of world range up");
        }
        try
        {
            if (world [Mathf.RoundToInt (pos.x + Vector2.down.x), Mathf.RoundToInt (pos.y + Vector2.down.y)] != null)
                count++;                                                                         
        }                                                                                        
        catch                                                                                    
        {                                                                                        
            Debug.Log ("Out of world range down");                                               
        }                                                                                        
        try                                                                                      
        {                                                                                        
            if (world [Mathf.RoundToInt (pos.x + Vector2.left.x), Mathf.RoundToInt (pos.y + Vector2.left.y)] != null)
                count++;
        }
        catch
        {
            Debug.Log ("Out of world range left");
        }
        try
        {
            if (world [Mathf.RoundToInt (pos.x + Vector2.right.x), Mathf.RoundToInt (pos.y + Vector2.right.y)] != null)
                count++;
        }
        catch
        {
            Debug.Log ("Out of world range right");
        }
        Debug.Log (count);
        return count;

    }
    #endregion

    private void GeneratWorldArray ()
    {

        world = new Room [worldHalfExtents * 2, worldHalfExtents * 2];

        world [worldHalfExtents, worldHalfExtents] = new Room (new Vector2 (worldHalfExtents, worldHalfExtents), 0);

        TakePosition (new Vector2 (worldHalfExtents, worldHalfExtents));

    }

    private void TakePosition (Vector2 pos)
    {
        takenPositions.Add (pos);
    }

    private void MakeNeighbour (Vector2 _pos, int type)
    {
        roomGenAttempt = 0;
        RecursiveNeighbourLoop (_pos, type);
    }

    private void RecursiveNeighbourLoop (Vector2 _pos, int type)
    {
        if (roomGenAttempt >= GenAttemptMax) { Debug.Log ("Limit reached"); return; }
        else
        {
            roomGenAttempt++;
            try
            {
                _pos += compass [UnityEngine.Random.Range (0, 4)];
                Vector2 pos = new Vector2 (Mathf.RoundToInt (_pos.x), Mathf.RoundToInt (_pos.y));
                Debug.Log (pos);
                if (!takenPositions.Contains (pos))
                {
                    if (GetNeighbourCount (pos) == 1)
                    {
                        world [Mathf.RoundToInt (pos.x), Mathf.RoundToInt (pos.y)] = new Room (pos, 1);
                        TakePosition (pos);

                    }
                    else RecursiveNeighbourLoop (_pos, type);

                }
                return;
            }
            catch
            {
                RecursiveNeighbourLoop (_pos, type);
                return;
            }

        }

    }

}