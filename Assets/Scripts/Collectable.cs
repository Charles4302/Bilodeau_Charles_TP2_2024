using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    public CollectableObjects pickUpObjectType;

    [SerializeField]
    private GameEvent pickUpObjectEvent;

    [SerializeField]
    public GameObject dechet;

    [SerializeField]
    public Transform cameraTransform;

    [SerializeField]
    public AudioSource audioSource;

    private JouerSon jouerSon;

    private Vector3 offset;

    void Awake()
    {
        
        offset = new Vector3(
            Random.Range(-0.5f, 0.5f),
            Random.Range(-0.7f, -0.4f),
            Random.Range(1.4f, 1.4f)
        );
    }

    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Player"))
        {
            
            dechet.transform.position = cameraTransform.position + cameraTransform.forward * offset.z + cameraTransform.right * offset.x + cameraTransform.up * offset.y;
            dechet.transform.rotation = cameraTransform.rotation;
            dechet.transform.SetParent(cameraTransform);

            dechet.transform.localPosition = offset;
            dechet.transform.localRotation = Quaternion.identity;
            
             Rigidbody rb = dechet.GetComponent<Rigidbody>();
             rb.useGravity = false;
             rb.isKinematic = true;
            
             CollectableObjects collectableObjects = dechet.GetComponent<CollectibleItem>().collectableObjects;
            
                audioSource.PlayOneShot(collectableObjects.AudioClip);
            
            
        }
        
    }
}
