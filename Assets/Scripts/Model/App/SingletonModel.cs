namespace Model.App
{
    public sealed class SingletonModel
    {
        private static readonly object Obj = new object();

        private static SingletonModel _instance;
        public static PlayerModel Player;

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
    }
}