using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public GameObject prefab;
    GameObject temp;// Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit Hitinfo;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray.origin, ray.direction, out Hitinfo))
            {
                temp = Instantiate(prefab, Hitinfo.point, Quaternion.identity);
                GameManager1.Instance.AddTrashCan(temp);
                Debug.Log(GameManager1.Instance.TrashCans.Count);

}
        }
        if (Input.GetMouseButtonDown(1))
        {
            GameManager1.Instance.RemoveTrashCan(temp);
            Debug.Log(GameManager1.Instance.TrashCans.Count);
        }
    }
}
