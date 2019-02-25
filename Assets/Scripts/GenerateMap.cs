using System.Collections.Generic;
using UnityEngine;

public class GenerateMap
{

    Vector2[] directions = new Vector2[] { new Vector2(0, 1), new Vector2(0, -1), new Vector2(1, 0), new Vector2(-1, 0) };

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

}
