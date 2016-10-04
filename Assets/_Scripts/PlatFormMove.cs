using UnityEngine;
using System.Collections;

public class PlatformMove : MonoBehaviour
{
    [SerializeField] private float _speed = 1.5f; //het snelheid die de Platforms gaat
    private Vector3 _newPos = new Vector3(30, 0, 0); //het positie dat de platforms spawnt

    // Use this for initialization
    void Start ()
    {
       //
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.Translate(-Vector3.right * _speed * Time.deltaTime); //voor zorgen dat het naar LINKS gaat
        if(transform.position.x < -12) //als het x positie kleiner is dan -12
        {
            transform.position += _newPos; //verplaatsen naar nieuwe x positie
        }
	}
}
