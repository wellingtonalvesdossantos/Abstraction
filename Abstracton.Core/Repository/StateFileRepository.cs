using Abstraction.Core.Models;

namespace Abstraction.Core.Repository
{
    public class StateFileRepository : FileRepository<State>
    {
        protected override string FilePath => @"c:\estados.json";
    }
}
