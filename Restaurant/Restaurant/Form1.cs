using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class LimitCafe : Form
    {
        public LimitCafe()
        {
            InitializeComponent();
        }

        int kruvasansayi, cheescakesayi, baklavasayi, kunefesayi, kadayifsayi, kazandibisayi, brownisayi, revanisayi;
        int kolasayi, fantasayi, ayransayi, sodasayi, caysayi, oraletsayi, susayi, gazozsayi;
        string kruvasanx, cheescakex, baklavax, künefex, kadayıfx, kazandibix, brownix, revanix;
        string kolax, fantax, ayranx, sodax, çayx, oraletx, sux, gazozx;

        private void ayranbtn_Click(object sender, EventArgs e)
        {
            say33 = Convert.ToInt32(ayranlbl1.Text);
            ayranx = (ayranlbl.Text);
            listBox3.Text = ayranx.ToString() + "--" + say33.ToString();
            listBox3.Items.Add(ayranlbl.Text + "--" + say33.ToString());
        }

        private void sodabtn_Click(object sender, EventArgs e)
        {
            say44 = Convert.ToInt32(sodalbl1.Text);
            sodax = (sodalbl.Text);
            listBox3.Text = sodax.ToString() + "--" + say44.ToString();
            listBox3.Items.Add(sodalbl.Text + "--" + say44.ToString());

        }

        private void çaybtn_Click(object sender, EventArgs e)
        {
            say55 = Convert.ToInt32(çaylbl1.Text);
            çayx = (çaylbl.Text);
            listBox3.Text = çayx.ToString() + "--" + say55.ToString();
            listBox3.Items.Add(çaylbl.Text + "--" + say55.ToString());
        }

        private void oraletbtn_Click(object sender, EventArgs e)
        {
            say66 = Convert.ToInt32(oraletlbl1.Text);
            oraletx = (oraletlbl.Text);
            listBox3.Text = oraletx.ToString() + "--" + say66.ToString();
            listBox3.Items.Add(oraletlbl.Text + "--" + say66.ToString());
        }

        private void subtn_Click(object sender, EventArgs e)
        {
            say77 = Convert.ToInt32(sulbl1.Text);
            sux = (sulbl.Text);
            listBox3.Text = sux.ToString() + "--" + say77.ToString();
            listBox3.Items.Add(sulbl.Text + "--" + say77.ToString());
        }

        private void gazozbtn_Click(object sender, EventArgs e)
        {
            say88 = Convert.ToInt32(gazozlbl1.Text);
            gazozx = (gazozlbl.Text);
            listBox3.Text = gazozx.ToString() + "--" + say88.ToString();
            listBox3.Items.Add(gazozlbl.Text + "--" + say88.ToString());
        }

        private void baklavabtn_Click(object sender, EventArgs e)
        {
            say3 = Convert.ToInt32(baklavalbl1.Text);
            baklavax = (baklavalbl.Text);
            listBox3.Text = baklavax.ToString() + "--" + say3.ToString();
            listBox3.Items.Add(baklavalbl.Text + "--" + say3.ToString());
        }

        private void künefebtn_Click(object sender, EventArgs e)
        {
            say4 = Convert.ToInt32(künefelbl1.Text);
            künefex = (künefelbl.Text);
            listBox3.Text = künefex.ToString() + "--" + say4.ToString();
            listBox3.Items.Add(künefelbl.Text + "--" + say4.ToString());
        }

        private void kadayıfbtn_Click(object sender, EventArgs e)
        {
            say5 = Convert.ToInt32(kadayıflbl1.Text);
            kadayıfx = (kadayıflbl.Text);
            listBox3.Text = kadayıfx.ToString() + "--" + say5.ToString();
            listBox3.Items.Add(kadayıflbl.Text + "--" + say5.ToString());
        }

        private void kazandibibtn_Click(object sender, EventArgs e)
        {
            say6 = Convert.ToInt32(kazandibilbl1.Text);
            kazandibix = (kazandibilbl.Text);
            listBox3.Text = kazandibix.ToString() + "--" + say6.ToString();
            listBox3.Items.Add(kazandibilbl.Text + "--" + say6.ToString());
        }

        private void brownibtn_Click(object sender, EventArgs e)
        {
            say7 = Convert.ToInt32(brownilbl1.Text);
            brownix = (brownilbl.Text);
            listBox3.Text = brownix.ToString() + "--" + say7.ToString();
            listBox3.Items.Add(brownilbl.Text + "--" + say7.ToString());
        }

        private void revanibtn_Click(object sender, EventArgs e)
        {
            say8 = Convert.ToInt32(revanilbl1.Text);
            revanix = (revanilbl.Text);
            listBox3.Text = revanix.ToString() + "--" + say8.ToString();
            listBox3.Items.Add(revanilbl.Text + "--" + say8.ToString());
        }

        private void fantabtn_Click(object sender, EventArgs e)
        {
            say22 = Convert.ToInt32(fantalbl1.Text);
            fantax = (fantalbl.Text);
            listBox3.Text = fantax.ToString() + "--" + say22.ToString();
            listBox3.Items.Add(fantalbl.Text + "--" + say22.ToString());
        }

        private void kolabtn_Click_1(object sender, EventArgs e)
        {
            say11 = Convert.ToInt32(kolalbl1.Text);
            kolax = (kolalbl.Text);
            listBox3.Text = kolax.ToString() + "--" + say11.ToString();
            listBox3.Items.Add(kolalbl.Text + "--" + say11.ToString());
        }
              
        int say1, say2, say3, say4, say5, say6, say7, say8;
        int say11, say22, say33, say44, say55, say66, say77, say88;


        private void fanta1(object sender, MouseEventArgs e)
        {
            System.Windows.Forms.Button p = (System.Windows.Forms.Button)sender;
            listBox1.Items.Add(listBox1.Text + 50);
            fantasayi++;
            fantalbl1.Text = fantasayi.ToString();
        }

        private void ayran1(object sender, MouseEventArgs e)
        {
            System.Windows.Forms.Button r = (System.Windows.Forms.Button)sender;
            listBox1.Items.Add(listBox1.Text + 50);
            ayransayi++;
            ayranlbl1.Text = ayransayi.ToString();
        }

        private void soda1(object sender, MouseEventArgs e)
        {
            System.Windows.Forms.Button s = (System.Windows.Forms.Button)sender;
            listBox1.Items.Add(listBox1.Text + 50);
            sodasayi++;
            sodalbl1.Text = sodasayi.ToString();
        }

        private void çay1(object sender, MouseEventArgs e)
        {
            System.Windows.Forms.Button t = (System.Windows.Forms.Button)sender;
            listBox1.Items.Add(listBox1.Text + 50);
            caysayi++;
            çaylbl1.Text = caysayi.ToString();
        }

        private void oralet1(object sender, MouseEventArgs e)
        {
            System.Windows.Forms.Button u = (System.Windows.Forms.Button)sender;
            listBox1.Items.Add(listBox1.Text + 50);
            oraletsayi++;
            oraletlbl1.Text = oraletsayi.ToString();
        }

        private void su1(object sender, MouseEventArgs e)
        {
            System.Windows.Forms.Button v = (System.Windows.Forms.Button)sender;
            listBox1.Items.Add(listBox1.Text + 50);
            susayi++;
            sulbl1.Text = susayi.ToString();
        }

        private void gazoz1(object sender, MouseEventArgs e)
        {
            System.Windows.Forms.Button v = (System.Windows.Forms.Button)sender;
            listBox1.Items.Add(listBox1.Text + 50);
            gazozsayi++;
            gazozlbl1.Text = gazozsayi.ToString();
        }       

        
        private void kruvasanbtn_Click(object sender, EventArgs e)
        {
            say1 = Convert.ToInt32(kruvasanlbl1.Text);
            kruvasanx = (kruvasanlbl.Text);
            listBox3.Text = kruvasanx.ToString() + "--" + say1.ToString();
            listBox3.Items.Add(kruvasanlbl.Text + "--" + say1.ToString());


        }
        private void cheescakebtn_Click(object sender, EventArgs e)
        {
            say2 = Convert.ToInt32(cheescakelbl1.Text);
            cheescakex = (cheescakelbl.Text);
            listBox3.Text = cheescakex.ToString() + "--" + say2.ToString();
            listBox3.Items.Add(cheescakelbl.Text + "--" + say2.ToString());

        }        

        private void baklava1(object sender, MouseEventArgs e)
        {
            System.Windows.Forms.Button i = (System.Windows.Forms.Button)sender;
            listBox2.Items.Add(listBox2.Text + 50);
            baklavasayi++;
            baklavalbl1.Text = baklavasayi.ToString();
            
        }

        private void künefe1(object sender, MouseEventArgs e)
        {
            System.Windows.Forms.Button j = (System.Windows.Forms.Button)sender;
            listBox2.Items.Add(listBox2.Text + 50);
            kunefesayi++;
            künefelbl1.Text = kunefesayi.ToString();
        }

        private void kadayıf1(object sender, MouseEventArgs e)
        {
            System.Windows.Forms.Button k = (System.Windows.Forms.Button)sender;
            listBox2.Items.Add(listBox2.Text + 50);
            kadayifsayi++;
            kadayıflbl1.Text = kadayifsayi.ToString();
        }

        private void kazandibi1(object sender, MouseEventArgs e)
        {
            System.Windows.Forms.Button l = (System.Windows.Forms.Button)sender;
            listBox2.Items.Add(listBox2.Text + 50);
            kazandibisayi++;
            kazandibilbl1.Text = kazandibisayi.ToString();
        }

        private void browni1(object sender, MouseEventArgs e)
        {
            System.Windows.Forms.Button m = (System.Windows.Forms.Button)sender;
            listBox2.Items.Add(listBox2.Text + 50);
            brownisayi++;
            brownilbl1.Text = brownisayi.ToString();
        }

        private void revani1(object sender, MouseEventArgs e)
        {
            System.Windows.Forms.Button n = (System.Windows.Forms.Button)sender;
            listBox2.Items.Add(listBox2.Text + 50);
            revanisayi++;
            revanilbl1.Text = revanisayi.ToString();
        }

        private void kola1(object sender, MouseEventArgs e)
        {
            System.Windows.Forms.Button o = (System.Windows.Forms.Button)sender;
            listBox1.Items.Add(listBox1.Text + 50);
            kolasayi++;
            kolalbl1.Text = kolasayi.ToString();
        }

        private void yiyecekler(object sender, EventArgs e)
        {
            System.Windows.Forms.Button b = (System.Windows.Forms.Button)sender;

            Yiyecekler1.Items.Add(Yiyecekler1.Text + b.Text);
        }

        private void İçecekler(object sender, EventArgs e)
        {
            System.Windows.Forms.Button c = (System.Windows.Forms.Button)sender;

            İçecekler1.Items.Add(İçecekler1.Text + c.Text);
        }

        private void mutfakfiyat(object sender, EventArgs e)
        {
            System.Windows.Forms.Button d = (System.Windows.Forms.Button)sender;

            listBox1.Items.Add(İçecekler1.Text + d.Text);
        }

        private void içeceklerkasa(object sender, EventArgs e)
        {
            System.Windows.Forms.Button f = (System.Windows.Forms.Button)sender;

            listBox2.Items.Add(İçecekler1.Text + f.Text);
        }
               

        private void kruvasan1(object sender, MouseEventArgs e)
        {
            System.Windows.Forms.Button g = (System.Windows.Forms.Button)sender;
            listBox2.Items.Add(listBox2.Text + 50);
            kruvasansayi ++;
            kruvasanlbl1.Text = kruvasansayi.ToString();
        }

        private void cheescake1(object sender, MouseEventArgs e)
        {
            System.Windows.Forms.Button h = (System.Windows.Forms.Button)sender;
            listBox2.Items.Add(listBox2.Text + 50);
            cheescakesayi ++;
            cheescakelbl1.Text = cheescakesayi.ToString();
        }

        private void siptop_Click(object sender, EventArgs e)
        {

            int kru = 0;
            for(int i = 0; i < listBox2.Items.Count;  i++)
            {
                kru += Convert.ToInt32(listBox2.Items[i]);
            }
            masa1toplamlbl.Text = kru.ToString();

            int sonuc = 0;
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                sonuc += Convert.ToInt32(listBox2.Items[i]);
            }
            masa1toplamlbl.Text = sonuc.ToString();

            int kruv = 0;
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                kru += Convert.ToInt32(listBox2.Items[i]);
            }
            masa1toplamlbl.Text = kru.ToString();

            int sonuc1 = 0;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                sonuc += Convert.ToInt32(listBox1.Items[i]);
            }
            masa1toplamlbl.Text = sonuc.ToString();           
        }
      
        
    }
}
