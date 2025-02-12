using System.Collections.Generic;
using UnityEngine;

public class CursedCounter : MonoBehaviour
{
    private List<GameObject> _curseObjectsList = new();
    private int _CursedObjectsAll;

    private void Start()
    {
        DetectCursedObjects();
    }

    private void DetectCursedObjects()
    {
        Vector3 sphereCenter = transform.position + Vector3.zero;
        Collider[] hitColliders = Physics.OverlapSphere(sphereCenter, 20f);

        foreach (Collider collider in hitColliders)
        {
            if (collider.gameObject.CompareTag("CursedObjects"))
            {
                _curseObjectsList.Add(collider.gameObject);
            }
        }

        _CursedObjectsAll = _curseObjectsList.Count;
    }

    public void MinusCursedObjects(int p_value)
    {
        _CursedObjectsAll -= p_value;
    }

    public int CountCurseObjects()
    {
        return _CursedObjectsAll;
    }
}
