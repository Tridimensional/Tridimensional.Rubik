using Tridimensional.Rubik.Service.IServiceProvider;

namespace Tridimensional.Rubik.Service.ServiceImplementation
{
	public class CrossingService : ICrossingService
    {
        #region Instance

        public static ICrossingService _instance;

        public static ICrossingService Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CrossingService();
                }

                return _instance;
            }
        }

        #endregion
    }
}
