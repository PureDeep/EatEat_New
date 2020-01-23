using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScoreByContact : MonoBehaviour
{
    public int scoreValue;
    private GameController gameController;

    // Start is called before the first frame update
    void Start()
    {
        GameObject go = GameObject.FindWithTag("GameController");
        if (go != null)
            gameController = go.GetComponent<GameController>();
        else
            Debug.Log("找不到tag为GameController的对象");
        if (gameController == null)
            Debug.Log("找不到脚本GameController.cs");
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            print(other.name);
            Debug.Log("dot");
            gameController.AddScore(scoreValue);
            Destroy(gameObject);
        }
    }
}
