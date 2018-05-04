    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;


namespace practice{

        //public interface ITroops {

            //String GetName();
            //String Get_Type();
            //int GetDph();
            //int GetHl();
            //String GetPt();
            //int GetTd();

            //void SetName(String n);
            //void Set_Type(String t);
            //void SetDph(int d);
            //void SetHl(int h);
            //void SetPt(String p);
            //void SetTd(int total);

        //}

        public class Monkey: ITroops
            {
        

            protected String name;
            protected String type;
            protected int dph; //damage per hit
            protected int hl; // health
            protected String pt; // preferred target
            protected int td; //total damage

            public Monkey()
                {
                    name = "Monkey";
                    type = "Ground";
                    dph = 6;
                    hl = 50;
                    pt = "Ground";
                    td = 0;
                }
            public Monkey(String n, String t, int d, int h, String p)
                {
                    name = n;
                    type = t;
                    dph = d;
                    hl = h;
                    pt = p;
                    td = 0;
                }
            public String GetName ()
            {
                return name;
            }
            public String Get_Type()
            {
                return type;
            }
            public int GetDph()
            {
                return dph;
            }
            public int GetHl()
            {
                return hl;
            }
            public String GetPt()
            {
                return pt;
            }
            public int GetTd()
            {
                return td;
            }

            public void SetName(String n)
            {
                name = n;
            }
            public void Set_Type(String t)
            {
                type = t;
            }
            public void SetDph(int d)
            {
                dph = d;
            }
            public void SetHl(int h)
            {
                hl = h;
            }
            public void SetPt(String p)
            {
                pt = p;
            }
            public void SetTd(int total)
            {
                td = total;
            }

            }

        public class FlyingMonkey: Monkey, ITroops
            {
            
            public FlyingMonkey()
            {
                name = "Flying Monkey";
                type = "Air";
                pt = "Air";
            }

            }

        public class Wizard: ITroops
        {
            protected String name;
            protected String type;
            protected int dph; //damage per hit
            protected int hl; // health
            protected String pt; // preferred target
            protected int td; //total damage

            public Wizard()
            {
                name = "Wizard";
                type = "Ground";
                dph = 6;
                hl = 60;
                pt = "All";
                td = 0;
            }
            public Wizard(String n, String t, int d, int h, String p)
            {
                name = n;
                type = t;
                dph = d;
                hl = h;
                pt = p;
                td = 0;
            }
            public String GetName()
            {
                return name;
            }
            public String Get_Type()
            {
                return type;
            }
            public int GetDph()
            {
                return dph;
            }
            public int GetHl()
            {
                return hl;
            }
            public String GetPt()
            {
                return pt;
            }
            public int GetTd()
            {
                return td;
            }

            public void SetName(String n)
            {
                name = n;
            }
            public void Set_Type(String t)
            {
                type = t;
            }
            public void SetDph(int d)
            {
                dph = d;
            }
            public void SetHl(int h)
            {
                hl = h;
            }
            public void SetPt(String p)
            {
                pt = p;
            }
            public void SetTd(int total)
            {
                td = total;
            }

        }

        public class Balloon: ITroops
        {
            protected String name;
            protected String type;
            protected int dph; //damage per hit
            protected int hl; // health
            protected String pt; // preferred target
            protected int td; //total damage

            public Balloon()
            {
                name = "Balloon";
                type = "Air";
                dph = 8;
                hl = 55;
                pt = "Ground";
                td = 0;
            }
            public Balloon(String n, String t, int d, int h, String p)
            {
                name = n;
                type = t;
                dph = d;
                hl = h;
                pt = p;
                td = 0;
            }
            public String GetName()
            {
                return name;
            }
            public String Get_Type()
            {
                return type;
            }
            public int GetDph()
            {
                return dph;
            }
            public int GetHl()
            {
                return hl;
            }
            public String GetPt()
            {
                return pt;
            }
            public int GetTd()
            {
                return td;
            }

