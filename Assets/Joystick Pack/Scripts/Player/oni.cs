using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class oni : MonoBehaviour
{
    [SerializeField] private GameObject player;

    [SerializeField] private int moveSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created


    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(
        transform.position, player.transform.position, moveSpeed * Time.deltaTime);
    }
}
