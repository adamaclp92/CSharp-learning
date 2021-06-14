using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ragó_Ádám_zh
{
    class IngatlanNyilvantarto
    {
        List<Ingatlan> ingatlanok = new List<Ingatlan>();

        public int IngatlanCount
        {
            get
            {
                return ingatlanok.Count;
            }
        }

        public void Add(Ingatlan i)
        {

            ingatlanok.Add(i);

        }

       

        public int aLegdragabbIngatlan()
        {
            uint ar = 0;
            int index = 0;

            for (int i = 0; i < IngatlanCount; i++)
            {
                if (ingatlanok[i].Ar > ar)
                {   
                            ar = ingatlanok[i].Ar;
                            index = i;
                            
                }
            }
            return index;
        }

        public float termofoldAtlag(muvelesiAg muvelesiAg)
        {
            float atlag = 0;
            

            for (int i = 0; i < IngatlanCount; i++)
            {
                if (ingatlanok[i] is Termofold)
                {
                    Termofold t = ingatlanok[i] as Termofold;
                    if (t.MuvelesiAg == muvelesiAg)
                    {
                        atlag += t.TeruletNagysaga;
                          

                        
                    }
                }
            }
            return atlag / IngatlanCount;

        }

        public void bontandoEpulet(fajta fajta)
        {

            for (int i = 0; i < IngatlanCount; i++)
            {
                if (ingatlanok[i] is Lakoepulet)
                {
                    Lakoepulet l = ingatlanok[i] as Lakoepulet;
                    if (l.Fajta == fajta)
                    {
                        if (l.Bontando_e)

                            Console.WriteLine(ingatlanok[i]);
                    }

                }
            }
        }
        

        public Ingatlan this[int index]
        {
            get
            {
                return ingatlanok[index];
            }
        }

    
    }
}

/*

    Írj olyan property-t/metódust, mely hozzáad a rendszerhez egy új ingatlant!
    Írj olyan property-t/metódust, mely visszaadja a legdrágább ingatlant!
    Írj olyan property-t/metódust, mely paraméterként megkap egy művelési ágat (pl. szőlő), majd visszaadja azt, hogy az így művelt termőföldek átlagosan hány hektárosak!
    Írj olyan property-t/metódust, mely paraméterként megkap egy lakóépület fajtát (pl. társasház), majd visszaadja az ilyen fajtájú összes bontandó épületcímét!
*/