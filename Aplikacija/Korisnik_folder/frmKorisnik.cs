using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.Mail;

namespace Aplikacija
{
    public partial class frmKorisnik : Form
    {
        public frmKorisnik()
        {
            InitializeComponent();
        }

        private void miObavijesti_Click(object sender, EventArgs e)
        {
            Korisnik.frmObavijesti obavijesti = new Korisnik.frmObavijesti();
            obavijesti.MdiParent = this;
            obavijesti.WindowState = FormWindowState.Maximized;
            obavijesti.Show();
        }

        private void miCjenik_Click(object sender, EventArgs e)
        {
            Korisnik.frmCjenik cjenik = new Korisnik.frmCjenik();
            cjenik.MdiParent = this;
            cjenik.WindowState = FormWindowState.Maximized;
            cjenik.Show();
        }

        private void miKlijenti_Click(object sender, EventArgs e)
        {
            Korisnik.frmKlijenti klijenti = new Korisnik.frmKlijenti();
            klijenti.MdiParent = this;
            klijenti.WindowState = FormWindowState.Maximized;
            klijenti.Show();
        }

        private void miRacun_Click(object sender, EventArgs e)
        {
            Korisnik.frmRacun racun = new Korisnik.frmRacun();
            racun.MdiParent = this;
            racun.WindowState = FormWindowState.Maximized;
            racun.Show();
        }

        private void miFileOdjava_Click(object sender, EventArgs e)
        {
            this.Close();
            Login.LoginForma.txtIme = null;
            Login.LoginForma.txtPassword = null;
            Login.LoginForma.Show();
        }

        public async void AsyncObavijest()
        {
            await Task.Run(() => Obavijest());
        }

