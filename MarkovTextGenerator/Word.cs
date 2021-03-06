using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkovTextGenerator
{
    public class Word 
    {
        private String word;
        public int Count { get; set; } = 1;
        public double Probability { get; set; } = 0.0;

        public Word (String word)
        {
            this.word = word;
        }

        public override string ToString()
        {
            return this.word;
        }
        
        public static int CompareByPopulation(Word word1, Word word2)
        {
            return word1.Probability.CompareTo(word2.Probability);
        }
    }
}
