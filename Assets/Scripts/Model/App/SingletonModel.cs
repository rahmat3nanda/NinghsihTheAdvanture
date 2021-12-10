namespace Model.App
{
    public sealed class SingletonModel
    {
        private static readonly object Obj = new object();

        private static SingletonModel _instance;
        private PlayerModel _player;

        private SingletonModel()
        {
        }

        public static SingletonModel GetInstance
        {
            get
            {
                if (_instance == null)
                    lock (Obj)
                    {
                        if (_instance == null)
                            _instance = new SingletonModel();
                    }

                return _instance;
            }
        }

        public void SetPlayer(PlayerModel data)
        {
            _instance._player = data;
        }

        public PlayerModel GetPlayer()
        {
            return _instance._player;
        }
    }
}