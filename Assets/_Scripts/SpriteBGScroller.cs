using UnityEngine;
using System.Collections;

public class SpriteBGScroller : MonoBehaviour
{
    [SerializeField]private float _speed;
    private Vector3 _newPos = new Vector3(60, 0, 0);
    //[SerializeField]private float tileSizeX;

    private Vector3 _startPos;

	void Start ()
    {
        _startPos = transform.position;
	}
	
	// Update is called once per frame
	void Update ()
    {
        //float _newPos = Mathf.Repeat(Time.time * _speed, tileSizeX);
        //transform.position = _startPos + Vector3.left * _newPos;
        transform.Translate(Vector3.left * _speed * Time.deltaTime);
	}

    void OnBecameInvisible()
    {
        transform.position += _newPos;
    }
}
