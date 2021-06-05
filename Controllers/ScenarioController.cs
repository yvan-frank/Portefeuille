
using System.Collections.Generic;
using DAL;
using Models;

namespace Controllers
{
    public class ScenarioController
    {
        private readonly ScenarioDal _scenarioDal = new ScenarioDal();
        public List<ScenarioModel> GetListToScenario()
        {
            return _scenarioDal.GetAllScenario();
        }
    }
}
