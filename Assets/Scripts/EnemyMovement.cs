using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    [SerializeField] GameObject player;
    int state;
    [SerializeField] float moveSpeed = 5f;
    

    
    void Update() {
        if(player){
            Vector3 playerPos = player.transform.position;

            Vector3 playerDistance = playerPos - transform.position;
            
            switch (state){
                case 0:
                    if(playerDistance.magnitude <= 10f){
                        state = 1;
                    }
                    break;
                case 1:
                    if(playerDistance.magnitude <= 10f){
                        transform.position += playerDistance.normalized * moveSpeed * Time.deltaTime;
                    } else{
                        state = 0;
                    }
                    break;
            }
        }

    }
}
