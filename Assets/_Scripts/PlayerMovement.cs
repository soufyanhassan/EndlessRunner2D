using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    [SerializeField]
         private float _playerSpeed = 2.0f;
    [SerializeField]
         private Vector2 _jumpPower = new Vector2(0,8);



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(_playerSpeed * Time.deltaTime, 0f, 0f);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody2D>().AddForce(_jumpPower, ForceMode2D.Impulse);
        }
    }
}
