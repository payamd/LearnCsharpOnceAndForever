using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCsharpOneTimeAndForever.Classes
{
    class Postmsg
    { 
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public int Vote { get; private set; }


        public Postmsg(string Title,string Description)
        {
            this.Title = Title;
            this.Description = Description;
            this.Date = DateTime.Now;
            this.Vote = 0;
        }

        public void up_vote() {
            this.Vote += 1;
        }

        public void updown_vote()
        {
            this.Vote -= 1;
        }

        public int vote()
        {
            return this.Vote;
        }


    }
}
