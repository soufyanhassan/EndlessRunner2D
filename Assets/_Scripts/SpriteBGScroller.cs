using UnityEngine;
using System.Collections;

public class SpriteBGScroller : MonoBehaviour
{
    [SerializeField] private float _speed; //het snelheid tijdens het scrollen van het background
    private Vector3 _newPos = new Vector3(50, 0, 0); //het positie dat het background spawnt
	
	// Update is called once per frame
	void Update ()
    {
        //Voor zorgen dat het background naar links gaat scrollen
        transform.Translate(Vector3.left * _speed * Time.deltaTime);
	}

    void OnBecameInvisible()
    {
        //als het background niet in beeld is, voor zorgen dat het helemaal naar achter spawnt
        transform.position += _newPos;
    }
}
