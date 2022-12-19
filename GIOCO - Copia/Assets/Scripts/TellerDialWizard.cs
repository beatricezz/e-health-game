using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;



public class TellerDialWizard : MonoBehaviour
{
  
    [SerializeField] private GameObject dialogueBox;
    [SerializeField] private TMP_Text textLabel;
    [SerializeField] private DialogueObject testDialogue;
    [SerializeField] RectTransform fader;
    public List<AudioClip> audioClips;
    
    private AudioSource characterAudioSource;
    
    public int dialogOption = 0;
    
    private TypewriterEffect typewriterEffect;
    
    
    // Start is called before the first frame update
    void Start()
    {
        typewriterEffect = GetComponent<TypewriterEffect>();
        CloseDialogueBox();
        fader.gameObject.SetActive (true);
        LeanTween.alpha (fader, 2,0);
        LeanTween.scale (fader, new Vector3(25,25,1), 0f); 
        LeanTween.alpha (fader, 0,1.5f); 
        
        //Get References
        characterAudioSource =GetComponent<AudioSource>();

        //Set First text and Play first Audio
        ShowDialogue(testDialogue);
        characterAudioSource.PlayOneShot(audioClips[dialogOption]);
        dialogOption = dialogOption + 1;


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
            if (dialogOption == 4)
            {
                yield return typewriterEffect.Run(dialogue, textLabel);
                yield return new WaitForSeconds(1);
                CloseDialogueBox();
                fader.gameObject.SetActive(true);
                LeanTween.alpha(fader, 0, 0);
                LeanTween.scale(fader, new Vector3(25, 25, 1), 0f);
                LeanTween.alpha(fader, 2, 1.5f);
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

            }
            else
            {
                yield return typewriterEffect.Run(dialogue, textLabel);
                yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Mouse0));
                characterAudioSource.PlayOneShot(audioClips[dialogOption]);
                dialogOption = dialogOption + 1;

            }
        }
    }




    private void CloseDialogueBox()
    {
        dialogueBox.SetActive(false);
        textLabel.text = string.Empty;
        
    }
    
    private void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex == 4)
            DoNotDestroy.instance.GetComponent<AudioSource>().Pause();
    }
}
