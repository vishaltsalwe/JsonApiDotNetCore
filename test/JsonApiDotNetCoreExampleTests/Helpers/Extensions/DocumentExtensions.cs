using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using JsonApiDotNetCore.Models;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Microsoft.EntityFrameworkCore.Storage;
using Database = Microsoft.EntityFrameworkCore.Storage.Database;

namespace JsonApiDotNetCoreExampleTests.Helpers.Extensions
{
    public static class DocumentExtensions
    {
        public static ResourceObject FindResource<TId>(this List<ResourceObject> included, string type, TId id)
        {
            var document = included.Where(documentData => (
                documentData.Type == type 
                && documentData.Id == id.ToString()
            )).FirstOrDefault();

            return document;
        }

        public static int CountOfType(this List<ResourceObject> included, string type) {
            return included.Where(documentData => documentData.Type == type).Count();
        }
    }
}
