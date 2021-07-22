using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using JR.Utils.GUI.Forms;

namespace Smash_Up_Randomizer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        Random rnd = new Random();
        int[] packs = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
        List<string> pot = new List<string>();
        string[] core = { "Aliens", "Dinosaurs", "Ninjas", "Pirates*", "Robots", "Tricksters*", "Wizards*", "Zombies" };
        string[] al9k = { "Bear Cavalry*", "Ghosts*", "Killer Plants", "Steampunks" };
        string[] ocs = { "Elder Things", "Innsmouth*", "Minions of Cthulu*", "Miskatonic University" };
        string[] sfdf = { "Cyborg Apes", "Shapeshifters", "Super Spies*", "Time Travelers*" };
        string[] bgb = { "Geeks" };
        string[] ms = { "Giant Ants*", "Mad Scientists", "Vampires*", "Werewolves*" };
        string[] ppsu = { "Fairies*", "Kitty Cats", "Mythic Horses", "Princesses" };
        string[] sum = { "Clerics", "Dwarves", "Elves", "Halflings", "Mages", "Orcs", "Thieves", "Warriors" };
        string[] iyf = { "Dragons", "Mythic Greeks", "Sharks", "Superheroes", "Tornadoes" };
        string[] cad = { "Astroknights", "Changerbots*", "Ignobles*", "Star Roamers" };
        string[] wwwt = { "Explorers*", "Grannies", "Rock Stars", "Teddy Bears" };
        string[] asek = { "All Stars" };
        string[] bij = { "Itty Critters*", "Kaiju*", "Magical Girls*", "Mega Troopers*" };
        string[] sp = { "Sheep" };
        string[] t70e = { "Disco Dancers", "Kung Fu Fighters", "Truckers", "Vigilantes" };
        string[] oydia = { "Ancient Egyptians", "Samurai", "Cowboys", "Vikings" };
        string[] wtii = { "Luchadors", "Mounties", "Musketeers", "Sumo Wrestlers" };
        string[] sup = { "Penguins*" };
        string[] wtcs = { "Anansi Tales", "Ancient Incas", "Grimms' Fairy Tales", "Polynesian Voyagers", "Russian Fairy Tales" };
        string[] supma = { "Avengers", "Hydra", "Kree", "Masters of Evil", "S.H.I.E.L.D.", "Sinister Six", "Spider-Verse", "Ultimates" };
        string[] sug = { "Goblins" };

        private void labels(object sender, RoutedEventArgs e)
        {
            sheet.Margin = new Thickness(393, 182, 393, 0);
        }

        public int randNum(int x)
        {
            int rand = rnd.Next(0, x);
            return rand;
        }

        public void fillPot(string[] str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                pot.Add(str.ElementAt(i));
            }
        }

        public void fillPot()
        {
            if (Fac1.IsChecked == true)
                fillPot(core);
            if (Fac2.IsChecked == true)
                fillPot(al9k);
            if (Fac3.IsChecked == true)
                fillPot(ocs);
            if (Fac4.IsChecked == true)
                fillPot(sfdf);
            if (Fac5.IsChecked == true)
                fillPot(bgb);
            if (Fac6.IsChecked == true)
                fillPot(ms);
            if (Fac7.IsChecked == true)
                fillPot(ppsu);
            if (Fac8.IsChecked == true)
                fillPot(sum);
            if (Fac9.IsChecked == true)
                fillPot(iyf);
            if (Fac10.IsChecked == true)
                fillPot(cad);
            if (Fac11.IsChecked == true)
                fillPot(wwwt);
            if (Fac12.IsChecked == true)
                fillPot(asek);
            if (Fac13.IsChecked == true)
                fillPot(bij);
            if (Fac14.IsChecked == true)
                fillPot(sp);
            if (Fac15.IsChecked == true)
                fillPot(t70e);
            if (Fac16.IsChecked == true)
                fillPot(oydia);
            if (Fac17.IsChecked == true)
                fillPot(wtii);
            if (Fac18.IsChecked == true)
                fillPot(sup);
            if (Fac19.IsChecked == true)
                fillPot(wtcs);
            if (Fac20.IsChecked == true)
                fillPot(supma);
            if (Fac21.IsChecked == true)
                fillPot(sug);
        }

        public int TotalLength()
        {
            int length = core.ToArray().Length + al9k.ToArray().Length + ocs.ToArray().Length + sfdf.ToArray().Length + bgb.ToArray().Length +
                ms.ToArray().Length + ppsu.ToArray().Length + sum.ToArray().Length + iyf.ToArray().Length + cad.ToArray().Length + wwwt.ToArray().Length +
                asek.ToArray().Length + bij.ToArray().Length + sp.ToArray().Length + t70e.ToArray().Length + oydia.ToArray().Length + wtii.ToArray().Length +
                sup.ToArray().Length + wtcs.ToArray().Length + supma.ToArray().Length + sug.ToArray().Length;
            return length;
        }

        public int ListLength(List<string> str)
        {
            int length = str.ToArray().Length;
            return length;
        }

        public void reset()
        {
            int length = ListLength(pot);
            for (int i = length - 1; i >= 0; i--)
            {
                pot.RemoveAt(i);
            }
        }

        List<string> randomize(List<string> vec, int n, List<string> choices)
        {
            int size = ListLength(vec), x = randNum(size);
            if (n > ListLength(choices))
            {
                choices.Add(vec.ElementAt(x));
                vec.RemoveAt(x);
                return randomize(vec, n, choices);
            }
            else
                return choices;
        }

        /*string BaseExpansions(List<string> vec)
        {
            string bases = "";
            int coreSet = 0, al9kSet = 0, ocsSet = 0, sfdfSet = 0, bgbSet = 0;//, msSet = 0, ppsuSet = 0, sumSet = 0, iyfSet = 0, cadSet = 0, 
                //wwwtSet = 0, asekSet = 0, bijSet = 0, spSet = 0, t70eSet = 0, oydiaSet = 0, wtiiSet = 0, supSet = 0, wtcsSet = 0, supmaSet = 0;
            for (int i = 0; i < ListLength(vec); i++)
            {
                for (int j = 0; j < core.ToArray().Length; j++)
                {
                    if (vec.ElementAt(i) == core[j])
                        coreSet++;
                }

                for (int j = 0; j < al9k.ToArray().Length; j++)
                {
                    if (vec.ElementAt(i) == core[j])
                        al9kSet++;
                }

                for (int j = 0; j < ocs.ToArray().Length; j++)
                {
                    if (vec.ElementAt(i) == core[j])
                        ocsSet++;
                }

                for (int j = 0; j < sfdf.ToArray().Length; j++)
                {
                    if (vec.ElementAt(i) == core[j])
                        sfdfSet++;
                }

                for (int j = 0; j < bgb.ToArray().Length; j++)
                {
                    if (vec.ElementAt(i) == core[j])
                        bgbSet++;
                }
            }
            if (coreSet > 0)
            {
                bases += "Core Set, ";
                coreSet = 0;
            }
            if (al9kSet > 0)
            { 
                bases += "Awesome Level 9000, ";
                al9kSet = 0;
            }
            if (ocsSet > 0)
            { 
                bases += "Obligatory Cthulhu Set, ";
                ocsSet = 0;
            }
            if (sfdfSet > 0)
            { 
                bases += "Science Fiction Double Feature, ";
                sfdfSet = 0;
            }
            if (bgbSet > 0)
            { 
                bases += "Big Geeky Box, ";
                bgbSet = 0;
            }
            bases = bases.Substring(0, bases.Length - 2);
            return bases;
        }*/

        public void randomizer(List<string> vec, int n, int o, List<string> choices)
        {
            int p = n * o;
            List<string> vec2;
            string str = "";//, bases = "";
            vec2 = randomize(vec, p, choices);
            //bases = BaseExpansions(vec2);
            str += "Your choices are:\n";
            for (int i = 0; i < n; i++)
            {
                str += "\n\nPlayer " + (i + 1) + ": ";
                /*for (int j = 0; j < ListLength(vec2) - 1; j++)
                {
                    str += vec2.ElementAt(j) + ", ";
                }*/
                for (int j = 0; j < o - 1; j++)
                {
                    str += vec2.ElementAt(j) + ", ";
                }
                str += "and " + vec2.ElementAt(o - 1);
                vec2.RemoveRange(0, o);
            }
            str += "\n\n\n* - These factions have Titans.";
            //str += "\n\nBases Needed:\n" + bases;
            FlexibleMessageBox.Show(str);
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            reset();
            if (NumPlayer.Text == "" || FacPer.Text == "")
            {
                FlexibleMessageBox.Show("Be sure to fill all text boxes.");
            }
            else
            {
                int numPlay = int.Parse(NumPlayer.Text);
                int facPer = int.Parse(FacPer.Text);


                if (numPlay <= 1 || facPer <= 1)
                {
                    if (numPlay <= 1)
                    {
                        FlexibleMessageBox.Show("There must be at least 2 players.");
                    }
                    else
                        FlexibleMessageBox.Show("There must be at least 2 factions per player.");
                }
                else if (numPlay * facPer > TotalLength())
                {
                    FlexibleMessageBox.Show("There are not enough factions for that many people, please change one of the entries.");
                }
                else
                {
                    //int numPlay = int.Parse(NumPlayer.Text), facPer = int.Parse(FacPer.Text);
                    List<string> choices = new List<string>();
                    if (Fac1.IsChecked == false && Fac2.IsChecked == false && Fac3.IsChecked == false && Fac4.IsChecked == false &&
                        Fac5.IsChecked == false && Fac6.IsChecked == false && Fac7.IsChecked == false && Fac8.IsChecked == false &&
                        Fac9.IsChecked == false && Fac10.IsChecked == false && Fac11.IsChecked == false && Fac12.IsChecked == false &&
                        Fac13.IsChecked == false && Fac14.IsChecked == false && Fac15.IsChecked == false && Fac16.IsChecked == false &&
                        Fac17.IsChecked == false && Fac18.IsChecked == false && Fac19.IsChecked == false && Fac20.IsChecked == false && Fac21.IsChecked == false)
                    {
                        FlexibleMessageBox.Show("Please select one or more expansions.");
                    }
                    else
                    {
                        fillPot();
                        if (ListLength(pot) >= (numPlay * facPer))
                        {
                            randomizer(pot, numPlay, facPer, choices);
                        }
                        else
                        {
                            FlexibleMessageBox.Show("Not enough factions chosen.");
                        }
                    }
                }
            }
        }

        private void AllFacs_Checked(object sender, RoutedEventArgs e)
        {
            Fac1.IsChecked = true;
            Fac2.IsChecked = true;
            Fac3.IsChecked = true;
            Fac4.IsChecked = true;
            Fac5.IsChecked = true;
            Fac6.IsChecked = true;
            Fac7.IsChecked = true;
            Fac8.IsChecked = true;
            Fac9.IsChecked = true;
            Fac10.IsChecked = true;
            Fac11.IsChecked = true;
            Fac12.IsChecked = true;
            Fac13.IsChecked = true;
            Fac14.IsChecked = true;
            Fac15.IsChecked = true;
            Fac16.IsChecked = true;
            Fac17.IsChecked = true;
            Fac18.IsChecked = true;
            Fac19.IsChecked = true;
            Fac20.IsChecked = true;
            Fac21.IsChecked = true;
        }

        private void AllFacs_Unchecked(object sender, RoutedEventArgs e)
        {
            Fac1.IsChecked = false;
            Fac2.IsChecked = false;
            Fac3.IsChecked = false;
            Fac4.IsChecked = false;
            Fac5.IsChecked = false;
            Fac6.IsChecked = false;
            Fac7.IsChecked = false;
            Fac8.IsChecked = false;
            Fac9.IsChecked = false;
            Fac10.IsChecked = false;
            Fac11.IsChecked = false;
            Fac12.IsChecked = false;
            Fac13.IsChecked = false;
            Fac14.IsChecked = false;
            Fac15.IsChecked = false;
            Fac16.IsChecked = false;
            Fac17.IsChecked = false;
            Fac18.IsChecked = false;
            Fac19.IsChecked = false;
            Fac20.IsChecked = false;
            Fac21.IsChecked = false;
        }

        private void Faction_Unchecked(object sender, RoutedEventArgs e)
        {
            AllFacs.Unchecked -= AllFacs_Unchecked;
            AllFacs.IsChecked = false;
            AllFacs.Unchecked += AllFacs_Unchecked;
        }

        private void All_Factions_Checked(object sender, RoutedEventArgs e)
        {
            if (Fac1.IsChecked == true && Fac2.IsChecked == true && Fac3.IsChecked == true && Fac4.IsChecked == true &&
                    Fac5.IsChecked == true && Fac6.IsChecked == true && Fac7.IsChecked == true && Fac8.IsChecked == true &&
                    Fac9.IsChecked == true && Fac10.IsChecked == true && Fac11.IsChecked == true && Fac12.IsChecked == true &&
                    Fac13.IsChecked == true && Fac14.IsChecked == true && Fac15.IsChecked == true && Fac16.IsChecked == true &&
                    Fac17.IsChecked == true && Fac18.IsChecked == true && Fac19.IsChecked == true && Fac20.IsChecked == true && Fac21.IsChecked == true)
                AllFacs.IsChecked = true;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            sheet.Visibility = Visibility.Hidden;
            //DeleteMe.Visibility = Visibility.Hidden;
            NumPlayerBlock1.Visibility = Visibility.Hidden;
            FacPerBlock1.Visibility = Visibility.Hidden;
            AllFacs1.Visibility = Visibility.Hidden;
            Fact1.Visibility = Visibility.Hidden;
            Fact2.Visibility = Visibility.Hidden;
            Fact3.Visibility = Visibility.Hidden;
            Fact4.Visibility = Visibility.Hidden;
            Fact5.Visibility = Visibility.Hidden;
            Fact6.Visibility = Visibility.Hidden;
            Fact7.Visibility = Visibility.Hidden;
            Fact8.Visibility = Visibility.Hidden;
            Fact9.Visibility = Visibility.Hidden;
            Fact10.Visibility = Visibility.Hidden;
            Fact11.Visibility = Visibility.Hidden;
            Fact12.Visibility = Visibility.Hidden;
            Fact13.Visibility = Visibility.Hidden;
            Fact14.Visibility = Visibility.Hidden;
            Fact15.Visibility = Visibility.Hidden;
            Fact16.Visibility = Visibility.Hidden;
            Fact17.Visibility = Visibility.Hidden;
            Fact18.Visibility = Visibility.Hidden;
            Fact19.Visibility = Visibility.Hidden;
            Fact20.Visibility = Visibility.Hidden;
            Fact21.Visibility = Visibility.Hidden;
            NumPlayerBlock.Visibility = Visibility.Hidden;
            NumPlayerShadow.Visibility = Visibility.Hidden;
            NumPlayer.Visibility = Visibility.Hidden;
            button.Visibility = Visibility.Hidden;
            button1.Visibility = Visibility.Hidden;
            FacPerBlock.Visibility = Visibility.Hidden;
            FacPerShadow.Visibility = Visibility.Hidden;
            FacPer.Visibility = Visibility.Hidden;
            AllFacs.Visibility = Visibility.Hidden;
            Fac1.Visibility = Visibility.Hidden;
            Fac2.Visibility = Visibility.Hidden;
            Fac3.Visibility = Visibility.Hidden;
            Fac4.Visibility = Visibility.Hidden;
            Fac5.Visibility = Visibility.Hidden;
            Fac6.Visibility = Visibility.Hidden;
            Fac7.Visibility = Visibility.Hidden;
            Fac8.Visibility = Visibility.Hidden;
            Fac9.Visibility = Visibility.Hidden;
            Fac10.Visibility = Visibility.Hidden;
            Fac11.Visibility = Visibility.Hidden;
            Fac12.Visibility = Visibility.Hidden;
            Fac13.Visibility = Visibility.Hidden;
            Fac14.Visibility = Visibility.Hidden;
            Fac15.Visibility = Visibility.Hidden;
            Fac16.Visibility = Visibility.Hidden;
            Fac17.Visibility = Visibility.Hidden;
            Fac18.Visibility = Visibility.Hidden;
            Fac19.Visibility = Visibility.Hidden;
            Fac20.Visibility = Visibility.Hidden;
            Fac21.Visibility = Visibility.Hidden;
            button2.Visibility = Visibility.Hidden;
            button3.Visibility = Visibility.Hidden;
        }

        private void ImageButton_Click(object sender, RoutedEventArgs e)
        {
            if (button2.Visibility == Visibility.Hidden)
            {
                sheet.Visibility = Visibility.Visible;
                //DeleteMe.Visibility = Visibility.Visible;
                NumPlayerBlock1.Visibility = Visibility.Visible;
                FacPerBlock1.Visibility = Visibility.Visible;
                AllFacs1.Visibility = Visibility.Visible;
                Fact1.Visibility = Visibility.Visible;
                Fact2.Visibility = Visibility.Visible;
                Fact3.Visibility = Visibility.Visible;
                Fact4.Visibility = Visibility.Visible;
                Fact5.Visibility = Visibility.Visible;
                Fact6.Visibility = Visibility.Visible;
                Fact7.Visibility = Visibility.Visible;
                Fact8.Visibility = Visibility.Visible;
                Fact9.Visibility = Visibility.Visible;
                Fact10.Visibility = Visibility.Visible;
                Fact11.Visibility = Visibility.Visible;
                Fact12.Visibility = Visibility.Visible;
                Fact13.Visibility = Visibility.Visible;
                Fact14.Visibility = Visibility.Visible;
                Fact15.Visibility = Visibility.Visible;
                Fact16.Visibility = Visibility.Visible;
                Fact17.Visibility = Visibility.Visible;
                Fact18.Visibility = Visibility.Visible;
                Fact19.Visibility = Visibility.Visible;
                Fact20.Visibility = Visibility.Visible;
                Fact21.Visibility = Visibility.Visible;
                NumPlayerBlock.Visibility = Visibility.Visible;
                NumPlayerShadow.Visibility = Visibility.Visible;
                NumPlayer.Visibility = Visibility.Visible;
                button.Visibility = Visibility.Visible;
                button1.Visibility = Visibility.Visible;
                FacPerBlock.Visibility = Visibility.Visible;
                FacPerShadow.Visibility = Visibility.Visible;
                FacPer.Visibility = Visibility.Visible;
                AllFacs.Visibility = Visibility.Visible;
                Fac1.Visibility = Visibility.Visible;
                Fac2.Visibility = Visibility.Visible;
                Fac3.Visibility = Visibility.Visible;
                Fac4.Visibility = Visibility.Visible;
                Fac5.Visibility = Visibility.Visible;
                Fac6.Visibility = Visibility.Visible;
                Fac7.Visibility = Visibility.Visible;
                Fac8.Visibility = Visibility.Visible;
                Fac9.Visibility = Visibility.Visible;
                Fac10.Visibility = Visibility.Visible;
                Fac11.Visibility = Visibility.Visible;
                Fac12.Visibility = Visibility.Visible;
                Fac13.Visibility = Visibility.Visible;
                Fac14.Visibility = Visibility.Visible;
                Fac15.Visibility = Visibility.Visible;
                Fac16.Visibility = Visibility.Visible;
                Fac17.Visibility = Visibility.Visible;
                Fac18.Visibility = Visibility.Visible;
                Fac19.Visibility = Visibility.Visible;
                Fac20.Visibility = Visibility.Visible;
                Fac21.Visibility = Visibility.Visible;
                button2.Visibility = Visibility.Visible;
                button3.Visibility = Visibility.Visible;
                //FlexibleMessageBox.Show(NumPlayer.ActualWidth.ToString() + "\n" + NumPlayerBlock.ActualHeight.ToString());
            }
        }

        int bg = 1;

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            if (bg == 0)
            {
                //Properties.Resources.SUBackground.ImageSource();
                var uri = new Uri("pack://application:,,,/Images/SURBackground.bmp");
                BitmapImage SURB = new BitmapImage(uri);
                image.Source = SURB;
                bg = 1;
            }
            else
            {
                var uri2 = new Uri("pack://application:,,,/Images/SUBackground.bmp");
                BitmapImage SUB = new BitmapImage(uri2);
                image.Source = SUB;
                bg = 0;
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit?", "Exit", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                this.Close();
            }
        }

        private void labels(object sender, EventArgs e)
        {
            double x = Window.GetWindow(SURW).Height * 0.16851851851851851851851851851852;
            double y = Window.GetWindow(SURW).Height * 0.25185185185185185185185185185185;
            double sheetH = Window.GetWindow(SURW).Height - x - y;
            double z = (Window.GetWindow(SURW).Width - 938) / 2;
            sheet.Height = sheetH;
            sheet.Margin = new Thickness(z, x, z, 0);
        }

        private void appGrid2_Initialized(object sender, EventArgs e)
        {
            double x = Window.GetWindow(SURW).Height * 0.16851851851851851851851851851852;
            double y = Window.GetWindow(SURW).Height * 0.25185185185185185185185185185185;
            double gridH = Window.GetWindow(SURW).Height - x - y;
            double z = (Window.GetWindow(SURW).Width-938)/2;
            appGrid2.Height = gridH;
            appGrid2.Margin = new Thickness(z, x, z, 0);
        }

        private void appGrid3_Initialized(object sender, EventArgs e)
        {
            double x = Window.GetWindow(SURW).Height * 0.16851851851851851851851851851852;
            double y = Window.GetWindow(SURW).Height * 0.25185185185185185185185185185185;
            double z = (Window.GetWindow(SURW).Width - 938) / 2;
            appGrid3.Margin = new Thickness(60, x-40, 0, 0);
        }

        private void appGrid4_Initialized(object sender, EventArgs e)
        {
            double x = Window.GetWindow(SURW).Height * 0.16851851851851851851851851851852;
            double y = Window.GetWindow(SURW).Height * 0.25185185185185185185185185185185;
            double z = (Window.GetWindow(SURW).Width - 938) / 2;
            appGrid4.Margin = new Thickness(0, x+360, 0, 0);
        }

        private void appGrid5_Initialized(object sender, EventArgs e)
        {
            double x = Window.GetWindow(SURW).Height * 0.16851851851851851851851851851852;
            double y = Window.GetWindow(SURW).Height * 0.25185185185185185185185185185185;
            double z = (Window.GetWindow(SURW).Width - 938) / 2;
            appGrid5.Margin = new Thickness(80, x - 39, 0, 0);
        }
    }
}
