using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeProduto.Data.Providers.MongoDb.Interfaces
{
    public interface IMongoDbSettings
    {
        string DatabaseName { get; set; }
        string ConnectionString { get; set; }
    }

    //ADC DEPOIS NAO SEI SE ESTÁ CERTO:
    //public class MongoDbSettings : IMongoDbSettings
    //{
    //    public string DatabaseName { get; set; }
    //    public string ConnectionString { get; set; }
    //}
}
