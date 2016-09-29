﻿using UnityEngine;
using System.Collections;

public class PlatformGenerate : MonoBehaviour
{
    [SerializeField] private int maxPlatforms = 10; //aantal Platforms dat wordt gespawned
    [SerializeField] private GameObject platform; //het Platform zelf invoegen
    [SerializeField] private float horizontalMin = 7.5f; //het minimale horizontale afstand tussen de Platforms
    [SerializeField] private float horizontalMax = 14f; //het maximale horizontale afstand tussen de Platforms
    [SerializeField] private float verticalMin = -6f; //het minimale verticale afstand tussen de Platforms
    [SerializeField] private float verticalMax = 6; //het maximale verticale afstand tussen de Platforms
    

    private Vector2 originPosition; //het positie dat de Platforms spawnt

    void Start()
    {
        originPosition = transform.position;
        Spawn(); //aanroepen van het functie "Spawn"
    }

    void Spawn()
    {
        for (int i = 0; i < maxPlatforms; i++) //als i kleiner is dan maxPlatforms (10) 
        {
            //Voor zorgen dat de Platforms tussen de minimale en de maximale positie kan zetten
            Vector2 randomPosition = originPosition + new Vector2(Random.Range(horizontalMin, horizontalMax), Random.Range(verticalMin, verticalMax));
            //het spawnen/instantieren van de Platforms
            GameObject _platform = Instantiate(platform, randomPosition, Quaternion.identity) as GameObject;
            _platform.AddComponent<PlatFormMove>();

        }
    }
}