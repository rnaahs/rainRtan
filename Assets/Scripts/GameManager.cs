using System.Threading;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
   public GameObject Rain;
   public GameObject Panel;
   public static GameManager I;
   int totalScore = 0;
   public Text scoreText;
   public Text timeText;
   float limit = 30f;

   void Awake()
   {
      I = this;
   }
   // Start is called before the first frame update
   void Start()
   {
      initGame();
      InvokeRepeating("makeRain", 0, 0.5f);
   }

   // Update is called once per frame
   void Update()
   {
      limit -= Time.deltaTime;
      
      if(limit < 0)
      {
         Time.timeScale = 0.0f;
         Panel.SetActive(true);
         limit = 0.0f;
      }
      timeText.text = limit.ToString("N2");
   }

   public void retry()
   {
      SceneManager.LoadScene("MainScene");
   }

   void initGame()
   {
      Time.timeScale = 1.0f;
      totalScore = 0;
      limit = 30f;
   }

   void makeRain()
   {
      Instantiate(Rain);
   }

   public void addScore(int score)
   {
      totalScore += score;
      scoreText.text = totalScore.ToString();
   }
}
