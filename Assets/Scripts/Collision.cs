using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{

    [SerializeField] Transform explosionPrefab;

    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        ContactPoint contact = collision.contacts[0];
        Quaternion rotation = Quaternion.FromToRotation(Vector3.up, contact.normal);
        Vector3 position = contact.point;
        if (collision.gameObject.tag == "enemy")
        {
            Instantiate(explosionPrefab, position, rotation);
        }
        Debug.Log("Colision con: " + collision.gameObject.name);
    }

    private void OnCollisionStay(UnityEngine.Collision collision){
        Debug.Log("Mantiene colision con: " + collision.gameObject.name);
    }

    private void OnCollisionExit(UnityEngine.Collision collision){
        if(collision.gameObject.tag == "enemy"){
            Destroy(collision.gameObject);
        }
        Debug.Log("Sale de colision con: " + collision.gameObject.name);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
