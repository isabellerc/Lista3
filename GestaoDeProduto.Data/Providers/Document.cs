﻿using GestaoDeProduto.Data.Providers.MongoDb.Interfaces;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeProduto.Data.Providers
{
    public abstract class Document : IDocument
    {

        public ObjectId Id { get; set; }

        public DateTime CreatedAt => Id.CreationTime;
    }
}
