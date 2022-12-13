using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows.Speech;

public class Croissant : MonoBehaviour
{
    public AudioSource audioSource;
    public GameObject croissantPrefab;
    public string[] keywords = new string[] { "je vood ray an croissant seal vous play" };
    public Vector3 croissantLocation = new Vector3(-3, 1, -15);

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

        if (word == "je vood ray an croissant seal vous play")
        {
            audioSource.Play();
            GameObject croissant = Instantiate(croissantPrefab);
            croissant.transform.position = croissantLocation;
        }
    }
}