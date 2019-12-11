using System.Collections;
using UnityEngine;

public class KillBox : MonoBehaviour
{
    void OnTriggerExit(Collider other)
    {
        Destroy(other.gameObject.transform.parent.gameObject); // when bullets hit boundary, they are deleted, some methods had to be deleted to make this script work. Systems.Colllection Generic was removed!
    }

}
