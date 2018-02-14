using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Læringsapplikasjon
{
    class Quiz
    {
        private string file;
        private int questionNr;

        public Quiz(string jsonFile,int qstNr)
        {
            file = jsonFile;
            questionNr = qstNr;

        }
    }
}
