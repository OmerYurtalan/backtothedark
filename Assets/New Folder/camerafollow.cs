using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour
{
    temel player;

    [SerializeField]
    Collider2D boundsBox;

    float halfYukseklik, halfGenislik;

    private void Awake()
    {
        player = Object.FindObjectOfType<temel>();
    }
    private void Start()
    {
        halfYukseklik = Camera.main.orthographicSize ;
        halfGenislik= halfYukseklik*Camera.main.aspect;
    }

    private void Update()
    {
        transform.position = new Vector3(
            Mathf.Clamp(player.transform.position.x,boundsBox.bounds.min.x+halfGenislik,boundsBox.bounds.max.x-halfGenislik), 
            Mathf.Clamp(player.transform.position.y, boundsBox.bounds.min.y+halfYukseklik, boundsBox.bounds.max.y-halfYukseklik),
            transform.position.z);
    }
}
