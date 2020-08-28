using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class ApplePicker : MonoBehaviour
{
    public GameObject _basketPrefab;
    public int _numBasket = 3;
    public float _basketButtonY = -14;
    public float _basketSpacingy = 2f;
    public List<GameObject> _bascetList;
    void Start()
    {          
        _bascetList = new List<GameObject>();
        for (int i = 0; i < _numBasket; ++i)
        {
            GameObject tBusketGo = Instantiate<GameObject>(_basketPrefab);
            Vector3 pos = Vector3.zero;
            pos.y = _basketButtonY + (_basketSpacingy * i);
            tBusketGo.transform.position = pos;
            _bascetList.Add(tBusketGo);

        }
    }

    void Update()
    {

    }

    public void AppleDestroyed()
    {
        GameObject[] tAppleArray = GameObject.FindGameObjectsWithTag("Apple");
        foreach(GameObject tGo in tAppleArray)
        {
            Destroy(tGo);
        }

        int bascetIndex = _bascetList.Count - 1;
        GameObject bascetGo = _bascetList[bascetIndex];
        _bascetList.RemoveAt(bascetIndex);
        Destroy(bascetGo);
    }
}
