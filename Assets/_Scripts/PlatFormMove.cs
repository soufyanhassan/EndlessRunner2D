using UnityEngine;
using System.Collections;

public class PlatFormMove : MonoBehaviour
{
    [SerializeField] private float speed = 1; //het snelheid die de Platforms gaat

    // Use this for initialization
    void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.Translate(-Vector3.right * speed * Time.deltaTime);
	}
}
