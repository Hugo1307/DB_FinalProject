using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD_FinalProject.Utils
{

    public class HistoryItem
    {

        private Document document;
        private Action action;

        public HistoryItem(Document document, Action action)
        {
            this.document = document;
            this.action = action;
        }

        public Document Document { get => document; set => document = value; }
        public Action Action { get => action; set => action = value; }

    }

}
