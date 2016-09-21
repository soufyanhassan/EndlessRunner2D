using UnityEngine;
using System.Collections;

public class BackgroundScroller : MonoBehaviour
{
    [SerializeField]private float _speed;
    private MeshRenderer _renderer;

	// Use this for initialization
	void Start ()
    {
        this._renderer = GetComponent<MeshRenderer>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        Vector2 offset = new Vector2(Time.time * _speed, 0);
        _renderer.material.mainTextureOffset = offset;
	}
}
