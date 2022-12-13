using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows.Speech;

public class Baguette : MonoBehaviour
{
    public AudioSource audioSource;
    public GameObject baguettePrefab;
    public string[] keywords = new string[] { "je voudrais une baguette seal vous play" };
    public Vector3 baguetteLocation = new Vector3(-3, 1, -17);

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

        if (word == "je voudrais une baguette seal vous play")
        {
            audioSource.Play();
            GameObject baguette = Instantiate(baguettePrefab);
            baguette.transform.position = baguetteLocation;
        }
    }
}