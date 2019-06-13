using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Proyecto26;
public class Scores : MonoBehaviour
{
    public Text scoreText;
    public InputField nameText;

    private System.Random random = new System.Random();

    public static int playerScore;
    public static string playerName;
    // Start is called before the first frame update
    void Start()
    {
        playerScore = random.Next(0, 101);
       // scoreText.text = "Score: " + playerScore;
    }

    public void OnSubmit()
    {
        playerName = nameText.text;
        PostToDatabase();
    }

    public void OnGetScore()
    {
        playerName = nameText.text;
        RetriveFromDatabase();
    }

    private void PostToDatabase()
    {
        User user = new User();
        RestClient.Put("https://scalageek-c05ef.firebaseio.com/"+ playerName +".json", user);
    }

    private void RetriveFromDatabase()
    {
        RestClient.Get<User>("https://scalageek-c05ef.firebaseio.com/" + playerName + ".json").Then(response =>
          {
              scoreText.text = response.userName;
              return response;
          });
    }


}
