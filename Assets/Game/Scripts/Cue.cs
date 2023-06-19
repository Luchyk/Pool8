using UnityEngine;

public class Cue : MonoBehaviour
{  
    void Update()
    {        
        Vector3 relativePos = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        Quaternion rotation = Quaternion.LookRotation(relativePos, Vector3.up);
        transform.rotation = rotation;
    }
}
