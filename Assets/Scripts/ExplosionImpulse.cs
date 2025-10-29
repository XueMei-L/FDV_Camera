// using UnityEngine;
// using Unity.Cinemachine;

// public class ExplosionImpulse : MonoBehaviour
// {
//     // Cinemachine Impulse Source component ---------------------
//     // private CinemachineImpulseSource impulseSource;

//     // void Start()
//     // {
//     //     impulseSource = GetComponent<CinemachineImpulseSource>();

//     // }

//     // void Update()
//     // {
//     //     if (Input.GetKeyDown(KeyCode.Space))
//     //     {
//     //         impulseSource.GenerateImpulse();
//     //     }
//     // }

//     private CinemachineImpulseSource impulseSource;

//     void Start()
//     {
//         impulseSource = GetComponent<CinemachineImpulseSource>();
//     }

//     void OnCollisionEnter(Collision collision)
//     {
//         if (collision.gameObject.CompareTag("Player"))
//         {
//             impulseSource.GenerateImpulse();
//         }
//     }
// }