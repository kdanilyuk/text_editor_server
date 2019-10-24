using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using textedb.Models;

namespace textedb.Services
{
    public class DocumentService
    {
        public async Task<ValidityResponse> SaveDoc(Document doc)
        {
            ValidityResponse response;
            using(DocumentContext db = new DocumentContext())
            {
                var documents = db.Documents;
                if (!documents.Select(x => x.Name == doc.Name && x.Owner == doc.Owner).Any())
                {
                    db.Documents.Add(doc);
                    response = new ValidityResponse("true");
                }
                else
                {
                    response = new ValidityResponse("false");
                }
            }

            return response;
        }
    }
}
