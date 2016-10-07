﻿using UnityEngine;
using System.Collections;

public class PlatformGenerate : MonoBehaviour
{
    [SerializeField] private int maxPlatforms = 50; //aantal Platforms dat wordt gespawned
    [SerializeField] private GameObject platform; //het Platform zelf invoegen
    [SerializeField] private float horizontalMin = 7.5f; //het minimale horizontale afstand tussen de Platforms
    [SerializeField] private float horizontalMax = 14f; //het maximale horizontale afstand tussen de Platforms
    [SerializeField] private float verticalMin = -6f; //het minimale verticale afstand tussen de Platforms
    [SerializeField] private float verticalMax = 6; //het maximale verticale afstand tussen de Platforms
    [SerializeField] private float _distanceBetween = 5; //het afstand tussen de platforms
    [SerializeField] private Transform _originalPos; //originele position die de platforms spawnt

    private float _platformWidth = 3;
    private Vector2 originPosition; //het positie dat de Platforms spawnt

    void Start()
    {
        originPosition = transform.position;
        Spawn(); //aanroepen van het functie "Spawn"
    }

    void Spawn()
    {
        for (int i = 0; i < maxPlatforms; i++) //als i kleiner is dan maxPlatforms 
        {
            //Voor zorgen dat de Platforms tussen de minimale en de maximale positie kan zetten
            Vector2 randomPosition = originPosition + new Vector2(Random.Range(horizontalMin, horizontalMax), Random.Range(verticalMin, verticalMax));
            //het spawnen/instantieren van de Platforms
            GameObject _platform = Instantiate(platform, randomPosition, Quaternion.identity) as GameObject;
            //het script "PlatformMove" toevoegen naar het script
            _platform.AddComponent<PlatformMove>();
        }

        if(transform.position.x < _originalPos.position.x)
        {
            transform.position = new Vector2(transform.position.x + _platformWidth + _distanceBetween, transform.position.y + _platformWidth + _distanceBetween);
            Instantiate(platform, transform.position, transform.rotation);
        }
    }
}