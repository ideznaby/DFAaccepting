using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace DFAaccepting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool newstate=false;
        bool newarc=false;
        bool ismakeinitial = false;
        bool ismakefinal = false;
        public static Pen pen;
        public static Graphics g;
        DFA dfa;
        List<State> states = new List<State>();
        Dictionary<string, string> transitions = new Dictionary<string,string>();
        List<string> finals = new List<string>();
        List<string> alphabets = new List<string>();
        string initial;
        int size = 0;
        bool flag = false;
        Point arcstart;
        State startstate;
        List<Point> points = new List<Point>();
        #region Draw states and arcs
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (newstate)
            {
                if (e.X - 25 > 0 && e.Y - 25 > 0)
                {
                    State state = new State();
                    g.DrawEllipse(pen, e.X - 25, e.Y - 25, state.width, state.width);
                    state.x = e.X;
                    state.y = e.Y;
                    state.name = "S" + size;
                    states.Add(state);
                    Label l = new Label();
                    l.Text = state.name;
                    l.Parent = panel1;
                    l.Size = new System.Drawing.Size(20, 15);
                    l.Location = new Point(state.x-10, state.y-7);
                    size++;
                }
            }
            else if (newarc)
            {
                if (alphabet.Text == "")
                    MessageBox.Show("please insert the alphabet for this arc");
                else
                {
                    if (!alphabets.Contains(alphabet.Text))
                        alphabets.Add(alphabet.Text);
                    bool isononeofstates = false;
                    foreach (State S in states)
                    {
                        if (S.isonit(e.X, e.Y))
                        {
                            isononeofstates = true;
                            if (!flag)
                            {
                                points.Add(new Point(e.X,e.Y));
                                arcstart.X = e.X;
                                arcstart.Y = e.Y;
                                startstate = S;
                                flag = true;
                            }
                            else
                            {
                                if (transitions.ContainsKey(startstate.name + " " + alphabet.Text))
                                    MessageBox.Show("There can't be two arcs with same alphabet that is come out of a state");
                                else
                                {
                                    points.Add(new Point(e.X, e.Y));
                                    AdjustableArrowCap bigArrow = new AdjustableArrowCap(5, 5);
                                    pen.CustomEndCap = bigArrow;
                                    g.DrawCurve(pen, points.ToArray());
                                    transitions.Add(startstate.name + " " + alphabet.Text, S.name);
                                    Label l = new Label();
                                    l.Text = alphabet.Text;
                                    l.Parent = panel1;
                                    l.Size = new System.Drawing.Size(10, 15);
                                    if (points.Count == 3)
                                        l.Location = new Point(points[1].X, points[0].Y - points[1].Y > 0 ? points[1].Y - 10 : points[1].Y + 10);
                                    else
                                        l.Location = new Point((points[1].X + points[0].X) / 2, points[0].Y - points[1].Y > 0 ? points[1].Y - 10 : points[1].Y + 10);
                                }
                                points.Clear();
                                flag = false;
                            }
                        }

                    }
                    if (!isononeofstates)
                        if(points.Count == 1)
                            points.Add(new Point(e.X, e.Y));
                }
            }
            else if (ismakeinitial)
            {
                bool isononeofstates = false;
                foreach (State S in states)
                {
                    if (S.isonit(e.X, e.Y))
                    {
                        isononeofstates = true;
                        initial = S.name;
                        AdjustableArrowCap bigArrow = new AdjustableArrowCap(5, 5);
                        pen.CustomEndCap = bigArrow;
                        g.DrawLine(pen, S.x - 50, S.y, S.x-25, S.y);
                        makeinitial.Enabled = false;
                        ismakeinitial = false;
                        break;
                    }
                }
                if (!isononeofstates)
                    MessageBox.Show("please click on a state");
            }
            else if (ismakefinal)
            {
                bool isononeofstates = false;
                foreach (State S in states)
                {
                    if (S.isonit(e.X, e.Y))
                    {
                        isononeofstates = true;
                        if (!finals.Contains(S.name))
                        {
                            finals.Add(S.name);
                            g.DrawEllipse(pen, S.x- (S.width / 2 + 5), S.y - (S.width / 2 + 5), S.width + 10, S.width + 10);
                        }
                        break;
                    }
                }
                if (!isononeofstates)
                    MessageBox.Show("please click on a state");
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            g = panel1.CreateGraphics();
            pen = new Pen(Color.Black);
        }
        #endregion
        private void clear_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            transitions.Clear();
            alphabets.Clear();
            states.Clear();
            initial = "";
            finals.Clear();
            panel1.Controls.Clear();
            makeinitial.Enabled = true;
            size = 0;
        }

        private void clearpoints_Click(object sender, EventArgs e)
        {
            points.Clear();
        }
        #region left side buttons
        private void newstatebutton_Click(object sender, EventArgs e)
        {
            newstate = true;
            newarc = false;
            ismakeinitial = false;
            ismakefinal = false;
        }
        private void arcbutton_Click(object sender, EventArgs e)
        {
            newstate = false;
            newarc = true;
            ismakeinitial = false;
            ismakefinal = false;
        }
        private void makeinitial_Click(object sender, EventArgs e)
        {
            newstate = false;
            newarc = false;
            ismakeinitial = true;
            ismakefinal = false;
        }

        private void makefinal_Click(object sender, EventArgs e)
        {
            newstate = false;
            newarc = false;
            ismakeinitial = false;
            ismakefinal = true;
        }
        #endregion
        private static bool dfaaccepting(DFA dfa,String s)
        {
            int i = 0;
            String p = dfa.initial;
            int before = 0;
            string beyneparantez = "";
            bool parantez = false;
            while(i < s.Length)
            {
                if (parantez)
                    if(s[i] != ')')
                        beyneparantez += s[i];
                if (s[i] == '(')
                {
                    before = i;
                    parantez = true;
                }
                else if (s[i] == ')')
                {
                    parantez = false;
                    if (s[i + 1] == '*')
                    {
                            bool f = true;
                            string bejayestar = "";
                            for (int j = 0; j < dfa.size; j++)
                            {
                                f &= dfaaccepting(dfa, ((before > 0) ? s.Substring(0, before) : "") + bejayestar + s.Substring(i + 2, s.Length - i - 2));
                                bejayestar += beyneparantez;
                            }
                            return f;
                    }
                    else if (s[i + 1] == '+')
                    {
                        bool f = true;
                        string bejayeplus = beyneparantez + "";
                        for (int j = 0; j <= dfa.size; j++)
                        {
                            f &= dfaaccepting(dfa, ((before > 0) ? s.Substring(0,  before):"") + bejayeplus + s.Substring(i + 2, s.Length - i - 2));
                            bejayeplus += beyneparantez;
                        }
                        return f;
                    }
                }
                else if (s[i] == '+')
                {
                    if (dfa.transitions.ContainsKey(p + " " + s[i - 1]))
                    {
                        bool f = true;
                        string bejayeplus = s[i-1] + "";
                        for (int j = 0; j <= dfa.size; j++)
                        {
                            f &= dfaaccepting(dfa, s.Substring(0, i - 1) + bejayeplus + s.Substring(i + 1, s.Length - i - 1));
                            bejayeplus += s[i - 1];
                        }
                        return f;
                    }
                    else
                        return false;
                }
                else if (s[i] == '*')
                {
                    if (dfa.transitions.ContainsKey(p + " " + s[i - 1]))
                    {
                        bool f = true;
                        string bejayestar = "";
                        for (int j = 0; j < dfa.size; j++)
                        {
                            f &= dfaaccepting(dfa,s.Substring(0,i-1) + bejayestar +  s.Substring(i+1,s.Length - i -1));
                            bejayestar += s[i-1];
                        }
                        return f;
                    }
                    else
                        return false;
                }
                else if (dfa.transitions.ContainsKey(p + " " + s[i]))
                {
                        p = dfa.transitions[p + " " + s[i]];
                }
                else
                    return false;
                i++;
            }
            return dfa.finals.Contains(p);
        }
        private void isaccepting_Click(object sender, EventArgs e)
        {
            if (initial == "" || finals.Count == 0 || size == 0 || states.Count == 0 || alphabets.Count == 0)
                MessageBox.Show("please complete your dfa");
            else
            {
                if (transitions.Count != alphabets.Count * states.Count)
                    MessageBox.Show("the transitions aren't complete but the answer will be shown");
                dfa = new DFA(size, alphabets, transitions, initial, finals);
                bool isaccept = dfaaccepting(dfa, inputstring.Text);
                if (isaccept)
                    MessageBox.Show("This dfa is ACCEPTS this string '" + inputstring.Text + "'");
                else
                    MessageBox.Show("This dfa is REJECTS this string '" + inputstring.Text + "'");
            }
        }

    }
}
