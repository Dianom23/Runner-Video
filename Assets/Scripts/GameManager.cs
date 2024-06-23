using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _coinsText;
    [SerializeField] private Player _player;
    [SerializeField] private TileGenerator _tileGenerator;
    private int _coinsCount;

    void Start()
    {
        _player.DieEvent.AddListener(LoseHandler);
    }

    private void LoseHandler()
    {
        print("Конец игры");
        _tileGenerator.SetEnabling(false);
    }

    public void AddCoin()
    {
        _coinsCount++;
        _coinsText.text = _coinsCount.ToString();
    }
}
