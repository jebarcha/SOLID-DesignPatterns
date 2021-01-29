using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._4_Behavioral_Patterns.ChainOfResponsibility.Demo2
{
    class HandleDocumentsChOfRDemo
    {
    }
    public class Document
    {
        public string Name { get; }
        public string Content { get; }

        public Document(string name, string content)
        {
            Content = content;
            Name = name;
        }
    }

    public abstract class Handler
    {
        protected Handler successor;

        public void SetSuccessor(Handler successor)
        {
            this.successor = successor;
        }

        public abstract string HandleRequest(Document document);

    }

    public class Editor : Handler
    {
        public override string HandleRequest(Document document)
        {
            if (document.Content.Length < 10)
            {
                return $"Documento {document.Name} revisado por {this.GetType().Name}";

            }
            else if (successor != null)
            {
                return successor.HandleRequest(document);
            }
            return "";
        }

    }

    public class Executive : Handler
    {

        public override string HandleRequest(Document document)
        {
            if (document.Content.Length >= 10)
            {
                return $"Documento {document.Name} revisado por {this.GetType().Name}";
            }
            else if (successor != null)
            {
                return successor.HandleRequest(document);
            }

            return "";
        }
    }

}
