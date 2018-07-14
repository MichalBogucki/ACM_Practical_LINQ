using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.Library
{
    public class Builder
    {
        public IEnumerable<int> BuildIntegerSequence()
        {
            //var integers = Enumerable.Range(0, 10)
            //    .Select(i => 5+(10*i));

            var integers = Enumerable.Repeat(-1, 10);
            return integers;
        }

        public IEnumerable<string> BuildStringSequence()
        {
            var strings = Enumerable.Range(0, 10)
                .Select(i => ((char) ('A' + i)).ToString());

            return strings;
        }
        public IEnumerable<string> BuildRandomStringSequence()
        {
            //Random rand = new Random();
            //var strings = Enumerable.Range(0, 10)
            //    .Select(i => ((char)('A' + rand.Next(0, 26))).ToString());

            var strings = Enumerable.Repeat("A", 10);
            return strings;
        }

        public IEnumerable<int> CompareSequences()
        {
            var seq1 = Enumerable.Range(0, 10);
            var seq2 = Enumerable.Range(0, 10)
                .Select(i => i * i);

            return seq2.Union(seq1).OrderByDescending(i => i);
            //przedPosortowaniem {0, 1, 4, 9, 16, 25, 36, 49, 64, 81, 2, 3, 5, 6, 7, 8}

            //return seq1.Concat(seq2).Distinct(); //toSamoCoUNION()
            //return seq1.Concat(seq2); //dodajeDruga_NaKoniec_Pierwszej {0, 1, 2, .. 9,     0, 1, 4, 9, 25, .. 81}
            //return seq1.Except(seq2); //różnica
            //return seq1.Intersect(seq2); //cześćWspólna
        }
    }
}
