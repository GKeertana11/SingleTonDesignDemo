using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class GameManager1
{
    private static GameManager1 instance;
    private List<GameObject> trashCans = new List<GameObject>();
    public List<GameObject> TrashCans {
        get { return trashCans; }
    }
   

    public static GameManager1 Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new GameManager1();
            }
             return instance;
         }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddTrashCan(GameObject newTrashcan)
    {
        trashCans.Add(newTrashcan);
    }
    public void RemoveTrashCan(GameObject removedCan)
    {
        int index = trashCans.IndexOf(removedCan);
        trashCans.RemoveAt(index);
        Debug.Log("Removed");
        GameObject.Destroy(removedCan);
    }
}
