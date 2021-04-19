using System;

namespace task04
{
    internal static class Program
    {
        private static void Main()
        {
            var accessKey = Console.ReadLine();
            DocumentWorker documentWorker;
            switch (accessKey)
            {
                case null:
                case "":
                    documentWorker = new DocumentWorker();
                    break;
                case "exp":
                    documentWorker = new ExpertDocumentWorker();
                    break;
                default:
                    documentWorker = new ProDocumentWorker();
                    break;
            }
            documentWorker.SaveDocument();
        }
    }
}
