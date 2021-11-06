using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Boltos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Termekek> legolcsobb = new List<Termekek>();

            string[] arr = Directory.GetFiles(@".\boltok\", "*.txt");
            int i = 1;
            foreach (string file in arr)
            {

                StreamReader olvas = new StreamReader(@file);
                while (!olvas.EndOfStream)
                {
                    string szoveg = olvas.ReadLine();
                    string[] segéd = szoveg.Split('|');
                    var file3 = System.IO.Path.GetFileName(file);
                    string file2 = file3.Substring(0, file3.Length - 4);

                    if (i == 1)
                    {
                        // Console.WriteLine("Most ures");
                        legolcsobb.Add(new Termekek(segéd[0], Convert.ToInt32(segéd[1]), file2));
                    }
                    else

                    {
                        bool letezik = false;
                        for (int l = legolcsobb.Count - 1; l >= 0; l--)
                        {

                            Console.WriteLine(legolcsobb[l].getNev() + legolcsobb[l].getAr() + legolcsobb[l].getBoltsorszam());
                            if (legolcsobb[l].getNev() == segéd[0])
                            {
                                letezik = true;
                                if (Convert.ToInt32(segéd[1]) < legolcsobb[l].getAr())
                                {
                                    //l.setNev(segéd[0]);
                                    legolcsobb[l].setAr(Convert.ToInt32(segéd[1]));
                                    legolcsobb[l].setBoltsorszam(file2);
                                }
                            }


                        }
                        if (!letezik)
                        {
                            legolcsobb.Add(new Termekek(segéd[0], Convert.ToInt32(segéd[1]), file2));
                        }
                    }
                    Console.WriteLine();
                    // legolcsobb.Add(new Termekek(segéd[0], Convert.ToInt32(segéd[1]), i));
                }
                i++;
                olvas.Close();
            }

            Console.WriteLine("************************-");

            foreach (Termekek k in legolcsobb)
            {
                // Console.WriteLine("Akkor most már nem");
                Console.WriteLine(k.getNev() + " " + k.getAr() + " " + k.getBoltsorszam());
            }
        }
    }
}
