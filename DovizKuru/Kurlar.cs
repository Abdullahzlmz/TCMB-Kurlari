using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml; //XML kodlarımızı çevirmek için c#''ın System.XML kütüphanesini kullanıyoruz
using System.Xml.Linq; //TCMB'deki düğümlere göre veri çekmek için Lİnq kütüphanesini kullanıyoruz

namespace DovizKuru
{
    public partial class Kurlar : Form
    {
        public Kurlar()
        {
            InitializeComponent();
        }
        string tarih, ay, yil, tarih2,doviz;

       

        XDocument tcmbdoviz; //linq destekli bir şekilde xml dosyalarımızı okumak için XDocument tipinde bir değişken oluşturduk
        
        private void Form1_Load(object sender, EventArgs e)
        {
            txtTarih.Text = DateTime.Now.ToString();
           
            tarih = txtTarih.Text;
            ay = tarih.Substring(3, 2);
            yil = tarih.Substring(6, 4);
            tarih2 = tarih.Replace('.'.ToString(), "");
            try //Eğer kullanılan bilgisayarda internet yoksa veya tcmb'de bir hata ile karşılaşılılırsa programı durdurmayıp hata vermesi için try catch bloğu oluşturduk
            {
                tcmbdoviz = XDocument.Load("http://www.tcmb.gov.tr/kurlar/" + yil + ay + "/" + tarih2 + ".xml"); //değişkenimizin içerisine XML kodlarımızın bulunduğu sayfamızı yükledik
                                                                                                                 //(burada yıl ay ve tarih eklememizin sebebi geçmiş tarihli kur çekebilmemiz için) yani TCMB'Den geçmiş tarihli döviz çekmek için
                                                                                                                 //tcmb.gov.tr/kurlar/202304/10042023.xml şeklinde bir yol izlememiz gerekir
            }
            catch (Exception)
            {
                MessageBox.Show("Türkiye Cumhuriyeti Merkez Bankasına ulaşırken bağlantı zaman aşımına uğradı.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information); //kurlar sayfasına ulaşımda problem olduğunda dönecek hata
                throw;
            }

            var belge = new XmlDocument(); //XMLDocument sınıfında bir değişken oluşturduk
            doviz = "http://www.tcmb.gov.tr/kurlar/" + yil + ay + "/" + tarih2 + ".xml";
            belge.Load(doviz); //bu değişkenin içerisine yukarıdaki işlemdeki gibi xml sayfamızı yükledik
            try //kur bilgilerini çekememesi halinde programı kapatmayıp kullanıcıya hata vermesi için try catch bloğu oluşturduk
            {
                var kurbilgileri = from kur in tcmbdoviz.Descendants("Currency") //bu kısımda linq kullanarak kurbilgileri adlı değişkenin içerisine kur bilgilerini çekmek için kur bilgilerinin bulunduğu xml düğümünü alıyoruz
                                                                                 //tcmbdöviz.Descendants("Currency") --buradaki currency kurların bulunduğu düğümün adı
                                   where kur.Attribute("Kod") != null //burada Currency düğümünün içinde bulunan Kod düğümünün yani Döviz isminin bulunduğu alanın içeriğini kontrol edip eğer varsa kurları çekiyoruz.
                                   select new
                                   {
                                       dövizadi = kur.Attribute("Kod").Value //Kod adlı düğümün içerisinden dövizin ismini çekiyoruz.
                                   };
                foreach (var dovizler in kurbilgileri) //bu kısımda yukarıdaki oluşturduğumuz kurbilgileri dizisi kadar döner ve her bir döviz ismini comboBox kontrolünün içerisine ekler
                {
                    comboTCMBDovIsmi.Items.Add(dovizler.dövizadi.ToString());
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Veriler alınamadı. Hata :" + hata.Message);
                return;
            }
        }
        private void btnKurGetir_Click(object sender, EventArgs e)
        {
            string hata="";
            tarih = txtTarih.Text; //Form1'in açılışına yazdığımız için tarihi değiştirsek bile eski tarihteki kurları getirmeyip Formun ilk açıldığı tarihi almaması için butona her basıldığında aktif tarihi alması için burada tekrar ettik
            ay = tarih.Substring(3, 2); //tcmb'nin xml sayfasına kullanmak için tarih textboxundaki AY alanını bir değişkene atıyoruz
            yil = tarih.Substring(6, 4); //tcmb'nin xml sayfasına kullanmak için tarih textboxundaki YIL alanını bir değişkene atıyoruz
            tarih2 = tarih.Replace('.'.ToString(), ""); //geçmişe dönük kurları çekeceğimizde tarih formatının 10052023 şeklinde olması gerektiği için önce . karakterini stringe dönüştürüp daha sonra .'yı aradan siliyoruz.

            string dugum = comboTCMBDovIsmi.Text; //Form1'in açılışında comboBox'un içerisine çektiğimiz Currency/Kod düğümündeki döviz isimlerini seçilen kurun çekilmesi için dugum değişkeninin içerisine atıyoruz
            var belge = new XmlDocument(); //XMLDocument sınıfında bir değişken oluşturduk
            string guncelDoviz = "http://www.tcmb.gov.tr/kurlar/" + yil + ay + "/" + tarih2 + ".xml";
            try //Tatil günlerinde döviz kurlarına ulaşamadığı için sayfayada ulaşamaz bu yüzden hata verip programın kapanmaması için kontrol ettirdik eğer hata olursa hata değişkenine 1 sayısını atıp SelectSingleNode metodunu çalıştırmadık.
            {
                belge.Load(guncelDoviz); //bu değişkenin içerisine xml sayfamızı yükledik 
            }
            catch (Exception)
            {
                MessageBox.Show("Kurlar çekilemedi.Hata","Hata",MessageBoxButtons.OK, MessageBoxIcon.Error);
                hata = "1";
            }

            if (hata!="1")
            {
                string alis = belge.SelectSingleNode("Tarih_Date/Currency[@Kod='" + dugum + "']/BanknoteBuying").InnerXml; //burada alis değişkeninin içerisine, Tarih_Date düğümünün içerisinde bulunan ve Currency düğümününde içerisinde bulunan
                                                                                                                           //Kod düğümüne, seçtimiz Döviz Kodunun kurlarını getirmesi için eşittir koyduk ve dövizimizin kodunu gönderdik ve bu düğümün
                                                                                                                           //altındaki BanknoteBuying yani Dövizin alış fiyatını seçtik ve InnerXML ile bu düğümün içerisindeki texti aldık.
                                                                                                                           //Buradaki her '/' karakter bir sonraki düğüme geçtimizi gösteriyor.                                                                                                                       
                string satis = belge.SelectSingleNode("Tarih_Date/Currency[@Kod='" + dugum + "']/BanknoteSelling").InnerXml;
                string efektifalis = belge.SelectSingleNode("Tarih_Date/Currency[@Kod='" + dugum + "']/ForexBuying").InnerXml;
                string efektifsatis = belge.SelectSingleNode("Tarih_Date/Currency[@Kod='" + dugum + "']/ForexSelling").InnerXml;
                txtDovAlis.Text = alis; //InnerXML ile çektiğimiz kurları textboxumuzun içerisine aktarıyoruz.
                txtDovSatis.Text = satis;
                txtEfektifAlis.Text = efektifalis;
                txtEfektifSatis.Text = efektifsatis;
            }
            
        }

        private void comboTCMBDovIsmi_SelectedIndexChanged(object sender, EventArgs e) //seçtiğimiz döviz kodu her değiştiğinde adını bul ve TextBoxa yaz.
        {
            string hata = "1";
            string dugum = comboTCMBDovIsmi.Text;
            var belge = new XmlDocument(); //XMLDocument sınıfında bir değişken oluşturduk
            belge.Load(doviz); //bu değişkenin içerisine xml sayfamızı yükledik 
            string DovizAdi = belge.SelectSingleNode("Tarih_Date/Currency[@Kod='" + dugum + "']/Isim").InnerXml; //burada aynı fiyat çektiğimiz gibi dövizin adını çektik yani Fiyatların bulunduğu düğümler yerine Isim düğümünü kullandık.
            txtDovizAdi.Text = DovizAdi;
        }
    }
}
