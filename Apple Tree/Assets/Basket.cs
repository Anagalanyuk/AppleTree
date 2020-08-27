using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Basket : MonoBehaviour
{
    public Text _scoreGT;
    // Start is called before the first frame update
    void Start()
    {
        GameObject goScore = GameObject.Find("ScoreCounter");
        _scoreGT = goScore.GetComponent<Text>();
        _scoreGT.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos2D = Input.mousePosition;
        mousePos2D.z = -Camera.main.transform.position.z;

        Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);

        Vector3 pos = this.transform.position;
        pos.x = mousePos3D.x;
        this.transform.position = pos;
    }

    void OnCollisionEnter( Collision other)
    {
        GameObject collisionWidth = other.gameObject;
        if(collisionWidth.tag == "Apple")
        {
            Destroy(collisionWidth);
        }

        int score = int.Parse(_scoreGT.text);

        score += 100;

        _scoreGT.text = score.ToString();
    }
}
