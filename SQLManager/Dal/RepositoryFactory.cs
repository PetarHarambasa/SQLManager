using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLManager.Dal
{
    public static class RepositoryFactory
    {
        private static readonly Lazy<IRepository> repository = new Lazy<IRepository>(() => new SQLRepository());
        public static IRepository GetRepository() => repository.Value;
    }
}
