using UnityEngine;
using System.Collections;

public class BackgroundScroller : MonoBehaviour
{
    [SerializeField] private float _speed; //het snelheid van het scrolling background
    private MeshRenderer _renderer; //het materiaal van het background (geen Sprite 2D)

	// Use this for initialization
	void Start ()
    {
        //"this" verwijst naar het script "BackgroundScroller" en het component invoegen van "MeshRenderer"
        this._renderer = GetComponent<MeshRenderer>(); 
	}
	
	// Update is called once per frame
	void Update ()
    {
        //Voor zorgen dat het TEXTURE background gaat scrollen, NIET SPAWNEN!
        Vector2 offset = new Vector2(Time.time * _speed, 0);

        //verwijst naar de Vector2 variabele "offset"
        _renderer.material.mainTextureOffset = offset;
	}
}
