﻿using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace DialogueSystem
{
    public class DialogueLine : DialogueBaseClass

    {
        public GameObject GameObjectWithImage;
        public Sprite ImageYouWant;
        private Text textHolder;

        [SerializeField] private bool end;


       [Header ("Text Options")]
        [SerializeField] private string input;
        [SerializeField] private Color textColor;
        [SerializeField] private Font textFont;

        [Header("Time parameters")]
        [SerializeField] private float delay;
        [SerializeField] private float delayBetweenLines;

        [Header("Sound")]
        [SerializeField] private AudioClip sound;



        private void Awake()
        {
            textHolder = GetComponent<Text>();
            textHolder.text = "";

          
        }

        private void Start()
        {
            StartCoroutine(WriteText(end, input, textHolder, textColor, textFont, delay, sound, delayBetweenLines));
            GameObjectWithImage.GetComponent<Image>().sprite = ImageYouWant;
        }
    }
}