            public void SetName(String n)
            {
                name = n;
            }
            public void Set_Type(String t)
            {
                type = t;
            }
            public void SetDph(int d)
            {
                dph = d;
            }
            public void SetHl(int h)
            {
                hl = h;
            }
            public void SetPt(String p)
            {
                pt = p;
            }
            public void SetTd(int total)
            {
                td = total;
            }

        }

        public class Battle
        {
            //troop1 - belongs to army1
            String name1;
            String type1;
            int dph1;
            int hl1;
            String pt1;
            int td1;
            //troop2 - belongs to army2
            String name2;
            String type2;
            int dph2;
            int hl2;
            String pt2;
            int td2;

            public void SendToBattle(ITroops t1, ITroops t2)
            {
                //getting values of troop1
                name1 = t1.GetName();
                type1 = t1.Get_Type();
                dph1 = t1.GetDph();
                hl1 = t1.GetHl();
                pt1 = t1.GetPt();
                td1 = t1.GetTd();

                //getting values of troop2
                name2 = t2.GetName();
                type2 = t2.Get_Type();
                dph2 = t2.GetDph();
                hl2 = t2.GetHl();
                pt2 = t2.GetPt();
                td2 = t2.GetTd();

                Engage();

                //updating with new values
                //troop1 new values
                t1.SetDph(dph1);
                t1.SetHl(hl1);
                t1.SetTd(td1);
                //troop2 new values
                t2.SetDph(dph2);
                t2.SetHl(hl2);
                t2.SetTd(td2);
            }

            void Engage()
            {
                //troop1 attacks troop2
                if(name1.Equals("Wizard")) //preferred target isn't an issue with the wizard.
                {
                    if(dph1>hl2) // case where the defender dies & total damage of attacker is increased by the value of health of defender before dying.
                    {
                        td1 += hl2;
                        hl2 = 0;
                    }
                    else{
                        td1 += dph1;
                        hl2 -= dph1;
                    }
                }
                else if(!pt1.Equals(type2,StringComparison.OrdinalIgnoreCase)) //case where the defender is not attacker's preferred target.
                {
                    if ((dph1/2)>hl2) // case where the defender dies & total damage of attacker is increased by the value of health of defender before dying.
                    {
                        td1 += hl2;
                        hl2 = 0;
                    }
                    else {
                        td1 += (dph1 / 2);
                        hl2 -= (dph1 / 2);
                    }

                }
                else {              // case where the defender is attacker's preferred target.
                    if (dph1 > hl2) // case where the defender dies & total damage of attacker is increased by the value of health of defender before dying.
                    {
                        td1 += hl2;
                        hl2 = 0;
                    }
                    else{
                    td1 += dph1;
                    hl2 -= dph1;
                    }
                }

                //troop2 attacks troop1
                if (name2.Equals("Wizard")) //preferred target isn't an issue with the wizard.
                {
                    if (dph2 > hl1) // case where the defender dies & total damage of attacker is increased by the value of health of defender before dying.
                    {
                        td2 += hl1;
                        hl1 = 0;
                    }
                    else
                    {
                        td2 += dph2;
                        hl1 -= dph2;
                    }
                }
                else if (!pt2.Equals(type1, StringComparison.OrdinalIgnoreCase)) //case where the defender is not attacker's preferred target.
                {
                    if ((dph2 / 2) > hl1) // case where the defender dies & total damage of attacker is increased by the value of health of defender before dying.
                    {
                        td2 += hl1;
                        hl1 = 0;
                    }
                    else
                    {
                        td2 += (dph2 / 2);
                        hl1 -= (dph2 / 2);
                    }

                }
                else                // case where the defender is attacker's preferred target.
                {
                    if (dph2 > hl1) // case where the defender dies & total damage of attacker is increased by the value of health of defender before dying.
                    {
                        td2 += hl1;
                        hl1 = 0;
                    }
                    else
                    {
                        td2 += dph2;
                        hl1 -= dph2;
                    }
                }
            }
            
        }

