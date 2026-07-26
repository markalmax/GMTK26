using System.Collections.Generic;
using UnityEngine;
using Unity;
using UnityEngine.SceneManagement;

public class Dungeon : MonoBehaviour
{
    public GameObject roomPrefab;
    public GameObject[] rooms;
    public Vector2 minimumSize,maximumSize;
    [Tooltip("Percent of rooms in grid")][Range(0, 100)]
    public int roomDensity;
    [Tooltip("The space between the center of rooms")]
    public float roomSpace;
    public bool[] dungeon;
    private int n,m;

    public void Start()
    {
        //GenerateDungeon();
    }
    [ContextMenu("GenerateDungeon")]
    public void GenerateDungeon()
    {
        //map size
        n=Random.Range((int)minimumSize.x,(int)maximumSize.x+1);
        m=Random.Range((int)minimumSize.y,(int)maximumSize.y+1);
        Debug.Log(n+"   "+m);
        rooms = new GameObject[n * m];
        dungeon = new bool[n * m];
        for(int i = 0; i < n; i++)
        {
            for(int j=0; j < m; j++)
            {
                if (Random.Range(0, 100)<roomDensity)
                {                 
                    dungeon[pos(i,j)]=true;
                    Debug.Log(pos(i,j));                      
                    rooms[pos(i,j)] = Instantiate(roomPrefab, new Vector3(i*roomSpace,j*roomSpace,0),Quaternion.identity);
                }
                else                     
                {
                    dungeon[pos(i,j)]=false;
                }    
            }
        }
    }
    [ContextMenu("DeleteDungeon")]
    public void DeleteDungeon()
    {
        for(int i = 0; i < n; i++)
        {
            for(int j=0; j < m; j++)
            {
                if(rooms[pos(i,j)]!=null){
                    Destroy(rooms[pos(i,j)]);
                    rooms[pos(i,j)] = null;
                }
            }
        }    
    }
    int pos(int i,int j)=>i*m+j;    
}
