using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace TFRPStreambox_CSharp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 


    public class Rootobject
    {
        public Stream stream { get; set; }
        public _Links2 _links { get; set; }
    }

    public class Stream
    {
        public long _id { get; set; }
        public string game { get; set; }
        public int viewers { get; set; }
        public int video_height { get; set; }
        public int delay { get; set; }
        public DateTime created_at { get; set; }
        public bool is_playlist { get; set; }
        public string stream_type { get; set; }
        public Preview preview { get; set; }
        public Channel channel { get; set; }
        public _Links1 _links { get; set; }
    }

    public class Preview
    {
        public string small { get; set; }
        public string medium { get; set; }
        public string large { get; set; }
        public string template { get; set; }
    }

    public class Channel
    {
        public bool mature { get; set; }
        public bool partner { get; set; }
        public string status { get; set; }
        public string broadcaster_language { get; set; }
        public string display_name { get; set; }
        public string game { get; set; }
        public string language { get; set; }
        public int _id { get; set; }
        public string name { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public object delay { get; set; }
        public string logo { get; set; }
        public object banner { get; set; }
        public string video_banner { get; set; }
        public object background { get; set; }
        public string profile_banner { get; set; }
        public string profile_banner_background_color { get; set; }
        public string url { get; set; }
        public int views { get; set; }
        public int followers { get; set; }
        public _Links _links { get; set; }
    }

    public class _Links
    {
        public string self { get; set; }
        public string follows { get; set; }
        public string commercial { get; set; }
        public string stream_key { get; set; }
        public string chat { get; set; }
        public string features { get; set; }
        public string subscriptions { get; set; }
        public string editors { get; set; }
        public string teams { get; set; }
        public string videos { get; set; }
    }

    public class _Links1
    {
        public string self { get; set; }
    }

    public class _Links2
    {
        public string self { get; set; }
        public string channel { get; set; }
    }



    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void _1GUnit1_MouseDown(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("CMD.exe", "/C data\\streamlink.exe http://twitch.tv/1GUnit1 best");
        }

        private void AbdulHD_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/AbdulHD best");
        }

        private void AgentNorth_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/AgentNorth best");
        }

        private void alexusnightingale_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/alexusnightingale best");
        }

        private void AndyMilonakis_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/AndyMilonakis best");
        }

        private void anthonyz__Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/anthonyz best");
        }

        private void BFLY003_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/BFLY003 best");
        }

        private void boscoreli_gaming_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/boscoreli_gaming best");
        }

        private void BPZ_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/BPZ_Gaming best");
        }

        private void BuckkNaked_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/BuckkNaked best");
        }

        private void BurkeBlack_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/BurkeBlack best");
        }

        private void Ch1ckenb0ne_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/Ch1ckenb0ne best");
        }

        private void ChiefDas_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/ChiefDas best");
        }

        private void ClassyPax_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/ClassyPax best");
        }

        private void CletusBueford_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/ClestusBeuford best");
        }

        private void CoolidgeHD_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/CoolidgeHD best");
        }

        private void dasMehdi_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/dasMehdi best");
        }

        private void DisbeArex_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/DisbeArex best");
        }

        private void djkwix_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/djkwix best");
        }

        private void DrunkBabyYoshi_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/DrunkBabyYoshi best");
        }

        private void Esoluu_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/Esoluu_Click best");
        }

        private void Finkone_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/Finkone best");
        }

        private void FistofTheWalrus_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/FistofTheWalrus best");
        }

        private void Five0AnthO_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/Five0AnthO best");
        }

        private void GeeFamous92_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/GeeFamous92 best");
        }

        private void GhilleGuyTV_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/GhilleGuyTV best");
        }

        private void GiantFaffle_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/GiantFaffle best");
        }

        private void GloryD_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/GloryD best");
        }

        private void Harryow_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/Harryow best");
        }

        private void Hazard_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/Hazard best");
        }

        private void Hirona_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/Hirona best");
        }

        private void IAmSp00n_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/IAmSp00n best");
        }

        private void ImmortalLive_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/ImmortalLive best");
        }

        private void ironmonkeytv_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/ironmonkeytv best");
        }

        private void itzButch_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/itzButch best");
        }

        private void J_Reed_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/J_Reed best");
        }

        private void JaboodyShow_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/JaboodyShow best");
        }

        private void jake_terek_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/jake_terek best");
        }

        private void JmxTwiztid_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/JmxTwiztid best");
        }

        private void John782_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/John782 best");
        }

        private void Jolly__Jess_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/Jolly__Jess best");
        }

        private void JTtroy_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/JTtroy best");
        }

        private void kaceytron_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/kaceytron best");
        }

        private void KaptainKpress_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/KaptainKpress best");
        }

        private void KatieRouu_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/KatieRouu best");
        }

        private void Kithicor27_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/Kithicor27 best");
        }

        private void LarryX7_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/LarryX7 best");
        }

        private void lawdog1096_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/lawdog1096 best");
        }

        private void LiftYourGame_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/LiftYourGame best");
        }

        private void loveANF3L_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/loveANG3L best");
        }

        private void mart1n_g_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/mart1n_g best");
        }

        private void MiltonTPike1_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/MiltonTPike1 best");
        }

        private void MintsTV_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/MintsTV best");
        }

        private void MrMoonsHouse_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/MrMoonsHouse best");
        }

        private void MsDeathRabbit_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/MsDeathRabbit best");
        }

        private void Og_BluePill_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/OG_BluePill best");
        }

        private void PENTAhearth_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/PENTAhearth best");
        }

        private void Pinky_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/Pinky best");
        }

        private void PmsProxy_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/PmsProxy best");
        }

        private void PorkMarshmallow_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/PorkMarshmallow best");
        }

        private void PrimusPalus_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/PrimusPalus best");
        }

        private void Purrluna_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/Purrluna best");
        }

        private void Pydrex_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/Pydrex best");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.videolan.org/vlc/index.html");
        }

        private void myButton_Click(object sender, RoutedEventArgs e)
        {
            Window2 Form2 = new Window2();
            this.Close();
            Form2.ShowDialog();

        }

        private void Refresh_Click(object sender, RoutedEventArgs e)
        {
            //1GUnit1 Live check
            string _1GUnit1url = @"https://api.twitch.tv/kraken/streams/1GUnit1?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var _1Gunit1json = new WebClient().DownloadString(_1GUnit1url);

            Rootobject _1GUnit1r = JsonConvert.DeserializeObject<Rootobject>(_1Gunit1json);
            Console.WriteLine(_1GUnit1r.stream);
            if (_1GUnit1r.stream == null)
            {
                _1GUnit1.Background = Brushes.Red;
            }
            else
            {
                _1GUnit1.Background = Brushes.LightGreen;
            }
            //AbdulHD Live check
            string abdulhdurl = @"https://api.twitch.tv/kraken/streams/AbDulHD?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var abdulhdjson = new WebClient().DownloadString(abdulhdurl);

            Rootobject abdulhdr = JsonConvert.DeserializeObject<Rootobject>(abdulhdjson);
            Console.WriteLine(abdulhdr.stream);
            if (abdulhdr.stream == null)
            {
                AbdulHD.Background = Brushes.Red;
            }
            else
            {
                AbdulHD.Background = Brushes.LightGreen;
            }
            //AgentNorth live check
            string agentnorthurl = @"https://api.twitch.tv/kraken/streams/agentnorth?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var agentnorthjson = new WebClient().DownloadString(agentnorthurl);

            Rootobject agentnorthr = JsonConvert.DeserializeObject<Rootobject>(agentnorthjson);
            Console.WriteLine(agentnorthr.stream);
            if (agentnorthr.stream == null)
            {
                AgentNorth.Background = Brushes.Red;
            }
            else
            {
                AgentNorth.Background = Brushes.LightGreen;
            }
            //alexusnightingale live check
            string alexusnightingaleurl = @"https://api.twitch.tv/kraken/streams/alexusnightingale?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var alexusnightingalejson = new WebClient().DownloadString(alexusnightingaleurl);

            Rootobject alexusnightingaler = JsonConvert.DeserializeObject<Rootobject>(alexusnightingalejson);
            Console.WriteLine(alexusnightingaler.stream);
            if (alexusnightingaler.stream == null)
            {
                alexusnightingale.Background = Brushes.Red;
            }
            else
            {
                alexusnightingale.Background = Brushes.LightGreen;
            }
            //AndyMilonakis live check
            string andyurl = @"https://api.twitch.tv/kraken/streams/andymilonakis?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var andyjson = new WebClient().DownloadString(andyurl);

            Rootobject andyr = JsonConvert.DeserializeObject<Rootobject>(andyjson);
            Console.WriteLine(andyr.stream);
            if (andyr.stream == null)
            {
                AndyMilonakis.Background = Brushes.Red;
            }
            else
            {
                AndyMilonakis.Background = Brushes.LightGreen;
            }
            //anthonyz_ live check
            string anturl = @"https://api.twitch.tv/kraken/streams/anthonyz_?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var antjson = new WebClient().DownloadString(anturl);

            Rootobject antr = JsonConvert.DeserializeObject<Rootobject>(antjson);
            Console.WriteLine(antr.stream);
            if (antr.stream == null)
            {
                anthonyz_.Background = Brushes.Red;
            }
            else
            {
                anthonyz_.Background = Brushes.LightGreen;
            }
            //BFLY003 live check
            string bflyurl = @"https://api.twitch.tv/kraken/streams/BFLY003?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var bflyjson = new WebClient().DownloadString(bflyurl);

            Rootobject bflyr = JsonConvert.DeserializeObject<Rootobject>(bflyjson);
            Console.WriteLine(bflyr.stream);
            if (bflyr.stream == null)
            {
                BFLY003.Background = Brushes.Red;
            }
            else
            {
                BFLY003.Background = Brushes.LightGreen;
            }
            //boscoreli live check
            string boscoreliurl = @"https://api.twitch.tv/kraken/streams/boscoreli_gaming?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var boscorelijson = new WebClient().DownloadString(boscoreliurl);

            Rootobject boscorelir = JsonConvert.DeserializeObject<Rootobject>(boscorelijson);
            Console.WriteLine(boscorelir.stream);
            if (boscorelir.stream == null)
            {
                boscoreli_gaming.Background = Brushes.Red;
            }
            else
            {
                boscoreli_gaming.Background = Brushes.LightGreen;
            }
            //BPZ live check
            string bpzurl = @"https://api.twitch.tv/kraken/streams/BPZ?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var bpzjson = new WebClient().DownloadString(bpzurl);

            Rootobject bpzr = JsonConvert.DeserializeObject<Rootobject>(bpzjson);
            Console.WriteLine(bpzr.stream);
            if (bpzr.stream == null)
            {
                BPZ.Background = Brushes.Red;
            }
            else
            {
                BPZ.Background = Brushes.LightGreen;
            }
            //BuckkNaked live check
            string buckurl = @"https://api.twitch.tv/kraken/streams/buckknaked?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var buckjson = new WebClient().DownloadString(buckurl);

            Rootobject buckr = JsonConvert.DeserializeObject<Rootobject>(buckjson);
            Console.WriteLine(buckr.stream);
            if (buckr.stream == null)
            {
                BuckkNaked.Background = Brushes.Red;
            }
            else
            {
                BuckkNaked.Background = Brushes.LightGreen;
            }
            //BurkeBlack live check
            string burkeurl = @"https://api.twitch.tv/kraken/streams/BurkeBlack?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var burkej = new WebClient().DownloadString(burkeurl);

            Rootobject burker = JsonConvert.DeserializeObject<Rootobject>(burkej);
            Console.WriteLine(burker.stream);
            if (burker.stream == null)
            {
                BurkeBlack.Background = Brushes.Red;
            }
            else
            {
                BurkeBlack.Background = Brushes.LightGreen;
            }
            //Ch1ckenb0ne live check
            string chicku = @"https://api.twitch.tv/kraken/streams/ch1ckenb0ne?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var chickj = new WebClient().DownloadString(chicku);

            Rootobject chickr = JsonConvert.DeserializeObject<Rootobject>(chickj);
            Console.WriteLine(chickr.stream);
            if (chickr.stream == null)
            {
                Ch1ckenb0ne.Background = Brushes.Red;
            }
            else
            {
                Ch1ckenb0ne.Background = Brushes.LightGreen;
            }
            //ChiefDas live check
            string chiefu = @"https://api.twitch.tv/kraken/streams/ChiefDas?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var chiefj = new WebClient().DownloadString(chiefu);

            Rootobject chiefr = JsonConvert.DeserializeObject<Rootobject>(chiefj);
            Console.WriteLine(chiefr.stream);
            if (chiefr.stream == null)
            {
                ChiefDas.Background = Brushes.Red;
            }
            else
            {
                ChiefDas.Background = Brushes.LightGreen;
            }
            //classypax live check
            string classyu = @"https://api.twitch.tv/kraken/streams/ClassyPax?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var classyj = new WebClient().DownloadString(classyu);

            Rootobject classyr = JsonConvert.DeserializeObject<Rootobject>(classyj);
            Console.WriteLine(classyr.stream);
            if (classyr.stream == null)
            {
                ClassyPax.Background = Brushes.Red;
            }
            else
            {
                ClassyPax.Background = Brushes.LightGreen;
            }
            //cletusbueford live check
            string cletu = @"https://api.twitch.tv/kraken/streams/cletusbeuford?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var cletj = new WebClient().DownloadString(cletu);

            Rootobject cletr = JsonConvert.DeserializeObject<Rootobject>(cletj);
            Console.WriteLine(cletr.stream);
            if (cletr.stream == null)
            {
                CletusBueford.Background = Brushes.Red;
            }
            else
            {
                CletusBueford.Background = Brushes.LightGreen;
            }
            //CoolidgeHD live check
            string coolu = @"https://api.twitch.tv/kraken/streams/coolidgehd?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var coolj = new WebClient().DownloadString(coolu);

            Rootobject coolr = JsonConvert.DeserializeObject<Rootobject>(coolj);
            Console.WriteLine(coolr.stream);
            if (coolr.stream == null)
            {
                CoolidgeHD.Background = Brushes.Red;
            }
            else
            {
                CoolidgeHD.Background = Brushes.LightGreen;
            }
            //dasMehdi live check
            string dasu = @"https://api.twitch.tv/kraken/streams/dasmehdi?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var dasj = new WebClient().DownloadString(dasu);

            Rootobject dasr = JsonConvert.DeserializeObject<Rootobject>(dasj);
            Console.WriteLine(dasr.stream);
            if (dasr.stream == null)
            {
                dasMehdi.Background = Brushes.Red;
            }
            else
            {
                dasMehdi.Background = Brushes.LightGreen;
            }
            //DisbeArex live check
            string disu = @"https://api.twitch.tv/kraken/streams/disbearex?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var disj = new WebClient().DownloadString(disu);

            Rootobject disr = JsonConvert.DeserializeObject<Rootobject>(disj);
            Console.WriteLine(disr.stream);
            if (disr.stream == null)
            {
                DisbeArex.Background = Brushes.Red;
            }
            else
            {
                DisbeArex.Background = Brushes.LightGreen;
            }
            //djkwix live check
            string djku = @"https://api.twitch.tv/kraken/streams/djkwix?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var djkj = new WebClient().DownloadString(djku);

            Rootobject djkr = JsonConvert.DeserializeObject<Rootobject>(djkj);
            Console.WriteLine(djkr.stream);
            if (djkr.stream == null)
            {
                djkwix.Background = Brushes.Red;
            }
            else
            {
                djkwix.Background = Brushes.LightGreen;
            }
            //DrunkBabyYoshi live check
            string drunu = @"https://api.twitch.tv/kraken/streams/drunkbabyyoshi?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var drunj = new WebClient().DownloadString(drunu);

            Rootobject drunr = JsonConvert.DeserializeObject<Rootobject>(drunj);
            Console.WriteLine(drunr.stream);
            if (drunr.stream == null)
            {
                DrunkBabyYoshi.Background = Brushes.Red;
            }
            else
            {
                DrunkBabyYoshi.Background = Brushes.LightGreen;
            }
            //Esoluu live check
            string esou = @"https://api.twitch.tv/kraken/streams/esoluu?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var esoj = new WebClient().DownloadString(esou);

            Rootobject esor = JsonConvert.DeserializeObject<Rootobject>(esoj);
            Console.WriteLine(esor.stream);
            if (esor.stream == null)
            {
                Esoluu.Background = Brushes.Red;
            }
            else
            {
                Esoluu.Background = Brushes.LightGreen;
            }
            //finkone live check
            string finu = @"https://api.twitch.tv/kraken/streams/finkone?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var finj = new WebClient().DownloadString(finu);

            Rootobject finr = JsonConvert.DeserializeObject<Rootobject>(finj);
            Console.WriteLine(finr.stream);
            if (finr.stream == null)
            {
                Finkone.Background = Brushes.Red;
            }
            else
            {
                Finkone.Background = Brushes.LightGreen;
            }
            //Fistofthewalrus live check
            string fisu = @"https://api.twitch.tv/kraken/streams/fistofthewalrus?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var fisj = new WebClient().DownloadString(fisu);

            Rootobject fisr = JsonConvert.DeserializeObject<Rootobject>(fisj);
            Console.WriteLine(fisr.stream);
            if (fisr.stream == null)
            {
                FistofTheWalrus.Background = Brushes.Red;
            }
            else
            {
                FistofTheWalrus.Background = Brushes.LightGreen;
            }
            //Five0anthO live check
            string fiveu = @"https://api.twitch.tv/kraken/streams/five0antho?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var fivej = new WebClient().DownloadString(fiveu);

            Rootobject fiver = JsonConvert.DeserializeObject<Rootobject>(fivej);
            Console.WriteLine(fiver.stream);
            if (fiver.stream == null)
            {
                Five0AnthO.Background = Brushes.Red;
            }
            else
            {
                Five0AnthO.Background = Brushes.LightGreen;
            }
            //GeeFamous92 live check
            string geeu = @"https://api.twitch.tv/kraken/streams/geefamous92?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var geej = new WebClient().DownloadString(geeu);

            Rootobject geer = JsonConvert.DeserializeObject<Rootobject>(geej);
            Console.WriteLine(geer.stream);
            if (geer.stream == null)
            {
                GeeFamous92.Background = Brushes.Red;
            }
            else
            {
                GeeFamous92.Background = Brushes.LightGreen;
            }
            //GhilleGuyTV live check
            string ghiu = @"https://api.twitch.tv/kraken/streams/ghilleguytv?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var ghij = new WebClient().DownloadString(ghiu);

            Rootobject ghir = JsonConvert.DeserializeObject<Rootobject>(ghij);
            Console.WriteLine(ghir.stream);
            if (ghir.stream == null)
            {
                GhilleGuyTV.Background = Brushes.Red;
            }
            else
            {
                GhilleGuyTV.Background = Brushes.LightGreen;
            }
            //GiantFaffle live check
            string giau = @"https://api.twitch.tv/kraken/streams/giantfaffle?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var giaj = new WebClient().DownloadString(giau);

            Rootobject giar = JsonConvert.DeserializeObject<Rootobject>(giaj);
            Console.WriteLine(giar.stream);
            if (giar.stream == null)
            {
                GiantFaffle.Background = Brushes.Red;
            }
            else
            {
                GiantFaffle.Background = Brushes.LightGreen;
            }
            //GloryD live check
            string glou = @"https://api.twitch.tv/kraken/streams/gloryd?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var gloj = new WebClient().DownloadString(glou);

            Rootobject glor = JsonConvert.DeserializeObject<Rootobject>(gloj);
            Console.WriteLine(glor.stream);
            if (glor.stream == null)
            {
                GloryD.Background = Brushes.Red;
            }
            else
            {
                GloryD.Background = Brushes.LightGreen;
            }
            //Harryow live check
            string haru = @"https://api.twitch.tv/kraken/streams/harryow?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var harj = new WebClient().DownloadString(haru);

            Rootobject harr = JsonConvert.DeserializeObject<Rootobject>(harj);
            Console.WriteLine(harr.stream);
            if (harr.stream == null)
            {
                Harryow.Background = Brushes.Red;
            }
            else
            {
                Harryow.Background = Brushes.LightGreen;
            }
            //Hazard live check
            string hazu = @"https://api.twitch.tv/kraken/streams/hazard?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var hazj = new WebClient().DownloadString(hazu);

            Rootobject hazr = JsonConvert.DeserializeObject<Rootobject>(hazj);
            Console.WriteLine(hazr.stream);
            if (hazr.stream == null)
            {
                Hazard.Background = Brushes.Red;
            }
            else
            {
                Hazard.Background = Brushes.LightGreen;
            }
            //Hirona live check
            string hiru = @"https://api.twitch.tv/kraken/streams/hirona?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var hirj = new WebClient().DownloadString(hiru);

            Rootobject hirr = JsonConvert.DeserializeObject<Rootobject>(hirj);
            Console.WriteLine(hirr.stream);
            if (hirr.stream == null)
            {
                Hirona.Background = Brushes.Red;
            }
            else
            {
                Hirona.Background = Brushes.LightGreen;
            }
            //IamSp00n live check
            string iamu = @"https://api.twitch.tv/kraken/streams/iamsp00n?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var iamj = new WebClient().DownloadString(iamu);

            Rootobject iamr = JsonConvert.DeserializeObject<Rootobject>(iamj);
            Console.WriteLine(iamr.stream);
            if (iamr.stream == null)
            {
                IAmSp00n.Background = Brushes.Red;
            }
            else
            {
                IAmSp00n.Background = Brushes.LightGreen;
            }
            //ImmortalLive live check
            string immu = @"https://api.twitch.tv/kraken/streams/immortallive?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var immj = new WebClient().DownloadString(immu);

            Rootobject immr = JsonConvert.DeserializeObject<Rootobject>(immj);
            Console.WriteLine(immr.stream);
            if (immr.stream == null)
            {
                ImmortalLive.Background = Brushes.Red;
            }
            else
            {
                ImmortalLive.Background = Brushes.LightGreen;
            }
            //ironmonkeytv live check
            string irou = @"https://api.twitch.tv/kraken/streams/ironmonkeytv?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var iroj = new WebClient().DownloadString(irou);

            Rootobject iror = JsonConvert.DeserializeObject<Rootobject>(iroj);
            Console.WriteLine(iror.stream);
            if (iror.stream == null)
            {
                ironmonkeytv.Background = Brushes.Red;
            }
            else
            {
                ironmonkeytv.Background = Brushes.LightGreen;
            }
            //itzButch live check
            string itzu = @"https://api.twitch.tv/kraken/streams/itzButch?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var itzj = new WebClient().DownloadString(itzu);

            Rootobject itzr = JsonConvert.DeserializeObject<Rootobject>(itzj);
            Console.WriteLine(itzr.stream);
            if (itzr.stream == null)
            {
                itzButch.Background = Brushes.Red;
            }
            else
            {
                itzButch.Background = Brushes.LightGreen;
            }
            //J_Reed live check
            string jreu = @"https://api.twitch.tv/kraken/streams/J_reed?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var jrej = new WebClient().DownloadString(jreu);

            Rootobject jrer = JsonConvert.DeserializeObject<Rootobject>(jrej);
            Console.WriteLine(jrer.stream);
            if (jrer.stream == null)
            {
                J_Reed.Background = Brushes.Red;
            }
            else
            {
                J_Reed.Background = Brushes.LightGreen;
            }
            //JAboodyShow live check
            string jabu = @"https://api.twitch.tv/kraken/streams/jaboodyshow?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var jabj = new WebClient().DownloadString(jabu);

            Rootobject jabr = JsonConvert.DeserializeObject<Rootobject>(jabj);
            Console.WriteLine(jabr.stream);
            if (jabr.stream == null)
            {
                JaboodyShow.Background = Brushes.Red;
            }
            else
            {
                JaboodyShow.Background = Brushes.LightGreen;
            }
        }
    }
}
