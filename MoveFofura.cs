using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveFofura : MonoBehaviour
{
	public float velocidadeF;
	public float forcaPulo;
	private Rigidbody2D rb;
	private int count;
	public GameObject Parede;
	
	
	// Start is called before the first frame update
	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
		count=0;
		
	}

	// Update is called once per frame
	void FixedUpdate()
	{
		if(Input.GetKey(KeyCode.A))
		{
			transform.Translate(Vector2.left*-velocidadeF * Time.deltaTime);
		}
		if(Input.GetKey(KeyCode.D))
		{
			transform.Translate(Vector2.left*velocidadeF * Time.deltaTime);
		}  
		if (Input.GetKeyDown(KeyCode.W)) {
			rb.AddForce(transform.up * forcaPulo);
		}
		
	}
	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag=="chave"){
			other.gameObject.SetActive(false);
			count=count+1;
			if (count >= 15){
				Parede.SetActive(false);
			}
			
		}

	}
}
