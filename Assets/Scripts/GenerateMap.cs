using UnityEngine;

public class GenerateMap
{



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

    private void /*Vector2*/ LookAroundForAvailableSpaces(int[][] _map, int[][] _pos)
    {

    }

}
