//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class StingController : MonoBehaviour
//{
//    [SerializeField] GameObject _stingGO;
//    [SerializeField] Animator _stingAnimator;
//    //[SerializeField] float _StingSpeed;
//    [SerializeField] Rigidbody2D _stingsRB;
//    [SerializeField] bool _isStingMoveActive=false;
//    [SerializeField] Transform _StingTransform, _instantiateTransform;
   
//    void Start()
//    {
        
//    }

    
//    void Update()
//    {
//        StingMoveInput();

        
//    }
//    private void OnTriggerEnter2D(Collider2D collision)
//    {
//        if (collision.gameObject.tag == "Player")
//        {
//            Debug.Log("hit");
//            transform.SetParent(collision.transform);
//            _isStingMoveActive = false;


//            //_stingsRB.transform.rotation = new Quaternion(0, 0, 0,360);

//        }
//    }
//    void StingMoveInput()
//    {
//        if (Input.GetMouseButtonDown(0))
//        {
//            _isStingMoveActive = true;
//            Debug.Log("Mause pushed");
//            _stingAnimator.enabled = false;
//            StartCoroutine(StingCreation());
//        }
//        //_isStingMoveActive = false;
//        //_stingAnimator.StartPlayback();
//    }

//    private void FixedUpdate()
//    {
//        StingsMove();

//    }

//    void StingsMove()
//    {
        
//        if (_isStingMoveActive)
//        {
//            _StingTransform.transform.position += new Vector3(0, 5 * Time.deltaTime);
//        }
//    }
    
  
  

    
//    IEnumerator StingCreation()
//    {
//        yield return new WaitForSeconds(2f);
//        _isStingMoveActive = false;
        
//        Instantiate<GameObject>(_stingGO, _instantiateTransform, true);
//        _stingAnimator.enabled = true;
//    }
//}
