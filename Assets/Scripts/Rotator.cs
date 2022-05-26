using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

public class Rotator : MonoBehaviour
{
    [SerializeField] float _speed = 150f;
    [SerializeField] Text _scoreText,_levelText;
    int _score,_level;
    private void Awake()
    {
        _score = Convert.ToInt32(_scoreText.text);
        _scoreText.text = _score.ToString();
    }
    private void FixedUpdate()
    {
        
        transform.Rotate(0f, 0f, _speed * Time.deltaTime);
        //LevelSystem();
        _scoreText.text = _score.ToString();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Pin")
        {
            Debug.Log("carpti");
            _score--;

        }
        if (_score == 0)
        {
            _level = Convert.ToInt32(_levelText.text);
            //_level += 1;
            _score = _level;
            SceneManager.LoadScene(_level);
            //Destroy(GameObject.FindGameObjectWithTag("Pin"));
            //Destroy(GetComponentInChildren<GameObject>());
        }
    }


    void LevelSystem()
    {
        
        
        
    }
}