        public class Program
        {
            static void Main(string[] args)
            {
                // creating armies.

                Queue<ITroops> army1 = new Queue<ITroops>();
                Queue<ITroops> army2 = new Queue<ITroops>();

                //assigning troops to army1.
                int i=0;
                while(i<20)
                {
                    switch(i%4)
                    {
                        case 0: army1.Enqueue(new Monkey());
                            break;
                        case 1: army1.Enqueue(new FlyingMonkey());
                            break;
                        case 2: army1.Enqueue(new Wizard());
                            break;
                        case 3: army1.Enqueue(new Balloon());
                            break;
                    }
                    i++;
                }

                //assigning troops to army2.
                i = 0;
                while (i < 20)
                {
                    switch (i % 4)
                    {
                        case 0:
                            army2.Enqueue(new FlyingMonkey());
                            break;
                        case 1:
                            army2.Enqueue(new Wizard());
                            break;
                        case 2:
                            army2.Enqueue(new Balloon());
                            break;
                        case 3:
                            army2.Enqueue(new Monkey());
                            break;
                    }
                    i++;
                }

                // printing both the armies on the console.
                i = 1;
                Console.WriteLine("Army 1 - Initial Troops");
                foreach (ITroops obj in army1)
                {
                    Console.WriteLine("{0}. {1}",i, obj.GetName());
                    i++;
                }

                i = 1;
                Console.WriteLine("\nArmy 2 - Initial Troops");
                foreach (ITroops obj in army2)
                {
                    Console.WriteLine("{0}. {1}", i, obj.GetName());
                    i++;
                }

                //battle starts.
                i = 1;
                Battle battle = new Battle();
                Console.WriteLine("\n\n\nBATTLE\n");
                while(army1.Count>0 && army2.Count>0)
                {
                    ITroops t1 = army1.Dequeue();
                    ITroops t2 = army2.Dequeue();

                    //Round starts.
                    Console.WriteLine("Round {0}: Player 1 {1} (health = {2}, totalDamage = {3}) vs. Player 2 {4} (health = {5}, totalDamage = {6}) ", 
                                      i,t1.GetName(), t1.GetHl(), t1.GetTd(), t2.GetName(), t2.GetHl(), t2.GetTd());
                    battle.SendToBattle(t1, t2);

                    if (t1.GetHl()>0)
                    {
                        army1.Enqueue(t1);
                    }
                    else{
                        Console.WriteLine("\t\tPlayer 1 {0} was killed!!", t1.GetName());
                    }

                    if (t2.GetHl() > 0)
                    {
                        army2.Enqueue(t2);
                    }
                    else
                    {
                        Console.WriteLine("\t\tPlayer 2 {0} was killed!!", t2.GetName());

                    }

                    i++;
                    //Round ends.
                }
                //battle ends.

                //determining the wining army.
                Console.WriteLine("\n \nWINNER\n");

                if (army1.Count>0)
                {
                    Console.WriteLine("Army 1 is the winner. Remaining troops:");
                }
                else {
                    Console.WriteLine("Army 2 is the winner. Remaining troops:");
                    army1 = army2;
                }

                i = 1;
                ITroops winner = null; 
                int max = int.MinValue;
                while(army1.Count>0)
                {
                    ITroops temp = army1.Dequeue();
                    Console.WriteLine("{0}. {1}, health = {2}, totalDamage = {3}", i++, temp.GetName(), temp.GetHl(), temp.GetTd());

                    //finding the most outstanding troop. 
                    String binary = Convert.ToString(temp.GetTd(), 2);
                    String[] binarray = Regex.Split(binary, @"0+");
                    int ctr = 0;
                    foreach(String bin in binarray )
                    {
                        ctr = bin.Length > ctr ? bin.Length : ctr;
                    }
                    if (ctr>max)
                    {
                        max = ctr;
                        winner = temp;
                    }
                }

                Console.WriteLine("\n \nThe most Outstanding Troop is:");
                Console.WriteLine("{0}, health = {1}, totalDamage = {2}", winner.GetName(), winner.GetHl(), winner.GetTd());

                //end of main.
            }

        }
    }
