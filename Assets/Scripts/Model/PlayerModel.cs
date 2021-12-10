using System;
using Tool;

namespace Model
{
    public class PlayerModel
    {
        private int _score;
        private int _level;
        private double _hp;

        public PlayerModel(int score, int level, double hp)
        {
            _score = score;
            _level = level;
            _hp = hp;
        }

        public static PlayerModel FromJson(String json)
        {
           return JSONUtils.FromJson<PlayerModel>(json);
        }

        public static String ToJson(PlayerModel model)
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