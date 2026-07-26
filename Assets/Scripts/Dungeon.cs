using System.Collections.Generic;
using UnityEngine;
using Unity;
using UnityEngine.SceneManagement;

public class Dungeon : MonoBehaviour
{
    public GameObject room;
    public Vector2 minimumSize,maximumSize;
    [Tooltip("Percent of rooms in grid")][Range(0, 100)]
    public int roomDensity;
    [Tooltip("The space between the center of rooms")]
    public float roomSpace;
    public List<List<int>> dungeon;

    public void Start()
    {
        //GenerateDungeon();
    }
    [ContextMenu("GenerateDungeon")]
    public void GenerateDungeon()
    {
        //map size
        int n,m;
        n=Random.Range((int)minimumSize.x,(int)maximumSize.x+1);
        m=Random.Range((int)minimumSize.y,(int)maximumSize.y+1);
        Debug.Log(n+"   "+m);
        //create rooms
        for(int i = 0; i < n; i++)
        {
            for(int j=0; j < m; j++)
            {
                if (Random.Range(0, 100)<roomDensity)
                {

                    //dungeon[i][j]=1;

                    Instantiate(room, new Vector3(i*roomSpace,j*roomSpace,0),Quaternion.identity);
                }
                else
                {
                    //dungeon[i][j]=0;

                }    
            }
        }
    }
}
