using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows.Speech;
using OVR;

public class Bonjour : MonoBehaviour
{
    public AudioSource audioSource;
    public string[] keywords = new string[] { "bon joor" };

    private KeywordRecognizer recognizer;

    void Start()
    {
        recognizer = new KeywordRecognizer(keywords);
        recognizer.OnPhraseRecognized += OnPhraseRecognized;
        recognizer.Start();
    }

    void OnPhraseRecognized(PhraseRecognizedEventArgs args)
    {
        string word = args.text;

        if (word == "bon joor")
        {
            audioSource.Play();
        }
    }
}