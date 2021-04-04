using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cord_Movement : MonoBehaviour
{
  //  [SerializeField]private LineRenderer cordRenderer;
    [SerializeField]private GameObject[] cord_points; // All the sections of the cord that will be used to simulate the bending of it 
    [SerializeField] private float lengthPoints = 0.5f;
    [SerializeField] private CharacterJoint cord_joints;
    private void Start()
    {
       //ConnectPoints(); 
    }

    private void Update()
    {
        
    }
    private void ConnectPoints() {
        for (int i = 1; i < cord_points.Length; i++)  
        {
            cord_points[i].transform.position = new Vector3(transform.position.x, transform.position.y, cord_points[i].GetComponent<CharacterJoint>().connectedBody.transform.position.z - lengthPoints);
            if (i != cord_points.Length - 1)
            {
                cord_joints.connectedBody = cord_points[i + 1].GetComponent<Rigidbody>();
            }
        }
    }
    
}
