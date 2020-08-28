using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    public GameObject _applePrefab;
    public float _speed = 10f;
    public float _leftandRightEdge = 18f;
    public float _chanceToChangeDirectory = 0.1f;
    public float _secondsBerweenAppleDrops = 1f;
    void Start()
    {
        Invoke("DropeApple", 2f);
    }

    void Update()
    {
        Vector3 pos = transform.position;
        pos.x += _speed * Time.deltaTime;
        transform.position = pos;

        if (pos.x  < -_leftandRightEdge + 3)
        {
            _speed = Mathf.Abs(_speed);
        }
        else if (pos.x > _leftandRightEdge)
        {
            _speed = -Mathf.Abs(_speed);
        }
    }

    void FixedUpdate()
    {
        if(Random.value < _chanceToChangeDirectory)
        {
            _speed *= -1;
        }
    }

    void DropeApple()
    {
        GameObject apple = Instantiate<GameObject>(_applePrefab);
        apple.transform.position = transform.position;
        Invoke("DropeApple", _secondsBerweenAppleDrops);
    }
}
