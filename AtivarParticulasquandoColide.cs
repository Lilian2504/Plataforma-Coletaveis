using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtivarParticulasquandoColide : MonoBehaviour
{
	public ParticleSystem ps;
    // Start is called before the first frame update
    void Start()
    {
		ps.Stop();
    }

	void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.name == "Felpudo_Seq_Idle0001"){
			ps.Play();
		}
	}
    // Update is called once per frame
   
}
