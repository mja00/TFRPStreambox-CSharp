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
using System.Threading;




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

        private void Form1_Shown(Object sender, EventArgs e)
        {

            MessageBox.Show("You are in the Form.Shown event.");

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
            ////Console.WriteLine(_1GUnit1r.stream);
            if (_1GUnit1r.stream != null && _1GUnit1r.stream.game == "Grand Theft Auto V")
            {
                _1GUnit1.Background = Brushes.LightGreen;
            }
            //AbdulHD Live check
            string abdulhdurl = @"https://api.twitch.tv/kraken/streams/AbDulHD?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var abdulhdjson = new WebClient().DownloadString(abdulhdurl);

            Rootobject abdulhdr = JsonConvert.DeserializeObject<Rootobject>(abdulhdjson);
            ////Console.WriteLine(abdulhdr.stream);
            if (abdulhdr.stream != null && abdulhdr.stream.game == "Grand Theft Auto V")
            {
                AbdulHD.Background = Brushes.LightGreen;
            }
            //AgentNorth live check
            string agentnorthurl = @"https://api.twitch.tv/kraken/streams/agentnorth?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var agentnorthjson = new WebClient().DownloadString(agentnorthurl);

            Rootobject agentnorthr = JsonConvert.DeserializeObject<Rootobject>(agentnorthjson);
            //Console.WriteLine(agentnorthr.stream);
            if (agentnorthr.stream != null && agentnorthr.stream.game == "Grand Theft Auto V")
            {
                AgentNorth.Background = Brushes.LightGreen;
            }
            //alexusnightingale live check
            string alexusnightingaleurl = @"https://api.twitch.tv/kraken/streams/alexusnightingale?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var alexusnightingalejson = new WebClient().DownloadString(alexusnightingaleurl);

            Rootobject alexusnightingaler = JsonConvert.DeserializeObject<Rootobject>(alexusnightingalejson);
            //Console.WriteLine(alexusnightingaler.stream);
            if (alexusnightingaler.stream != null && alexusnightingaler.stream.game == "Grand Theft Auto V")
            {
                alexusnightingale.Background = Brushes.LightGreen;
            }
            //AndyMilonakis live check
            string andyurl = @"https://api.twitch.tv/kraken/streams/andymilonakis?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var andyjson = new WebClient().DownloadString(andyurl);

            Rootobject andyr = JsonConvert.DeserializeObject<Rootobject>(andyjson);
            //Console.WriteLine(andyr.stream);
            if (andyr.stream != null && andyr.stream.game == "Grand Theft Auto V")
            {
                AndyMilonakis.Background = Brushes.LightGreen;
            }
            //anthonyz_ live check
            string anturl = @"https://api.twitch.tv/kraken/streams/anthonyz_?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var antjson = new WebClient().DownloadString(anturl);

            Rootobject antr = JsonConvert.DeserializeObject<Rootobject>(antjson);
            //Console.WriteLine(antr.stream);
            if (antr.stream != null && antr.stream.game == "Grand Theft Auto V")
            {
                anthonyz_.Background = Brushes.LightGreen;
            }
            //BFLY003 live check
            string bflyurl = @"https://api.twitch.tv/kraken/streams/BFLY003?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var bflyjson = new WebClient().DownloadString(bflyurl);

            Rootobject bflyr = JsonConvert.DeserializeObject<Rootobject>(bflyjson);
            //Console.WriteLine(bflyr.stream);
            if (bflyr.stream != null && bflyr.stream.game == "Grand Theft Auto V")
            {
                BFLY003.Background = Brushes.LightGreen;
            }
            //boscoreli live check
            string boscoreliurl = @"https://api.twitch.tv/kraken/streams/boscoreli_gaming?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var boscorelijson = new WebClient().DownloadString(boscoreliurl);

            Rootobject boscorelir = JsonConvert.DeserializeObject<Rootobject>(boscorelijson);
            //Console.WriteLine(boscorelir.stream);
            if (boscorelir.stream != null && boscorelir.stream.game == "Grand Theft Auto V")
            {
                boscoreli_gaming.Background = Brushes.LightGreen;
            }
            //BPZ live check
            string bpzurl = @"https://api.twitch.tv/kraken/streams/BPZ?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var bpzjson = new WebClient().DownloadString(bpzurl);

            Rootobject bpzr = JsonConvert.DeserializeObject<Rootobject>(bpzjson);
            //Console.WriteLine(bpzr.stream);
            if (bpzr.stream != null && bpzr.stream.game == "Grand Theft Auto V")
            {
                BPZ.Background = Brushes.LightGreen;
            }
            //BuckkNaked live check
            string buckurl = @"https://api.twitch.tv/kraken/streams/buckknaked?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var buckjson = new WebClient().DownloadString(buckurl);

            Rootobject buckr = JsonConvert.DeserializeObject<Rootobject>(buckjson);
            //Console.WriteLine(buckr.stream);
            if (buckr.stream != null && buckr.stream.game == "Grand Theft Auto V")
            {
                BuckkNaked.Background = Brushes.LightGreen;
            }
            //BurkeBlack live check
            string burkeurl = @"https://api.twitch.tv/kraken/streams/BurkeBlack?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var burkej = new WebClient().DownloadString(burkeurl);

            Rootobject burker = JsonConvert.DeserializeObject<Rootobject>(burkej);
            //Console.WriteLine(burker.stream);
            if (burker.stream != null && burker.stream.game == "Grand Theft Auto V")
            {
                BurkeBlack.Background = Brushes.LightGreen;
            }
            //Ch1ckenb0ne live check
            string chicku = @"https://api.twitch.tv/kraken/streams/ch1ckenb0ne?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var chickj = new WebClient().DownloadString(chicku);

            Rootobject chickr = JsonConvert.DeserializeObject<Rootobject>(chickj);
            //Console.WriteLine(chickr.stream);
            if (chickr.stream != null && chickr.stream.game == "Grand Theft Auto V")
            {
                Ch1ckenb0ne.Background = Brushes.LightGreen;
            }
            //ChiefDas live check
            string chiefu = @"https://api.twitch.tv/kraken/streams/ChiefDas?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var chiefj = new WebClient().DownloadString(chiefu);

            Rootobject chiefr = JsonConvert.DeserializeObject<Rootobject>(chiefj);
            //Console.WriteLine(chiefr.stream);
            if (chiefr.stream != null && chiefr.stream.game == "Grand Theft Auto V")
            {
                ChiefDas.Background = Brushes.LightGreen;
            }
            //classypax live check
            string classyu = @"https://api.twitch.tv/kraken/streams/ClassyPax?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var classyj = new WebClient().DownloadString(classyu);

            Rootobject classyr = JsonConvert.DeserializeObject<Rootobject>(classyj);
            //Console.WriteLine(classyr.stream);
            if (classyr.stream != null && classyr.stream.game == "Grand Theft Auto V")
            {
                ClassyPax.Background = Brushes.LightGreen;
            }
            //cletusbueford live check
            string cletu = @"https://api.twitch.tv/kraken/streams/cletusbeuford?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var cletj = new WebClient().DownloadString(cletu);

            Rootobject cletr = JsonConvert.DeserializeObject<Rootobject>(cletj);
            //Console.WriteLine(cletr.stream);
            if (cletr.stream != null && cletr.stream.game == "Grand Theft Auto V")
            {
                CletusBueford.Background = Brushes.LightGreen;
            }
            //CoolidgeHD live check
            string coolu = @"https://api.twitch.tv/kraken/streams/coolidgehd?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var coolj = new WebClient().DownloadString(coolu);

            Rootobject coolr = JsonConvert.DeserializeObject<Rootobject>(coolj);
            //Console.WriteLine(coolr.stream);
            if (coolr.stream != null && coolr.stream.game == "Grand Theft Auto V")
            {
                CoolidgeHD.Background = Brushes.LightGreen;
            }
            //dasMehdi live check
            string dasu = @"https://api.twitch.tv/kraken/streams/dasmehdi?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var dasj = new WebClient().DownloadString(dasu);

            Rootobject dasr = JsonConvert.DeserializeObject<Rootobject>(dasj);
            //Console.WriteLine(dasr.stream);
            if (dasr.stream != null && dasr.stream.game == "Grand Theft Auto V")
            {
                dasMehdi.Background = Brushes.LightGreen;
            }
            //DisbeArex live check
            string disu = @"https://api.twitch.tv/kraken/streams/disbearex?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var disj = new WebClient().DownloadString(disu);

            Rootobject disr = JsonConvert.DeserializeObject<Rootobject>(disj);
            //Console.WriteLine(disr.stream);
            if (disr.stream != null && disr.stream.game == "Grand Theft Auto V")
            {
                DisbeArex.Background = Brushes.LightGreen;
            }
            //djkwix live check
            string djku = @"https://api.twitch.tv/kraken/streams/djkwix?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var djkj = new WebClient().DownloadString(djku);

            Rootobject djkr = JsonConvert.DeserializeObject<Rootobject>(djkj);
            //Console.WriteLine(djkr.stream);
            if (djkr.stream != null && djkr.stream.game == "Grand Theft Auto V")
            {
                djkwix.Background = Brushes.LightGreen;
            }
            //DrunkBabyYoshi live check
            string drunu = @"https://api.twitch.tv/kraken/streams/drunkbabyyoshi?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var drunj = new WebClient().DownloadString(drunu);

            Rootobject drunr = JsonConvert.DeserializeObject<Rootobject>(drunj);
            //Console.WriteLine(drunr.stream);
            if (drunr.stream != null && drunr.stream.game == "Grand Theft Auto V")
            {
                DrunkBabyYoshi.Background = Brushes.LightGreen;
            }
            //Esoluu live check
            string esou = @"https://api.twitch.tv/kraken/streams/esoluu?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var esoj = new WebClient().DownloadString(esou);

            Rootobject esor = JsonConvert.DeserializeObject<Rootobject>(esoj);
            //Console.WriteLine(esor.stream);
            if (esor.stream != null && esor.stream.game == "Grand Theft Auto V")
            {
                Esoluu.Background = Brushes.LightGreen;
            }
            //finkone live check
            string finu = @"https://api.twitch.tv/kraken/streams/finkone?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var finj = new WebClient().DownloadString(finu);

            Rootobject finr = JsonConvert.DeserializeObject<Rootobject>(finj);
            //Console.WriteLine(finr.stream);
            if (finr.stream != null && finr.stream.game == "Grand Theft Auto V")
            {
                Finkone.Background = Brushes.LightGreen;
            }
            //Fistofthewalrus live check
            string fisu = @"https://api.twitch.tv/kraken/streams/fistofthewalrus?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var fisj = new WebClient().DownloadString(fisu);

            Rootobject fisr = JsonConvert.DeserializeObject<Rootobject>(fisj);
            //Console.WriteLine(fisr.stream);
            if (fisr.stream != null && fisr.stream.game == "Grand Theft Auto V")
            {
                FistofTheWalrus.Background = Brushes.LightGreen;
            }
            //Five0anthO live check
            string fiveu = @"https://api.twitch.tv/kraken/streams/five0antho?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var fivej = new WebClient().DownloadString(fiveu);

            Rootobject fiver = JsonConvert.DeserializeObject<Rootobject>(fivej);
            //Console.WriteLine(fiver.stream);
            if (fiver.stream != null && fiver.stream.game == "Grand Theft Auto V")
            {
                Five0AnthO.Background = Brushes.LightGreen;
            }
            //GeeFamous92 live check
            string geeu = @"https://api.twitch.tv/kraken/streams/geefamous92?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var geej = new WebClient().DownloadString(geeu);

            Rootobject geer = JsonConvert.DeserializeObject<Rootobject>(geej);
            //Console.WriteLine(geer.stream);
            if (geer.stream != null && geer.stream.game == "Grand Theft Auto V")
            {
                GeeFamous92.Background = Brushes.LightGreen;
            }
            //GhilleGuyTV live check
            string ghiu = @"https://api.twitch.tv/kraken/streams/ghilleguytv?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var ghij = new WebClient().DownloadString(ghiu);

            Rootobject ghir = JsonConvert.DeserializeObject<Rootobject>(ghij);
            //Console.WriteLine(ghir.stream);
            if (ghir.stream != null && ghir.stream.game == "Grand Theft Auto V")
            {
                GhilleGuyTV.Background = Brushes.LightGreen;
            }
            //GiantFaffle live check
            string giau = @"https://api.twitch.tv/kraken/streams/giantfaffle?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var giaj = new WebClient().DownloadString(giau);

            Rootobject giar = JsonConvert.DeserializeObject<Rootobject>(giaj);
            //Console.WriteLine(giar.stream);
            if (giar.stream != null && giar.stream.game == "Grand Theft Auto V")
            {
                GiantFaffle.Background = Brushes.LightGreen;
            }
            //GloryD live check
            string glou = @"https://api.twitch.tv/kraken/streams/gloryd?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var gloj = new WebClient().DownloadString(glou);

            Rootobject glor = JsonConvert.DeserializeObject<Rootobject>(gloj);
            //Console.WriteLine(glor.stream);
            if (glor.stream != null && glor.stream.game == "Grand Theft Auto V")
            {
                GloryD.Background = Brushes.LightGreen;
            }
            //Harryow live check
            string haru = @"https://api.twitch.tv/kraken/streams/harryow?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var harj = new WebClient().DownloadString(haru);

            Rootobject harr = JsonConvert.DeserializeObject<Rootobject>(harj);
            //Console.WriteLine(harr.stream);
            if (harr.stream != null && harr.stream.game == "Grand Theft Auto V")
            {
                Harryow.Background = Brushes.LightGreen;
            }
            //Hazard live check
            string hazu = @"https://api.twitch.tv/kraken/streams/hazard?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var hazj = new WebClient().DownloadString(hazu);

            Rootobject hazr = JsonConvert.DeserializeObject<Rootobject>(hazj);
            //Console.WriteLine(hazr.stream);
            if (hazr.stream != null && hazr.stream.game == "Grand Theft Auto V")
            {
                Hazard.Background = Brushes.LightGreen;
            }
            //Hirona live check
            string hiru = @"https://api.twitch.tv/kraken/streams/hirona?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var hirj = new WebClient().DownloadString(hiru);

            Rootobject hirr = JsonConvert.DeserializeObject<Rootobject>(hirj);
            //Console.WriteLine(hirr.stream);
            if (hirr.stream != null && hirr.stream.game == "Grand Theft Auto V")
            {
                Hirona.Background = Brushes.LightGreen;
            }
            //IamSp00n live check
            string iamu = @"https://api.twitch.tv/kraken/streams/iamsp00n?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var iamj = new WebClient().DownloadString(iamu);

            Rootobject iamr = JsonConvert.DeserializeObject<Rootobject>(iamj);
            //Console.WriteLine(iamr.stream);
            if (iamr.stream != null && iamr.stream.game == "Grand Theft Auto V")
            {
                IAmSp00n.Background = Brushes.LightGreen;
            }
            //ImmortalLive live check
            string immu = @"https://api.twitch.tv/kraken/streams/immortallive?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var immj = new WebClient().DownloadString(immu);

            Rootobject immr = JsonConvert.DeserializeObject<Rootobject>(immj);
            //Console.WriteLine(immr.stream);
            if (immr.stream != null && immr.stream.game == "Grand Theft Auto V")
            {
                ImmortalLive.Background = Brushes.LightGreen;
            }
            //ironmonkeytv live check
            string irou = @"https://api.twitch.tv/kraken/streams/ironmonkeytv?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var iroj = new WebClient().DownloadString(irou);

            Rootobject iror = JsonConvert.DeserializeObject<Rootobject>(iroj);
            //Console.WriteLine(iror.stream);
            if (iror.stream != null && iror.stream.game == "Grand Theft Auto V")
            {
                ironmonkeytv.Background = Brushes.LightGreen;
            }
            //itzButch live check
            string itzu = @"https://api.twitch.tv/kraken/streams/itzButch?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var itzj = new WebClient().DownloadString(itzu);

            Rootobject itzr = JsonConvert.DeserializeObject<Rootobject>(itzj);
            //Console.WriteLine(itzr.stream);
            if (itzr.stream != null && itzr.stream.game == "Grand Theft Auto V")
            {
                itzButch.Background = Brushes.LightGreen;
            }
            //J_Reed live check
            string jreu = @"https://api.twitch.tv/kraken/streams/J_reed?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var jrej = new WebClient().DownloadString(jreu);

            Rootobject jrer = JsonConvert.DeserializeObject<Rootobject>(jrej);
            //Console.WriteLine(jrer.stream);
            if (jrer.stream != null && jrer.stream.game == "Grand Theft Auto V")
            {
                J_Reed.Background = Brushes.LightGreen;
            }
            //JAboodyShow live check
            string jabu = @"https://api.twitch.tv/kraken/streams/jaboodyshow?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var jabj = new WebClient().DownloadString(jabu);

            Rootobject jabr = JsonConvert.DeserializeObject<Rootobject>(jabj);
            //Console.WriteLine(jabr.stream);
            if (jabr.stream != null && jabr.stream.game == "Grand Theft Auto V")
            {
                JaboodyShow.Background = Brushes.LightGreen;
            }
            //jake_terek live check
            string jaku = @"https://api.twitch.tv/kraken/streams/jake_terek?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var jakj = new WebClient().DownloadString(jaku);

            Rootobject jakr = JsonConvert.DeserializeObject<Rootobject>(jakj);
            //Console.WriteLine(jakr.stream);
            if (jakr.stream != null && jakr.stream.game == "Grand Theft Auto V")
            {
                jake_terek.Background = Brushes.LightGreen;
            }
            //JmxTwiztid live check
            string jmxu = @"https://api.twitch.tv/kraken/streams/jmxtwiztid?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var jmxj = new WebClient().DownloadString(jmxu);

            Rootobject jmxr = JsonConvert.DeserializeObject<Rootobject>(jmxj);
            //Console.WriteLine(jmxr.stream);
            if (jmxr.stream != null && jmxr.stream.game == "Grand Theft Auto V")
            {
                JmxTwiztid.Background = Brushes.LightGreen;
            }
            //John782 live check
            string johu = @"https://api.twitch.tv/kraken/streams/john782?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var johj = new WebClient().DownloadString(johu);

            Rootobject johr = JsonConvert.DeserializeObject<Rootobject>(johj);
            //Console.WriteLine(johr.stream);
            if (johr.stream != null && johr.stream.game == "Grand Theft Auto V")
            {
                John782.Background = Brushes.LightGreen;
            }
            //Jolly__Jess live check
            string jolu = @"https://api.twitch.tv/kraken/streams/Jolly__Jess?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var jolj = new WebClient().DownloadString(jolu);

            Rootobject jolr = JsonConvert.DeserializeObject<Rootobject>(jolj);
            //Console.WriteLine(jolr.stream);
            if (jolr.stream != null && jolr.stream.game == "Grand Theft Auto V")
            {
                Jolly__Jess.Background = Brushes.LightGreen;
            }
            //JTtroy live check
            string jttu = @"https://api.twitch.tv/kraken/streams/Jttroy?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var jttj = new WebClient().DownloadString(jttu);

            Rootobject jttr = JsonConvert.DeserializeObject<Rootobject>(jttj);
            //Console.WriteLine(jttr.stream);
            if (jttr.stream != null && jttr.stream.game == "Grand Theft Auto V")
            {
                JTtroy.Background = Brushes.LightGreen;
            }
            //kaceytron live check
            string kacu = @"https://api.twitch.tv/kraken/streams/kaceytron?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var kacj = new WebClient().DownloadString(kacu);

            Rootobject kacr = JsonConvert.DeserializeObject<Rootobject>(kacj);
            //Console.WriteLine(kacr.stream);
            if (kacr.stream != null && kacr.stream.game == "Grand Theft Auto V")
            {
                kaceytron.Background = Brushes.LightGreen;
            }
            //KaptainKPress live check
            string kapu = @"https://api.twitch.tv/kraken/streams/kaptainkpress?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var kapj = new WebClient().DownloadString(kapu);

            Rootobject kapr = JsonConvert.DeserializeObject<Rootobject>(kapj);
            //Console.WriteLine(kapr.stream);
            if (kapr.stream != null && kapr.stream.game == "Grand Theft Auto V")
            {
                KaptainKpress.Background = Brushes.LightGreen;
            }
            //KatieRouu live check
            string katu = @"https://api.twitch.tv/kraken/streams/jaboodyshow?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var katj = new WebClient().DownloadString(katu);

            Rootobject katr = JsonConvert.DeserializeObject<Rootobject>(katj);
            //Console.WriteLine(katr.stream);
            if (katr.stream != null && katr.stream.game == "Grand Theft Auto V")
            {
                KatieRouu.Background = Brushes.LightGreen;
            }
            //Kithicor27 live check
            string kitu = @"https://api.twitch.tv/kraken/streams/kithicor27?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var kitj = new WebClient().DownloadString(kitu);

            Rootobject kitr = JsonConvert.DeserializeObject<Rootobject>(kitj);
            //Console.WriteLine(kitr.stream);
            if (kitr.stream != null && kitr.stream.game == "Grand Theft Auto V")
            {
                Kithicor27.Background = Brushes.LightGreen;
            }
            //LarryX7 live check
            string laru = @"https://api.twitch.tv/kraken/streams/larryx7?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var larj = new WebClient().DownloadString(laru);

            Rootobject larr = JsonConvert.DeserializeObject<Rootobject>(larj);
            //Console.WriteLine(larr.stream);
            if (larr.stream != null && larr.stream.game == "Grand Theft Auto V")
            {
                LarryX7.Background = Brushes.LightGreen;
            }
            //lawdog1096 live check
            string lawu = @"https://api.twitch.tv/kraken/streams/lawdog1096?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var lawj = new WebClient().DownloadString(lawu);

            Rootobject lawr = JsonConvert.DeserializeObject<Rootobject>(lawj);
            //Console.WriteLine(lawr.stream);
            if (lawr.stream != null && lawr.stream.game == "Grand Theft Auto V")
            {
                lawdog1096.Background = Brushes.LightGreen;
            }
            //LiftYourGame live check
            string lifu = @"https://api.twitch.tv/kraken/streams/lifeyourgame?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var lifj = new WebClient().DownloadString(lifu);

            Rootobject lifr = JsonConvert.DeserializeObject<Rootobject>(lifj);
            //Console.WriteLine(lifr.stream);
            if (lifr.stream != null && lifr.stream.game == "Grand Theft Auto V")
            {
                KatieRouu.Background = Brushes.LightGreen;
            }
            //loveANG3L live check
            string lovu = @"https://api.twitch.tv/kraken/streams/loveang3l?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var lovj = new WebClient().DownloadString(lovu);

            Rootobject lovr = JsonConvert.DeserializeObject<Rootobject>(lovj);
            //Console.WriteLine(lovr.stream);
            if (lovr.stream != null && lovr.stream.game == "Grand Theft Auto V")
            {
                loveANF3L.Background = Brushes.LightGreen;
            }
            //mart1n_g live check
            string maru = @"https://api.twitch.tv/kraken/streams/mart1n_g?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var marj = new WebClient().DownloadString(maru);

            Rootobject marr = JsonConvert.DeserializeObject<Rootobject>(marj);
            //Console.WriteLine(marr.stream);
            if (marr.stream != null && marr.stream.game == "Grand Theft Auto V")
            {
                mart1n_g.Background = Brushes.LightGreen;
            }
            //MiltonTPike1 live check
            string milu = @"https://api.twitch.tv/kraken/streams/MiltonTPike1?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var milj = new WebClient().DownloadString(milu);

            Rootobject milr = JsonConvert.DeserializeObject<Rootobject>(milj);
            //Console.WriteLine(milr.stream);
            if (milr.stream != null && milr.stream.game == "Grand Theft Auto V")
            {
                MiltonTPike1.Background = Brushes.LightGreen;
            }
            //MintsTV live check
            string minu = @"https://api.twitch.tv/kraken/streams/mintstv?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var minj = new WebClient().DownloadString(minu);

            Rootobject minr = JsonConvert.DeserializeObject<Rootobject>(minj);
            //Console.WriteLine(minr.stream);
            if (minr.stream != null && minr.stream.game == "Grand Theft Auto V")
            {
                MintsTV.Background = Brushes.LightGreen;
            }
            //MrMoonsHouse live check
            string mrmu = @"https://api.twitch.tv/kraken/streams/mrmoonshouse?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var mrmj = new WebClient().DownloadString(mrmu);

            Rootobject mrmr = JsonConvert.DeserializeObject<Rootobject>(mrmj);
            //Console.WriteLine(mrmr.stream);
            if (mrmr.stream != null && mrmr.stream.game == "Grand Theft Auto V")
            {
                MrMoonsHouse.Background = Brushes.LightGreen;
            }
            //MsDeathRabbit live check
            string msdu = @"https://api.twitch.tv/kraken/streams/msdeathrabbit?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var msdj = new WebClient().DownloadString(msdu);

            Rootobject msdr = JsonConvert.DeserializeObject<Rootobject>(msdj);
            //Console.WriteLine(msdr.stream);
            if (msdr.stream != null && msdr.stream.game == "Grand Theft Auto V")
            {
                MsDeathRabbit.Background = Brushes.LightGreen;
            }
            //OG_BluePill live check
            string ogu = @"https://api.twitch.tv/kraken/streams/og_bluepill?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var ogj = new WebClient().DownloadString(ogu);

            Rootobject ogr = JsonConvert.DeserializeObject<Rootobject>(ogj);
            //Console.WriteLine(ogr.stream);
            if (ogr.stream != null && ogr.stream.game == "Grand Theft Auto V")
            {
                Og_BluePill.Background = Brushes.LightGreen;
            }
            //PENTAhearth live check
            string penu = @"https://api.twitch.tv/kraken/streams/pentahearth?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var penj = new WebClient().DownloadString(penu);

            Rootobject penr = JsonConvert.DeserializeObject<Rootobject>(penj);
            //Console.WriteLine(penr.stream);
            if (penr.stream != null && penr.stream.game == "Grand Theft Auto V")
            {
                PENTAhearth.Background = Brushes.LightGreen;
            }
            //Pinky live check
            string pinu = @"https://api.twitch.tv/kraken/streams/Pinky?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var pinj = new WebClient().DownloadString(pinu);

            Rootobject pinr = JsonConvert.DeserializeObject<Rootobject>(pinj);
            //Console.WriteLine(pinr.stream);
            if (pinr.stream != null && pinr.stream.game == "Grand Theft Auto V")
            {
                Pinky.Background = Brushes.LightGreen;
            }
            //PmsProxy live check
            string pmsu = @"https://api.twitch.tv/kraken/streams/pmsproxy?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var pmsj = new WebClient().DownloadString(pmsu);

            Rootobject pmsr = JsonConvert.DeserializeObject<Rootobject>(pmsj);
            //Console.WriteLine(pmsr.stream);
            if (pmsr.stream != null && pmsr.stream.game == "Grand Theft Auto V")
            {
                PmsProxy.Background = Brushes.LightGreen;
            }
            //PorkMarshmallow live check
            string poru = @"https://api.twitch.tv/kraken/streams/porkmarshmallow?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var porj = new WebClient().DownloadString(poru);

            Rootobject porr = JsonConvert.DeserializeObject<Rootobject>(porj);
            //Console.WriteLine(porr.stream);
            if (porr.stream != null && porr.stream.game == "Grand Theft Auto V")
            {
                PorkMarshmallow.Background = Brushes.LightGreen;
            }
            //PrimusPalus live check
            string priu = @"https://api.twitch.tv/kraken/streams/primuspalus?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var prij = new WebClient().DownloadString(priu);

            Rootobject prir = JsonConvert.DeserializeObject<Rootobject>(prij);
            //Console.WriteLine(prir.stream);
            if (prir.stream != null && prir.stream.game == "Grand Theft Auto V")
            {
                PrimusPalus.Background = Brushes.LightGreen;
            }
            //Purrluna live check
            string puru = @"https://api.twitch.tv/kraken/streams/purrluna?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var purj = new WebClient().DownloadString(puru);

            Rootobject purr = JsonConvert.DeserializeObject<Rootobject>(purj);
            //Console.WriteLine(purr.stream);
            if (purr.stream != null && purr.stream.game == "Grand Theft Auto V")
            {
                Purrluna.Background = Brushes.LightGreen;
            }
            //Pydrex live check
            string pydu = @"https://api.twitch.tv/kraken/streams/Pydrex?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var pydj = new WebClient().DownloadString(pydu);

            Rootobject pydr = JsonConvert.DeserializeObject<Rootobject>(pydj);
            //Console.WriteLine(pydr.stream);
            if (pydr.stream != null && pydr.stream.game == "Grand Theft Auto V")
            {
                Pydrex.Background = Brushes.LightGreen;
            }

            Refresh.Background = Brushes.LightGreen;
            Refresh.Content = "Refreshed";

        }
    }
}
