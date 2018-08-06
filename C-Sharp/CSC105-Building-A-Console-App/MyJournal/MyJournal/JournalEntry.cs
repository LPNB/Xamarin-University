using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyJournal
{
    class JournalEntry
    {
        // fields
        private string text;
 
        // properties
        public string Text
        {
            get { return text; }
            set
            {
                // every time the Text property is changed, update LastEditTime property
                text = value;
                LastEditTime = DateTime.Now;
            }
        }
        public DateTime LastEditTime { get; set; }
    }
}
