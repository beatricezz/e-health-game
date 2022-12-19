using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class DialogueUI : MonoBehaviour
{
    [SerializeField] private GameObject dialogueBox;
    [SerializeField] private TMP_Text textLabel;
    [SerializeField] private DialogueObject testDialogue;
    [SerializeField] RectTransform fader;
    private float t=0;
    public int dialogOption = 0;
    [SerializeField] private List<AudioClip> audioClips;
    private AudioSource characterAudioSource;
    private TypewriterEffect typewriterEffect;
    
    private void Start()
    {   
        typewriterEffect = GetComponent<TypewriterEffect>();
        CloseDialogueBox();
        fader.gameObject.SetActive (true);
        LeanTween.alpha (fader, 2,0);
        LeanTween.scale (fader, new Vector3(25,25,1), 0f); 
        LeanTween.alpha (fader, 0,1.5f); 
        
        ShowDialogue(testDialogue);
       

    }

    public void ShowDialogue(DialogueObject dialogueObject)
    {
        dialogueBox.SetActive(true);
        StartCoroutine(StepThroughDialogue(dialogueObject));
        
      
    }

    private IEnumerator StepThroughDialogue(DialogueObject dialogueObject)
    {

        foreach (string dialogue in dialogueObject.Dialogue)
        {
            yield return typewriterEffect.Run(dialogue, textLabel);
            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Mouse0));

        }

        CloseDialogueBox();
        fader.gameObject.SetActive (true);
        LeanTween.alpha (fader, 0,0);
        LeanTween.scale (fader, new Vector3(25,25,1), 0f); 
        LeanTween.alpha (fader, 2,1.5f);

     //   if(SceneManager.GetActiveScene().buildIndex==4){
       //     LeanTween.alpha (fader, 2,1f).setOnComplete(()=>{SceneManager.LoadScene("Scenes/keyboard/keyboard");});
           
            }
        //else{
          //  LeanTween.alpha (fader, 2,1f).setOnComplete(() =>
            //{
              //  SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
               
            //});
       // }
    //}

    private void CloseDialogueBox()
    {
        dialogueBox.SetActive(false);
        textLabel.text = string.Empty;
        
    }

    private void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex >= 4)
            DoNotDestroy.instance.GetComponent<AudioSource>().Pause();
    }
}

