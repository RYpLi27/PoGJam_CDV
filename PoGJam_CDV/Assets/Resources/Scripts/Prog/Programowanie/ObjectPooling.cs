using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooling : MonoBehaviour
{
    [SerializeField] private GameObject _cubePrefab;
    [SerializeField] private int _amount = 10;

    private List<GameObject> _cubes = new List<GameObject>();

    private void Start()
    {
        for (int i = 0; i < _amount; i++)
        {
            GameObject cube = Instantiate(_cubePrefab, transform.position, Quaternion.identity);
            cube.SetActive(false);
            _cubes.Add(cube);
            cube.name = $"Cube {i}";
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject cube = GetCurrentPrefab();

            if (cube != null)
            {
                cube.transform.position = transform.position;
                StartCoroutine(DisableCube(2.0f, cube));
            }
        }
    }

    public GameObject GetCurrentPrefab()
    {
        for (int i = 0; i < _cubes.Count; i++)
        {
            if (!_cubes[i].activeInHierarchy)
            {
                return _cubes[i];
            }
        }

        return null;
    }

    private IEnumerator DisableCube(float p_time, GameObject p_cube)
    {
        p_cube.SetActive(true);

        yield return new WaitForSeconds(p_time);

        p_cube.SetActive(false);
    }
}
