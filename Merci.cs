using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows.Speech;
using OVR;

public class Merci : MonoBehaviour
{
    public AudioSource audioSource;
    public string[] keywords = new string[] { "oh revwar" };

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

        if (word == "oh revwar")
        {
            audioSource.Play();
        }
    }
}