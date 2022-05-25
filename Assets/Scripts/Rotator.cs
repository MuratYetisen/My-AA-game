using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Rotator : MonoBehaviour
{
    [SerializeField] float _speed = 150f;
    [SerializeField] Text _scoreText;
    int _score=4,_level=4;
    private void Awake()
    {
        _scoreText.text = _score.ToString();
    }
    private void FixedUpdate()
    {
        
        transform.Rotate(0f, 0f, _speed * Time.deltaTime);
        LevelSystem();
        _scoreText.text = _score.ToString();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Pin")
        {
            Debug.Log("carpti");
            _score--;

        }
    }

    private void Update()
    {
        
    }
    void LevelSystem()
    {
        if (_score==0)
        {
            _level += 1;
            _score = _level;
            //Destroy(GameObject.FindGameObjectWithTag("Pin"));
            //Destroy(GetComponentInChildren<GameObject>());
        }
        
    }
}
