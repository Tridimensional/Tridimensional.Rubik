using Tridimensional.Rubik.Service.IServiceProvider;

namespace Tridimensional.Rubik.Service.ServiceImplementation
{
    public class BattleService : IBattleService
    {
        #region Instance

        public static IBattleService _instance;

        public static IBattleService Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BattleService();
                }

                return _instance;
            }
        }

        #endregion
    }
}
