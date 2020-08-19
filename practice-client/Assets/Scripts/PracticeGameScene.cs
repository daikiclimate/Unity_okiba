using System.Text;
using Hidakkathon.Application.Practice;
using UnityEngine;
using UnityEngine.UI;

public class PracticeGameScene : MonoBehaviour
{
    private void Awake()
    {
        var parameter = new GameParameter();
        parameter.Players = new GameParameter.Player[]
        {
            new GameParameter.Player()
            {
                IsEnemy = false,
                Brain = new Task1.Solution()
            },
            new GameParameter.Player()
            {
                IsEnemy = true,
                Brain = new EnemyBrain()
            },
        };

        _proceedTurnButton.onClick.AddListener(() =>
        {
            var game = new RockPaperScissors(parameter);
            if (!game.CheckFinished())
            {
                game.ProceedTurn();
                var environment = game.GetCurrentEnvironment();

                var builder = new StringBuilder();
                builder.AppendLine($"ゲーム結果: {(game.IsWon ? "勝ち" : "負け")}");
                builder.AppendLine($"自分の手: {GetJapaneseHandName(environment.Players[0].Hand)}");
                builder.AppendLine($"相手の手: {GetJapaneseHandName(environment.Players[1].Hand)}");

                _gameLogText.text = builder.ToString();
            }
        });
    }

    private string GetJapaneseHandName(HandType handType)
    {
        switch (handType)
        {
            case HandType.None:
                return "???";
            case HandType.Paper:
                return "パー";
            case HandType.Rock:
                return "グー";
            case HandType.Scissors:
                return "チョキ";
        }

        return string.Empty;
    }

    [SerializeField] private Text _gameLogText = null;
    [SerializeField] private Button _proceedTurnButton = null;
}