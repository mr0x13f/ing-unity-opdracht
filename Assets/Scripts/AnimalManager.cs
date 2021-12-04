using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zoo
{
    public class AnimalManager : MonoBehaviour
    {
        private static AnimalManager _instance;
        public static AnimalManager instance
        {
            get {
                if (_instance != null)
                    return _instance;
                else
                    throw new Exception("No instance of AnimalManager");
            }
        }

        private void Awake()
        {
            if (_instance != null && _instance != this)
            {
                Destroy(gameObject);
                return;
            } else 
                _instance = this;
        }

        public void FeedLeaves()
        {
            var herbivores = FindObjectsOfType<Animal>()
                .OfType<IHerbivore>();

            foreach (IHerbivore herbivore in herbivores)
                herbivore.EatLeaves();
        }

        public void FeedMeat()
        {
            var carnivores = FindObjectsOfType<Animal>()
                .OfType<ICarnivore>();

            foreach (ICarnivore carnivore in carnivores)
                carnivore.EatMeat();
        }

        public void PerformTrick()
        {
            var trickPerformers = FindObjectsOfType<Animal>()
                .OfType<ITrickPerformer>();

            foreach (ITrickPerformer trickPerformer in trickPerformers)
                trickPerformer.PerformTrick();
        }

        public void SayHalloToAll()
        {
            var animals = FindObjectsOfType<Animal>();

            foreach (Animal animal in animals)
                animal.SayHello();
        }

        public void SayHalloByName(string name)
        {
            var animalsWithName = FindObjectsOfType<Animal>()
                .Where(animal => animal.animalName == name);

            foreach (Animal animal in animalsWithName)
                    animal.SayHello();
        }
        
    }
}