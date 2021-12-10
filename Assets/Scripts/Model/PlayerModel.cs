using Tool;

namespace Model
{
    public class PlayerModel
    {
        private double _hp;
        private int _level;
        private int _score;

        public PlayerModel(int score, int level, double hp)
        {
            _score = score;
            _level = level;
            _hp = hp;
        }

        public static PlayerModel FromJson(string json)
        {
            return JSONUtils.FromJson<PlayerModel>(json);
        }

        public static string ToJson(PlayerModel model)
        {
            return JSONUtils.ToJson(model);
        }

        public void SetScore(int score)
        {
            _score = score;
        }

        public int GetScore()
        {
            return _score;
        }

        public void SetLevel(int level)
        {
            _level = level;
        }

        public int GetLevel()
        {
            return _level;
        }

        public void SetHp(double hp)
        {
            _hp = hp;
        }

        public double GetHp()
        {
            return _hp;
        }
    }
}