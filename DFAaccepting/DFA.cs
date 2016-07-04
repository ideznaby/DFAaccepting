using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DFAaccepting
{
    class DFA
    {
        public int size;//the number of states in DFA
        public List<string> alphabets;//alphabets used in this DFA
        public Dictionary<string, string> transitions = new Dictionary<string, string>();//transitions in this DFA
        public String initial;//initial state of DFA
        public List<string> finals;//set of accepted states of DFA
        public DFA(int _size, List<string> _alphabets, Dictionary<string, string> _transitions, String _initial, List<string> _finals)
        {//constructor that gives values to parameters defined above
            size = _size;
            alphabets = _alphabets;
            transitions = _transitions;
            initial = _initial;
            finals = _finals;
        }
    }
}
