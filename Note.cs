using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public struct Note
    {
        /// <summary>
        ///Serial number of the note
        /// </summary>
        public string number;
        /// <summary>
        /// The name of the person who wrote the note
        /// </summary>
        public string name;
        /// <summary>
        ///Note subject
        /// </summary>
        public string theme;
        /// <summary>
        /// The note
        /// </summary>
        public string text;
        /// <summary>
        ///Date the note was written
        /// </summary>
        public DateTime data;




        /// <summary>
        /// Creating a note
        /// </summary>
        /// <param name="number"></param>
        /// <param name="name"></param>
        /// <param name="theme"></param>
        /// <param name="text"></param>
        /// <param name="data"></param>
        public Note(string number, string name, DateTime data, string theme, string text)
        {
            this.number = number;
            this.name = name;
            this.theme = theme;
            this.text = text;
            this.data = data;
        }

        public string Print()
        {
            return $"№ {this.number,1} Name: {this.name,1} Date: {this.data,10} Theme: {this.theme,1} Text: {this.text,1}";
        }
    }
}
