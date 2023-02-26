using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace Abstraction.Core.Repository
{
    public abstract class FileRepository<T> : IRepository<T> where T : class
    {
        private List<T> _list = new List<T>();
        protected abstract string FilePath { get; }

        public FileRepository()
        {
            ReadFile();
        }

        private void ReadFile()
        {
            try
            {
                using (StreamReader file = File.OpenText(FilePath))
                using (JsonTextReader reader = new JsonTextReader(file))
                {
                    JArray o2 = (JArray)JToken.ReadFrom(reader);
                    _list = o2.ToObject<List<T>>();
                }
            }
            catch { }
        }

        private void PersistInFile()
        {
            try
            {
                using (StreamWriter file = File.CreateText(FilePath))
                using (JsonTextWriter writer = new JsonTextWriter(file))
                {
                    JArray o2 = JArray.FromObject(_list);
                    o2.WriteTo(writer);
                }
            }
            catch { }
        }

        public void Add(T entity)
        {
            _list.Add(entity);
            PersistInFile();
        }

        public long Count()
        {
            return _list.Count;
        }

        public IReadOnlyList<T> GetAll()
        {
            return _list;
        }

        public void Delete(T entity)
        {
            var count = _list.RemoveAll((x) => x.Equals(entity));
            if (count > 0)
                PersistInFile();
        }
    }
}
