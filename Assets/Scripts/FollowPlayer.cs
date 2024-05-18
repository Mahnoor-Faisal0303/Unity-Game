using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private Transform target;
     [SerializeField] private float offsetX, offsetZ;
    //[SerializeField] private float offsetX, offsetZ;
    //  [SerializeField] private float offsetX;
    [SerializeField] private float LerpSpeed;

    // Update is called once per frame
   private void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position,
            new Vector3(target.position.x + offsetX, transform.position.y, target.position.z + offsetZ), LerpSpeed);
      //  new Vector3(target.position.x + offsetX, transform.position.y,transform.position.z), LerpSpeed);

        //  new Vector3(target.position.x + offsetX, target.position.z + offsetZ), LerpSpeed);
        //new Vector3(target.position.x + offsetX, transform.position.y), LerpSpeed);
    }
}
