using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class GameManagerCubito : MonoBehaviour
{
    public static GameManagerCubito instance;
    [SerializeField] private int level = 1, exp, nextLevel = 10;
    public int expForClick;
    [Space]
    [Header("Visual Manager")]
    [SerializeField]
    private Image bar;
    [SerializeField]
    private TextMeshProUGUI levelText;
    [SerializeField]
    private GameObject textInfo;

    [SerializeField] private Canvas spawnPosition;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        FillBar((float)(exp), (float)(nextLevel));
    }

    public void AddExperience(int expToAdd)
    {
        exp += expToAdd;
        GameObject textFeedback = Instantiate(textInfo, 
            spawnPosition.transform);
        textFeedback.
            GetComponentInChildren<TextMeshProUGUI>().text = 
            "+" + expToAdd;
        textFeedback.transform.localPosition = 
            new Vector3(Random.Range(-0.5f, 0.5f), 0, 0);
        textFeedback.transform.DOMoveY
            (2, 0.25f).SetRelative(true).SetAutoKill(true);
        Destroy(textFeedback, 0.25f);
        if (exp >= nextLevel)
        {
            exp -= nextLevel;
            LevelUp();
        }
        FillBar((float)(exp), (float)(nextLevel));
    }
    private void LevelUp()
    {
        level++;
        nextLevel = (int) (nextLevel * 1.5f + nextLevel);
    }

    public void FillBar(float _exp, float _nextLevel)
    {
        levelText.text = "Level: " + level;
        bar.fillAmount = _exp / nextLevel;
    }

    public void AddToExpForClick(int click)
    {
        expForClick += click;
    }

}
