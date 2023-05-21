using System;
using System.Windows.Forms;

namespace ieskaites_uzdevums
{
    public partial class Form2 : Form
    {
        //Viktorīnas jautājumi.
        string[] jautajumi = new string[] {
            "Ar kuru no sekojošajiem piederumiem visvieglāk ir rakt akmeņus un ķieģeļus?",
            "Cik Cobblestone bloki nepieciešami, lai uztaisītu Furnace?",
            "No kura materiāla var uztaisīt vājākās bruņas?",
            "Kāds bija oriģinālais Minecraft videospēles nosaukums, kad tas tika publicēts?",
            "Uz kura no šiem dzīvniekiem var jāt ar segliem?",
            "Kāds ir trūkums Zelta darba rīkiem salīdzinot ar Dzelzs darba rīkiem?",
            "No kura materiāla var uztaisīt stiprākās bruņas un darba rīkus?",
            "Kas notiks ar Creeperi, kad viņam iesper zibens?",
            "Ko nomet Ender Pūķis, kad tas tiem uzveikts?",
            "Kurš bloks aizņem visvairāk laika, lai to nosistu?",
            "Cik gara ir diennakts Minecraft pasaulē?",
            "Kas notiek, kad ūdens uztek lavai?",
            "Kā var iegūt ābolu Minecraft videospēlē?",
            "Kuru no šiem var atrast TIKAI End Dimensijā?",
            "Kuru no šiem var atrast TIKAI Nether dimensijā?",
            "Kas notiek, kad noliec gultu uz zemes Nether dimensijā?",
            "Kurā gadā tika izlaista Minecraft videospēles versija 1.0?",
            "Kuru no šiem NEVAR enchantot uz Enchantment galda?",
            "Kurš ir retākais Ore bloks?",
            "Kura Minecraft versija ir visvecākā?"        
        };

        //Viktorīnas visas pirmās atbildes avrianti secīgi.
        string[] atbildes1 = new string[] {
            "Shovel",
            "8",
            "Wood",
            "Mine-crafter",
            "Cūka",
            "Tie ir vājāki",
            "Dzelzs",
            "Tas paliek uzlādēts",
            "XP un pūķa galvu",
            "Netherrite block",
            "10 min",
            "Ūdens iztvaiko",
            "Salasot tos no ābeles",
            "Elytra",
            "Red Mushroom",
            "Tā pazūd",
            "2009",
            "Grāmatu",
            "Emerald",
            "PE"
        };

        //Viktorīnas visas otrās atbildes varianti secīgi.
        string[] atbildes2 = new string[] {
            "Axe",
            "9",
            "Leather",
            "Minicraft",
            "Govs",
            "Tie ir neizturīgāki",
            "Dimanta",
            "Tas nomirst",
            "XP un pūķa olu",
            "Obsidian",
            "20 min",
            "Veidojās Cobblestone",
            "Nogalinot villigerus",
            "Enderman",
            "Netherrack",
            "Tā uzsprāgst",
            "2010",
            "Makšķeri",
            "Red Stone",
            "Java"
        };

        //Viktorīnas visas trešās atbildes varianti secīgi.
        string[] atbildes3 = new string[] {
            "Pickaxe",
            "10",
            "Iron",
            "Cave game",
            "Aita",
            "Tie ir dārgāki",
            "Netheraita",
            "Tas uzsprāgst",
            "XP un elytru",
            "Ender chest",
            "30 min",
            "Veidojās Obsidiāns",
            "No koka lapām, kas tiek iznīcinātas",
            "Netherite",
            "Ancient Debris",
            "Nekas nenotiek",
            "2011",
            "Ābolu",
            "Diamond",
            "Educational"
        };

        //Viktorīnas visas pareizās atbildes secīgi.
        string[] atbildes = new string[] {
            "Pickaxe",
            "8",
            "Leather",
            "Cave game",
            "Cūka",
            "Tie ir neizturīgāki",
            "Netheraita",
            "Tas paliek uzlādēts",
            "XP un pūķa olu",
            "Obsidian",
            "20 min",
            "Veidojās Obsidiāns",
            "No koka lapām, kas tiek iznīcinātas",
            "Elytra",
            "Ancient Debris",
            "Nekas nenotiek",
            "2011",
            "Ābolu",
            "Emerald",
            "Java"
        };

        //Piemēru un punktu sākuma skaits.
        int piemeri = 0;
        public static int punkti = 0;

        public Form2()
        {
            InitializeComponent();
        }
        
        private void Form2_load(object sender, EventArgs e)
        {
            label2.Text = jautajumi[piemeri];
            button1.Text = atbildes1[piemeri];
            button2.Text = atbildes2[piemeri];
            button3.Text = atbildes3[piemeri];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == atbildes[piemeri]) 
            { 
                punkti = punkti + 1;
            };

            if (punkti == 1)
            {
                label3.Text = punkti + " punkts";
            }
            else
            {
                label3.Text = punkti + " punkti";
            };
            piemeri = piemeri + 1;
            if (piemeri < 20)
            {
                label2.Text = jautajumi[piemeri];
                button1.Text = atbildes1[piemeri];
                button2.Text = atbildes2[piemeri];
                button3.Text = atbildes3[piemeri];
                label1.Text = (piemeri + 1) + ". no 20 jautājumiem";
            }
            else
            {
                this.Hide();
                Form3 rezultats = new Form3();
                rezultats.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == atbildes[piemeri])
            {
                punkti = punkti + 1;
            };

            if (punkti == 1)
            {
                label3.Text = punkti + " punkts";
            }
            else
            {
                label3.Text = punkti + " punkti";
            };
            piemeri = piemeri + 1;
            if (piemeri < 20)
            {
                label2.Text = jautajumi[piemeri];
                button1.Text = atbildes1[piemeri];
                button2.Text = atbildes2[piemeri];
                button3.Text = atbildes3[piemeri];
                label1.Text = (piemeri + 1) + ". no 20 jautājumiem";
            }
            else
            {
                this.Hide();
                Form3 rezultats = new Form3();
                rezultats.Show();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == atbildes[piemeri])
            {
                punkti = punkti + 1;
            };

            if (punkti == 1)
            {
                label3.Text = punkti + " punkts";
            }
            else
            {
                label3.Text = punkti + " punkti";
            };
            piemeri = piemeri + 1;
            if (piemeri < 20)
            {
                label2.Text = jautajumi[piemeri];
                button1.Text = atbildes1[piemeri];
                button2.Text = atbildes2[piemeri];
                button3.Text = atbildes3[piemeri];
                label1.Text = (piemeri + 1) + ". no 20 jautājumiem";
            }
            else
            {
                this.Hide();
                Form3 rezultats = new Form3();
                rezultats.Show();
            }
        }
    }
}