        private void Obavijest()
        {
            //ovdje smo napravili novu instancu objekta klase SqlConnection i nazvali smo ga sc
            //prisjeti se...sc je nešto kao naziv varijable, ali kada radiš sa objektima onda možeš koristiti svojstva, kao što je to npr. ConnectionString
            //kojeg možeš vidjeti u liniji ispod instanciranja
            SqlConnection sc = new SqlConnection();
            //ConnectionString ti je obavezan za spajanje na bilo kakvu bazu jer moraš odrediti kakva je baza (lokalna, na udaljenom serveru,...),
            //gdje se ta baza nalazi(na kojoj lokaciji; na kojem path-u), moraš dati ime baze koju hoćeš koristiti (kako bi inače odredio s kojom bazom radiš),
            //i na kraju moraš odrediti da li je veza sigurna i da li postoji kakav account vezan za bazu
            sc.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Baza.mdf;Integrated Security=True";
            SqlConnection sc2 = new SqlConnection();
            sc2.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Baza.mdf;Integrated Security=True";
            //sve vrste sql upita moraš stavljati u string 
            string selectUpit = "SELECT * FROM Klijent";
            //SQL upit koji vraća samo zadnji redak u tablici
            string selectUpit2 = "SELECT * FROM CRM WHERE id_CRM=(SELECT MAX(id_CRM) FROM CRM)";

            //tu radimo provjeru da li su polja za unos username-a i password-a prazni, jer ako jesu onda nema smisla pretraživati bazu korisnika jer niti 
            //jedan korisnik ne bi smio imati prazan username i prazan password

            //nakon što je aplikacija potvrdila da niti jedno niti drugo polje nisu prazni onda otvara vezu prema bazi (sc.Open) kako bi se mogli slati upiti
            //na bazu kako bi sa bazom mogao nešto raditi
            sc.Open();
            sc2.Open();

            using (var command2 = new SqlCommand(selectUpit2, sc2))
            {
                SqlDataReader zadnjiRedak = null;
                zadnjiRedak = command2.ExecuteReader();
                try
                {
                    while (zadnjiRedak.Read())
                    {
                        CRM crm = new CRM();
                        crm.VrijemeProvjere = Convert.ToInt32(zadnjiRedak["vrijeme_provjere"].ToString());
                    }
                }
                catch (SqlException sqlex)
                {
                    MessageBox.Show(sqlex.Message);
                }
            }
            //ovaj using te ne smije zbunjivati, on se u dvije svrhe koristi:
            //1. da bi na početku programa pozvao sve potrebne namspace-ove
            //2. da bi naznačio dio koda u kojem ćeš raditi sa objektom, te kada se taj dio koda završi, automatski će se pozvati metoda Dispose bez tvojeg
            //znanja, kako bi se taj objekt uništio preko Garbage Collectora. Svaka klasa koja implementira IDisposable interfejs (to možeš vidjeti na MSDN)
            //znači da je poželjno raditi preko using izraza
            using (var command = new SqlCommand(selectUpit, sc))
            {
                //ovo ti je dobar pokazatelj kako inače možeš deklarirati objekt u jednom dijelu koda, a inicijalizirati ga poslije, a kada to radiš
                //onda zapravo radiš inicijalizaciju sa null vrijednošću kao što možeš i vidjeti jer će ti se u suprotnom javljati exception da nisi napravio
                //inicijalizaciju objekta
                SqlDataReader klijentReader = null;
                //ovdje se je napravila konkretna inicijalizacija objekta i to si rekao da će objekt poprimiti vrijednost koju vrati ExecuteReader metoda
                //koja je unutar klase SqlCommand
                klijentReader = command.ExecuteReader();

                try
                {
                    while (klijentReader.Read())
                    {
                        using (Klijenti klijenti2 = new Klijenti())
                        {
                            //kao konstruktor pošiljatelja moraš staviti od kuda ide mail
                            System.Net.Mail.MailAddress posiljatelj = new MailAddress("modernizacija.crm@live.com");

                            string datum = klijentReader["zadnji_dolazak"].ToString();

                            string[] razdjeljeniDatum = datum.Split(' ');

                            string[] razdjeljeniDatum2 = razdjeljeniDatum[0].Split('/');

                            klijenti2.Dan = Convert.ToInt32(razdjeljeniDatum2[1]);
                            klijenti2.Mjesec = Convert.ToInt32(razdjeljeniDatum2[0]);
                            klijenti2.Godina = Convert.ToInt32(razdjeljeniDatum2[2]);

                            MessageBox.Show(klijenti2.Dan.GetType().ToString());
                            DateTime dt = new DateTime(klijenti2.Godina, klijenti2.Mjesec, klijenti2.Dan);

                            DateTime dt2 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);

                            if (dt2.Subtract(dt).Days > Convert.ToInt16(klijentReader["vrijeme_provjere"].ToString()))
                            {
                                //tu sam kao parametar stavio stupac email tako da može svakom klijentu poslati mail
                                System.Net.Mail.MailAddress primatelj = new MailAddress(klijentReader["email"].ToString());

                                System.Net.Mail.MailMessage message = new MailMessage(posiljatelj, primatelj);
                                message.From = posiljatelj;
                                message.To.Add(primatelj.Address);

                                //U body ti ide tekst koji šalješ kao mail
                                //S obzirom na to da si rekao kako će više vrsta mailova biti onda si napravi klasu koja će u sebi
                                //imati read only svojstva (pogledaj na google kako ide read only
                                //Svako svojstvo će ti biti jedna poruka u kojoj će ti već biti definiran tekst maila
                                //ja bum napravio provjeru kome treba koji mail ići ali ti složi poruke
                                message.Body = "Poštovani," + Environment.NewLine + "podsjećamo Vas kako niste posjetili naš salon " + dt2.Subtract(dt).Days + " dana." +
                                    Environment.NewLine + "Posjetite nas, te provjerite da li imate prava na popust." + Environment.NewLine + "Hvala lijepa.";

                                message.Sender = posiljatelj;

                                System.Net.Mail.SmtpClient klijent = new SmtpClient("smtp.live.com", 587);
                                klijent.EnableSsl = true;
                                //Ovdje moraš za prvi parametar staviti svoj email s kojim se logiraš, a kao drugi parametar ti je password
                                //To si rađe za ovaj projekt napravite neki zajednički mail da jedan drugome ne bi hakirali mailove
                                //obavezno mora biti hotmail jer je sve napravljeno za hotmail
                                klijent.Credentials = new System.Net.NetworkCredential("modernizacija.crm@live.com", "PIcrm2013!!");
                                klijent.Send(message);
                                klijent.SendCompleted += (sender2, e2) =>
                                {
                                    Properties.Settings.Default.BrojPoslanihMailova++;
                                };
                            }
                        }
                    }
                    sc.Close();
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
