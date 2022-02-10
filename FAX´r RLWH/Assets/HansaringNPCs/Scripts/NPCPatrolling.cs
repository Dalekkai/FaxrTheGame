using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCPatrolling : MonoBehaviour
{
    public int xPos;
    public int zPos;

    void OnTriggerEnter(Collider myNpc)
    {
        if(myNpc.tag == "NPC")
        {
            xPos = Random.Range(-36, -93);
            zPos = Random.Range(13, -3);
            this.gameObject.transform.position = new Vector3(xPos, 21.4f, zPos);
        }
    }
}
