using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public struct Repository
    {
        private Note[] Notes;

       // private List <Note> newnotes ;

        private string path;

        int index;
        string[] titles;

        /*  public Repository(string Path)
          {
              this.path = Path;
              this.index = 0;
              this.titles = new string[5];
              this.newnotes = new List<Note>();
          }

          */
        public Repository(string Path)
        {
            this.path = Path;
            this.index = 0;
            this.titles = new string[5];
            this.Notes = new Note[2];
        }



        private void Resize(bool Flag)
        {
           
       
            if (Flag)
            {
                Array.Resize(ref this.Notes, this.Notes.Length*2);

               
            }
        }

        /*   public void Add(Note ConcreteNote)
           {
               this.Resize(index >= this.newnotes.Count);
               this.newnotes=new List<Note> { ConcreteNote };
               this.index++;
           }
        */

        public void Add(Note ConcreteNote)
        {
            this.Resize(index >= this.Notes.Length);
            this.Notes[index] = ConcreteNote;
            this.index++;
        }



        /// <summary>
        /// Loading data from file
        /// </summary>
        /*   public void Load()

           {

               using (StreamReader sr = new StreamReader(this.path))
               {
                   titles = sr.ReadLine().Split(',');


                   while (!sr.EndOfStream)
                   {
                       string[] args = sr.ReadLine().Split(',');

                       Add(new Note(args[0], args[1], DateTime.Parse(args[2]), args[3], args[4]));
                   }
               }
           }*/
        public void Load()
        {
            using (StreamReader sr = new StreamReader(this.path))
            {
                titles = sr.ReadLine().Split(',');


                while (!sr.EndOfStream)
                {
                    string[] args = sr.ReadLine().Split(',');

                    Add(new Note(args[0], args[1], DateTime.Parse(args[2]), args[3], args[4]));
                }
            }
        }

        /// <summary>
        /// Console output
        /// </summary>
        /*  public void PrintDbToConsole()
          {
               Console.WriteLine($"{this.titles[0],15} {this.titles[1],15} {this.titles[2],15} {this.titles[3],15} {this.titles[4],15}");

              for (int i = 0; i < index; i++)
              {
                  Console.WriteLine(this.newnotes[i].Print());
              }

          }*/
        public void PrintDbToConsole()
        {
            Console.WriteLine($"{this.titles[0],15} {this.titles[1],15} {this.titles[2],15} {this.titles[3],15} {this.titles[4],15}");

            for (int i = 0; i < index; i++)
            {
                Console.WriteLine(this.Notes[i].Print());
            }

        }


    }
}
