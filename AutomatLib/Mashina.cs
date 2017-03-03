using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatLib
{
      public class Mashina
    {
        enum State { s0, s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11, s12, s13, s14, s15, s16 };
        enum Symbol { plus, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, space, otkr, zakr, Other };
        readonly static HashSet<State> final_states = new HashSet<State>() { State.s6 };
        readonly static State[,] table = {
        /*0*/    {State.s0, State.s0, State.s0,State.s0, State.s0, State.s0,State.s0, State.s0, State.s0,State.s0, State.s0, State.s0,State.s0, State.s0 ,State.s0},
        /*1*/    {State.s14, State.s7, State.s2,State.s2, State.s2, State.s2,State.s2, State.s2, State.s2,State.s2, State.s2, State.s1,State.s0, State.s0,State.s0 },
        /*2*/    {State.s0, State.s3, State.s3,State.s3, State.s3, State.s3,State.s3, State.s3, State.s3,State.s3, State.s3, State.s2,State.s0, State.s0,State.s0 },
        /*3*/    {State.s0, State.s4, State.s4,State.s4, State.s4, State.s4,State.s4, State.s4, State.s4,State.s4, State.s4, State.s3,State.s0, State.s0,State.s0 },
        /*4*/    {State.s0, State.s5, State.s5,State.s5, State.s5, State.s5,State.s5, State.s5, State.s5,State.s5, State.s5, State.s4,State.s0, State.s0,State.s0 },
        /*5*/    {State.s0, State.s6, State.s6,State.s6, State.s6, State.s6,State.s6, State.s6, State.s6,State.s6, State.s6, State.s5,State.s0, State.s0,State.s0 },
        /*6*/    {State.s0, State.s0, State.s0,State.s0, State.s0, State.s0,State.s0, State.s0, State.s0,State.s0, State.s0, State.s6,State.s0, State.s0,State.s0 },
        /*7*/    {State.s0, State.s0, State.s0,State.s0, State.s0, State.s0,State.s0, State.s0, State.s0,State.s0, State.s0, State.s7,State.s8, State.s0,State.s0 },
        /*8*/    {State.s0, State.s9, State.s9,State.s9, State.s9, State.s9,State.s9, State.s9, State.s9,State.s9, State.s9, State.s8,State.s0, State.s0,State.s0 },
        /*9*/    {State.s0, State.s10, State.s10,State.s10, State.s10, State.s10,State.s10, State.s10, State.s10,State.s10, State.s10, State.s9,State.s0, State.s0,State.s0 },
        /*10*/   {State.s0, State.s11, State.s11,State.s11, State.s11, State.s11,State.s11, State.s11, State.s11,State.s11, State.s11, State.s10,State.s0, State.s0,State.s0 },
        /*11*/   {State.s0, State.s0, State.s0,State.s0, State.s0, State.s0,State.s0, State.s0, State.s0,State.s0, State.s0, State.s11,State.s0, State.s12,State.s0 },
        /*12*/   {State.s0, State.s0, State.s13,State.s13, State.s13, State.s13,State.s13, State.s13, State.s13,State.s13, State.s13, State.s12,State.s0, State.s0,State.s0 },
        /*13*/   {State.s0, State.s0, State.s3,State.s3, State.s3, State.s3,State.s3, State.s3, State.s3,State.s3, State.s3, State.s13,State.s0, State.s0,State.s0 },
        /*14*/   {State.s0, State.s0, State.s0,State.s0, State.s15, State.s0,State.s0, State.s0, State.s0,State.s0, State.s0, State.s14,State.s0, State.s0,State.s0 },
        /*15*/   {State.s0, State.s0, State.s0,State.s0, State.s0, State.s0,State.s0, State.s0, State.s16,State.s0, State.s0, State.s15,State.s0, State.s0,State.s0 },
        /*16*/   {State.s0, State.s0, State.s0,State.s0, State.s7, State.s0,State.s0, State.s0, State.s0,State.s0, State.s0, State.s16,State.s0, State.s0,State.s0 },
            };
        static Symbol Classify(char c)
        {
            if (c == '+')
                return Symbol.plus;
            else if (c == '0')
                return Symbol.t0;
            else if (c == '1')
                return Symbol.t1;
            else if (c == '2')
                return Symbol.t2;
            else if (c == '3')
                return Symbol.t3;
            else if (c == '4')
                return Symbol.t4;
            else if (c == '5')
                return Symbol.t5;
            else if (c == '6')
                return Symbol.t6;
            else if (c == '7')
                return Symbol.t7;
            else if (c == '8')
                return Symbol.t8;
            else if (c == '9')
                return Symbol.t9;
            else if (c == ' ')
                return Symbol.space;
            else if (c == '(')
                return Symbol.otkr;
            else if (c == ')')
                return Symbol.zakr;
            else
                return Symbol.Other;
        }
        public static bool Match(string text)
        {
            State state = State.s1;
            foreach (var c in text)
            {
                var s = Classify(c);
                state = table[(int)state, (int)s];

            }
            return final_states.Contains(state);
        }
    }
}
