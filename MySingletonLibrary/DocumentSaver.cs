using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySingletonLibrary
{
    public sealed class DocumentSaver
    {
        private static readonly DocumentSaver instance = new DocumentSaver();

        public static DocumentSaver Instance => instance;

        private DocumentSaver() { }

        public string SaveDocument(string content)
        {
            return $"Document saved with content: {content}";
        }
    }
}
