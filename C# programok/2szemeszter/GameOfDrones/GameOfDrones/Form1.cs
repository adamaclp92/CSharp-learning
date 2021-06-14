using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfDrones
{
    public partial class Form1 : Form
    {
        List<Drone> drones = new List<Drone>();

        public Form1()
        {
            StreamReader reader = null;
            string[] tokens;

            try
            {
                reader = new StreamReader("uavs.txt");
                while (!reader.EndOfStream)
                {
                    tokens = reader.ReadLine().Split(';');
                    switch (tokens.Length)
                    {
                        case 5:
                            drones.Add(new SpectatorDrone(
                                                    ushort.Parse(tokens[0]),
                                                    tokens[1],
                                                    new PointF(float.Parse(tokens[2]), float.Parse(tokens[3])),
                                                    bool.Parse(tokens[4])
                                                    ));
                            break;
                        case 6:
                            drones.Add(new FighterDrone(
                                                    ushort.Parse(tokens[0]),
                                                    tokens[1],
                                                    new PointF(float.Parse(tokens[2]), float.Parse(tokens[3])),
                                                    byte.Parse(tokens[4]),
                                                    float.Parse(tokens[5])
                                                    ));
                            break;
                        default:
                            throw new ArgumentException("A txt fájl sora nem megfelelő hosszú");
                    }
                }
            }
            catch (NegativeValueException e)
            {
                MessageBox.Show(string.Format("Nem megengedett negatív érték: {0}", e.value));
            }
            catch (TooShortStringException e)
            {
                MessageBox.Show(string.Format("Túl rövid string: {0}", e.Text));
            }
            catch (FileNotFoundException e)
            {
                MessageBox.Show(string.Format("A fájl nem található: {0}", e.FileName));
            }
            catch (FormatException e)
            {
                MessageBox.Show(string.Format("Parse-olási hiba: {0}", e.StackTrace));
            }
            catch (Exception e)
            {
                MessageBox.Show(string.Format("Egyéb hiba: {0}", e.StackTrace));
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }

            reader = null;
            try
            {
                reader = new StreamReader("commands.txt");
                while (!reader.EndOfStream)
                {
                    tokens = reader.ReadLine().Split(';');

                    Drone drone = drones.First(d => d.Id == ushort.Parse(tokens[0]));
                    Command command = (Command)Enum.Parse(typeof(Command), tokens[1]);
                    switch (command)
                    {
                        case Command.Fly:
                            drone.Fly(float.Parse(tokens[2]), float.Parse(tokens[3]));
                            break;
                        case Command.Photo:
                            if (drone is ISpectate)
                                (drone as ISpectate).TakePicture((Spectrum)Enum.Parse(typeof(Spectrum), tokens[2]));
                            break;
                        case Command.Shoot:
                            Drone drone2 = drones.First(d => d.Id == ushort.Parse(tokens[2]));
                            if (drone is IFighter)
                                (drone as IFighter).Shoot(drone2);
                            break;
                    }
                }
            }
            catch (OutOfShootingRangeException e)
            {
                MessageBox.Show(string.Format("A {0} drón lőtávolságán kívül van a {1} drón", e.fighterDrone.Name, e.targetDrone.Name));
            }
            catch (Exception e)
            {
                MessageBox.Show("DEFINIÁLATLAN HIBA!!!!!!!!");
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }


            // Végső kiiratások

            InitializeComponent();

            listBox1.DataSource = drones;

        }
    }
}
