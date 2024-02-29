// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// public class PlayerMovement : MonoBehaviour {
//
//     // Speed at which the character moves
//     // The Speed the character will move
// 	
//     private Collider col;  
//     public float moveSpeed;
//     RaycastHit hit;
//     Ray ray;
//     public float hitdist = 0.0f;
//     public float speed = 3.0F;
//     public float rotateSpeed = 3.0F;
//     public Transform myTransform;				// this transform
//     public Vector3 destinationPosition;		// The destination Point
//     public Vector3 pointPosition;
//     public float destinationDistance;      // The distance between myTransform and destinationPosition
//     public float smooth = 0.0005F;
//  
//     void Awake() {
// 		
//     }
//  
//     void Start () {
// 	
//         var character = GameObject.FindWithTag("Player");	
//         myTransform = character.transform;
//         pointPosition = destinationPosition;
// 		
// 		
//         destinationPosition = myTransform.position;			
//     }
//  
//     void Update () {
//  		
//         // CharacterController controller = GetComponent<CharacterController>();
//         // keep track of the distance between this gameObject and destinationPosition
//         // destinationDistance = Vector3.Distance(destinationPosition, myTransform.position);
//         
// 	        if (pointPosition.x >= destinationPosition.x + 0.5f && pointPosition.x + 0.5 <= pointPosition.z)
// 	        {
// 		        // doNothing();
// 	        }
// 	        else if (pointPosition.x > destinationPosition.x)
// 	        {
// 		        destinationPosition.x = destinationPosition.x + moveSpeed;
// 	        }
// 	        else if(pointPosition.x < destinationPosition.x)
// 	        {
// 		        destinationPosition.x = destinationPosition.x - moveSpeed;
// 	        }
// 	        
// 	        if (pointPosition.z >= destinationPosition.z + 0.5f && pointPosition.z + 0.5 <= pointPosition.z)
// 	        {
// 		        // doNothing();
// 	        }
// 	        else if (pointPosition.z > destinationPosition.z)
// 	        {
// 		        destinationPosition.z = destinationPosition.x + moveSpeed;
// 	        }
// 	        else if(pointPosition.z < destinationPosition.z)
// 	        {
// 		        destinationPosition.z = destinationPosition.z - moveSpeed;
// 	        }
//         
//         
// 		
//         // Moves the Player if the Left Mouse Button was clicked
//         if (Input.GetMouseButtonDown(0)) {
//             RaycastHit hit;
//             if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit))
//             {
//                 if(hit.transform)
//                 {
// 	                pointPosition = hit.transform.position;
//                 }
//             }
//             
//         }
// 		
//     }
// }


using UnityEngine;
using System.Collections;
public class playerMovement : MonoBehaviour
{
    Vector3 newPosition;
    void Start () {
        newPosition = transform.position;
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                newPosition = hit.point;
                transform.position = newPosition;
            }
        }
    }
}