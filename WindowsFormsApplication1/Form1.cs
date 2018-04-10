using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        /* Student A: Hadriel Benjo - 302185061 */
        /* Student B: Adir    Zoari - 203002753 */

        public static Vigenere vgnr { get; set; }
        public Form1()
        {
            InitializeComponent();
            vgnr = new Vigenere();
            getKeyMockFromPlainTextMock();
        }
        /* run mock test*/
        public void getKeyMockFromPlainTextMock()
        {
            btn_clear_text_Click(null, null);
            checkAllEnableButtonTogether();
            textBox_ciphertext.Text = cipherText_mock;
            btn_find_key_Click(null, null);
        }

        /* Do operation to Encrypt / Decrypt / FindKeyDecrypt */ 
        private void btn_toEncrypt_Click_1(object sender, EventArgs e)
        {
            if(btn_toEncrypt.ForeColor != Color.Gray) { 
                textBox_ciphertext.Text = vgnr.encrypt(textBox_plaintText.Text.ToString(), textBox_key_encrypt.Text.ToString());
                textBox_decrypt.Text = "";
                textBox_key_decrypt.Text = "";
                textBox_key_decrypt.BackColor = Color.WhiteSmoke;
            }
        }
        private void btn_tryDecrypt_Click(object sender, EventArgs e)
        {
            if (btn_tryDecrypt.ForeColor != Color.Gray)
                textBox_decrypt.Text = vgnr.decrypt(textBox_ciphertext.Text.ToString(), textBox_key_decrypt.Text.ToString());
            checkAllEnableButtonTogether();
        }
        private void btn_find_key_Click(object sender, EventArgs e)
        {
            if (btn_find_key.ForeColor != Color.Gray) { 
                textBox_key_decrypt.Text = vgnr.getFinalKey(textBox_ciphertext.Text).ToString();
                textBox_decrypt.Text = vgnr.decrypt(textBox_ciphertext.Text, textBox_key_decrypt.Text.ToString());
                checkColorDecryptPanel();
                textBox_key_decrypt.BackColor = Color.Yellow;
            }
        }

        /* Exit from the program */
        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_exit_MouseEnter(object sender, EventArgs e)
        {
            btn_exit.Image = new Bitmap(WindowsFormsApplication1.Properties.Resources.icons8_close_window_red, btn_exit.Image.Size.Width, btn_exit.Image.Size.Height);
        }
        private void btn_exit_MouseLeave(object sender, EventArgs e)
        {
            btn_exit.Image = new Bitmap(WindowsFormsApplication1.Properties.Resources.icons8_multiply_filled, btn_exit.Image.Size.Width, btn_exit.Image.Size.Height);
        }

        /* Clear all text in textboxes */
        private void btn_clear_text_Click(object sender, EventArgs e)
        {
            textBox_ciphertext.Text = "";
            textBox_key_decrypt.Text = "";
            textBox_key_encrypt.Text = "";
            textBox_plaintText.Text = "";
            textBox_decrypt.Text = "";
            textBox_key_decrypt.BackColor = Color.WhiteSmoke;
            checkAllEnableButtonTogether();
        }
        private void btn_clear_text_MouseEnter(object sender, EventArgs e)
        {
            btn_clear_text.Image = new Bitmap(WindowsFormsApplication1.Properties.Resources.icons8_waste_filled, btn_clear_text.Image.Size.Width, btn_clear_text.Image.Size.Height);
        }
        private void btn_clear_text_MouseLeave(object sender, EventArgs e)
        {
            btn_clear_text.Image = new Bitmap(WindowsFormsApplication1.Properties.Resources.icons8_waste, btn_clear_text.Image.Size.Width, btn_clear_text.Image.Size.Height);
        }

        /* Select all text from textbox */
        private void textBox_plaintText_DoubleClick(object sender, EventArgs e)
        {
            textBox_plaintText.SelectAll();
        }
        private void textBox_decrypt_DoubleClick(object sender, EventArgs e)
        {
            textBox_decrypt.SelectAll();
        }
        private void textBox_ciphertext_DoubleClick(object sender, EventArgs e)
        {
            textBox_ciphertext.SelectAll();
        }
        private void textBox_key_decrypt_DoubleClick(object sender, EventArgs e)
        {
            textBox_key_decrypt.SelectAll();
        }
        private void textBox_key_encrypt_DoubleClick(object sender, EventArgs e)
        {
            textBox_key_encrypt.SelectAll();
        }

        /* check if to enable the operation button */
        private bool ColorBtn(ref Bunifu.Framework.UI.BunifuThinButton2 btn, Color c, List<string> chekingNotEmptyText = null)
        {
            bool flag = true;
            if(chekingNotEmptyText != null)
            {
                foreach (string str in chekingNotEmptyText)
                {
                    if (str.Length == 0 || stringContainHebrewLetter(str))
                        flag = false;
                }
            }
            btn.ActiveFillColor = flag ? c : Color.Gray;
            btn.ActiveLineColor = flag ? c : Color.Gray;
            btn.ForeColor       = flag ? c : Color.Gray;
            btn.IdleForecolor   = flag ? c : Color.Gray;
            btn.IdleLineColor   = flag ? c : Color.Gray;
            return flag;
        }
        private void textBox_plaintText_KeyUp(object sender, KeyEventArgs e)
        {
            ColorBtn(ref btn_toEncrypt, Color.Chocolate, new List<string> { textBox_plaintText.Text.ToString(), textBox_key_encrypt.Text.ToString() });
        }
        private void textBox_key_encrypt_KeyUp(object sender, KeyEventArgs e)
        {
            ColorBtn(ref btn_toEncrypt, Color.Chocolate, new List<string> { textBox_plaintText.Text.ToString(), textBox_key_encrypt.Text.ToString() });
        }
        private void textBox_ciphertext_KeyUp(object sender, KeyEventArgs e)
        {
            checkColorDecryptPanel();
        }
        private void textBox_key_decrypt_KeyUp(object sender, KeyEventArgs e)
        {
            checkColorDecryptPanel();
        }

        private void checkColorDecryptPanel()
        {
            ColorBtn(ref btn_tryDecrypt, Color.MediumSeaGreen, new List<string> { textBox_ciphertext.Text.ToString(), textBox_key_decrypt.Text.ToString() });
            ColorBtn(ref btn_find_key, Color.DodgerBlue, new List<string> { textBox_ciphertext.Text.ToString() });

            if (textBox_key_decrypt.TextLength > 0 || stringContainHebrewLetter(textBox_ciphertext.Text.ToString())) ColorBtn(ref btn_find_key, Color.Gray);
            else                                    ColorBtn(ref btn_find_key, Color.DodgerBlue);

            textBox_key_decrypt.BackColor = Color.WhiteSmoke;
        }
        private void checkAllEnableButtonTogether()
        {
            textBox_plaintText_KeyUp(null, null);
            textBox_key_encrypt_KeyUp(null, null);
            textBox_ciphertext_KeyUp(null, null);
            textBox_key_decrypt_KeyUp(null, null);
        }
        private bool stringContainHebrewLetter(string str)
        {
            foreach (Char c in str)
            {
                if (c >= 'א' && c <= 'ת')
                    return true;
            }
            return false;
        }

        /* set the mock data for the cheking assigment*/
        private void btn_set_mock_Click(object sender, EventArgs e)
        {
            getKeyMockFromPlainTextMock();
        }
        
        /* Drag the winForm by mouse*/
        private bool beingDragged = false;
        private Point p_move;
        private void bunifu_lbl_bar_MouseDown(object sender, MouseEventArgs e)
        {
            beingDragged = true;
            p_move.X = e.X;
            p_move.Y = e.Y;
        }
        private void bunifu_lbl_bar_MouseUp(object sender, MouseEventArgs e)
        {
            beingDragged = false;
        }
        private void bunifu_lbl_bar_MouseMove(object sender, MouseEventArgs e)
        {
            if (beingDragged)
            {
                this.Location = new Point(this.Location.X + (e.X - p_move.X) ,  this.Location.Y + (e.Y - p_move.Y));
            }
        }


        public string cipherText_mock =
    "HUGVUKSATTMUNDKUMKVVAYVLPOMCEDTBGKIIEYARTREEDRINKFSMEMQNGFEH" +
    " UVMAMHRUCPVVHBWMOGYZXVJWOMKBMAIELJVRPOMCEDRBWKIUNZEEEFRRPKMA" +
    " ZZYUDZRYRALVRZGNFLEKAKTVGNEJOAWBFLSEEBIAMSCIAKTVGNVRPKMAZHXD" +
    " YXLNFIIIDJSEMPWJOHIIBZMKOMMZNAXVRZHGTWTZNBEGFFGYAHFRKKSFRJRY" +
    " RALZSVRQGVXYIIKZHYIRHYMFMPRTTGCVKLQVMWIEBAARSDRGALFCEVOQXJID" +
    " BZVNGKIRCCWRIHVRTZHLBUKVMWIEPYSLGCXVMZKYONXHIVRKHZJYHVVVABIE" +
    " EFMNINLRWALVMJVEHDZRIIPLBOEUSJYTAAXFBJVEHDJIOHQLUVSBSNYEVLEJ" +
    " EJJFNYVFWNSEKVAWOMXUXSSJTGIAHYIWOMXUXYEIEVRQKHHZAIXZTPHVNRLB" +
    " FALVAIKREZRRMZPRGVVVNVQRELWJHZVRYVVVVZVZHYIRNYXUXZMCKZRFTKYE" +
    " CZVGTPRIUNXYBUKFFZEPAWYIPGIPNYXRIIXUKPPCEYQRYPPCEYQRPPXYFVRG" +
    " TZXZCOIEKVVJNZZRKMICTWISHYIJOOLNMUSNTJWGBSPKHZFRTAMEGJJZROIR" +
    " ROMFMVSURZTRTAMEGOMFLVQVVDWVMVVVNOVRTAMEGZRGKHRTEVXZRJLRMWIE" +
    " WVSISJQREHXVVDWVMVVVNOVRTAMEGZRGKHRTEVXZRJLRMWIEWVSITCMFBZMK" +
    " AIHAHALZNBQBKLTIENIAMSCDYNSHENVVWNXEHUKVRCIFBAEKIIKGALREOGSA" +
    " ZLVJIMWNBKMFRHEQTTXIUGCLHBVWOMKVOLRVSNMVFWPFRZFHMALVFVGGBZMN" +
    " ANRNIWMEGVRQLVKVNOPLRVYTAHIETWTZNBEAWZSWADRGEFCFUXEZXAEGPDRT" +
    " MHTGIIKNMTCTHVQOXYHFOMXUTAMJCVVPXDEJSPVRBOIRRYCBNOIIEDSCXUIU" +
    " WDHRMOIUOJVQTYOEENWGALVVAIHAHALZNBQBKLHVEKMAMVXYEYEEDUIJSKIR" +
    " KPRXLJRTBZXFOYXUXYINOIHRKPRXFZEEBUKUOPFGBUKURZEZBUKURZEZLUSD" +
    " OMXNEZIMEMHNKLHKOYVRTTFVFJVRUBXKHZWVELRTEREFNUFIOFIATUHKHZWG" +
    " BSPEENWTTCIEOOSXXUEEDOLRHUPPWJVQMOIIENTBDLRNANXUXDLZSKIEXKAF" +
    " RYPRGVVVTCMFBDLZSKIEXKEEDVRRVOSDUMQHKLHSAXOGALAFRYPRGVVVMZVR" +
    " EFXYINEAWUSKHDRTFVVVBVGXBUXFTCIPAHQSEMXHKUMEGVPYFFWFUGAVMOME" +
    " MZFHKUMEGNSBGHKRIIMUXHVUAOECIPRXSJQRMOMEGGSHWLVKHVROXMSIENYE" +
    " XSCJADHVLBVVLTXUTAMJSJQRMOMEGVXZRDMEDJAYTAXZCZPRMTIJEZXUXUAY" +
    " AOXUXYIRTDWNGKXYINQLLAIIYZBCEVVVLZXZROIRROFRLAMCLVQBFLRKAIHG" +
    " APWDYNXRKFIOPGSEXAMJTCIJBUHRNYRBMOMEGHSEXVTVNCIEXPJCUIKGALWY" +
    " UOXRKDLVNRMGATEEYVJYBYXRNYJYNAXVRDRGALVVSOICILHRSOEGXSCIAQIA" +
    " HMXYENEVGAPPDVCFHMCFRZRBMALVLZEFMVFVINEAVLQRDZLRGVXRMDRHMLWK" +
    " OKTRWVVJTVCRWOISUOAVMOQZEISSEVVUOMPNWFTVRXLRWHFFVZQLVOEDBZVQ" +
    " HVVGEMGUXKYGOIEONZXFFKEYEHWAUNXNUVZVMTGUTTFVRYSBKWIICCIQTUHJ" +
    " AOEAWUSKHDRTFVVVTCIAMOMJEWSARIMIDWITNPPZNBQLLHHWAIGLBUXFSHMY" +
    " BUKSYOLRZYEMEVRQLAIINYIPHYYDOAXUXJSLNOIATUGVIOABKLXYOPKUMOCT" +
    " RZWGULWYOMRNGKWYAQIAMOSLINEVWHVKSPVRGVGIAQIAZOEJTGCTKPQRNYEA" +
    " VPIETMEIXUARNYIEBUKWRJQGALRZGCXYRZLFRZXRESQVWCEGMOICOMHYRUED" +
    " EDWBGALVNDKUMZTCUOSABHRJHJVRJBSKHOLRKHZVNIIIXYQFRZQHVOMDAMZR" +
    " ESIUTCMFNUKRIIPLYVACTJLRTYHZSXSHKZIJOKPNBUPPTCSHZOMKSVRFPLVC" +
    " IOXYXTIRNDRTEPXKLZVRELZRNXCOHYIWOMARVHREOOLREWEXRZIVGNXYAORB" +
    " EPZZNBLHFHRSEDRTXCIIYZXJTZFCENWRWDMKHNIRBUKSIMHNUVZVHDWPAHQS" +
    " EMHBHYFZRYSEULEJTPTBGALVSXYYIAYIEYFHLAESOQIUBZGYAHFRKKSFRRMG" +
    " AZYTHIEZXHWEEQIEFVVVBPXGALVRVZRFBAXZNBPBGLPPOIXUTATCAXMQUBWK" +
    " SKSXXVRCYOLNMVRVWJVQTZMWHDWFHBPZNOLNMVRVWJVQALHZDJYGIVYINJXU" +
    " BUKWUMXUXYXYEILRNAXVRZHAHAEWEVXUXYXYEILRYSYKTZVRWAMCLDWPTYGV" +
    " LTQBKLXYAIQHMAIIEYSGALVWRDIAWZLRVZJYHDRSEASEXVRKHZQBKYSNHZAV" +
    " ESPVAQIZXHWDYCSCXZLRVZJYHDRSEASEXALVNOLRUPVUSVMQGLZVRHSEXZXRROPRWHXKHZWGBSPEENWOKVOVNWCEXWPPSJECMSCJPJORGKSLBOPRLZWRIYMJ" +
    " AHXZTPXGXYWZSDXFHUPPSOSPDHRUSOSEXJELGCXSKVQJOHIHGOEGPTQNLAII" +
    " WCSZNUQVRXMSNSHZSVWGXYJFLGSJXKJRSOEAWMSCLJARWMEJTZVGBSPYINWB" +
    " GNWFNZFHKKIEBJVRMPPCTCIQBYKVSJJUBZLFPZXUTAQVLVRPAVPPBPVQXUFF" +
    " RZSSGLZVRIIIXYQFRZFHMALVRVZRGZXZLGFRZBMCIIKNESQPFVRPRPRKONQV" +
    " EPRXSOVNBNLKIRLRXSIUAXYFAPSEEYWRTAMEFMSAMVJSIMHNGKFLSOEAWKSF" +
    " ROLRGBTFNOLROLPMEOWVGRMEGDFRMVSBMTWREMXFLDRXBUKWAIGLNUXFFVRP" +
    " RALZNFMAZDLRTOLVLVQZNJYFUPVUOACBKLAYAOXUBZKIIHYAZHMELTKUTZXC" +
    " YBEHGAEEDJQVGVYJBDVQHMCFRZQRTUXZNXVBTRMEGIIIXYQFRZXUNZMJAOIA" +
    " ZHKVDDRTNLWJIIKONARFSTPYTIPVESTEXZWZNBXBMOIWORPJAVWVFDIERLCV" +
    " SISJUBVEEYMAMVQPBJWBFZGFRZXUBZEEDHSEXPWRTYMIBUMEGRMGATCYEVHN" +
    " MLEJEMIPEPRZNBSAMOITUNLVHUWMEGZRMSMEIIKGAHXKHZPNFWPZGCXTEVEK" +
    " EYSRKIYKWCSFXCICVZXIBVPVTGMABUKNIOLGALPRMKPVZOXXLJEGBUKFEMWU" +
    " XZLRLGTEXZWRHIIIXYQFRZXUXUQVTCSHZOXKHZEVKNVVWYIALLVGEMJHFLHW" +
    " RJQNGBRJEZRPXUWVRNAHGNFPSZVNIOMDWCSFXMSFTAEYEZXZNFPRWVRKHZXH" +
    " YAIUFGSBKDVVTXLVVYMVDOLLZVHYAOLYXUXKHZIORALVSZEAZLPJHZLNMOWV" +
    " NOXUXLVVSKMGXYIJPDXRTUHEEKIAMOIWRJQGAFQVMJVVXZSWLZRBKLULAAJB" +
    " JBEWFOLVLRMEDIICXUXYEVRQYVVXEOXUBZPFSOPRGVVVQPSGAALVRVZRGUIM" +
    " EMQBKLTIOKLRMZEZDDXUBUKFFZZVEWVFPCIGLAMCLDJOBYHFRYIIBSAYEOLR" +
    " KAIDPOIELLRKOMAUXALVROIZILWKTJWFXKXYEZLRKLEJHJVRWLWFLVXRRLXR" +
    " LGYAWHYETZHBGALZSYIFXYXCAIHRGJLRNOIQHUXYINLBFLFPHJVEHYLRUIXR" +
    " WAICLHIGKBPPIDQCEVVVINXUXYIZSOLRKLFRLHMAZPPVAYXRESQVTZPYFLMZ" +
    " MKPBKLULOOLGALVRVZRAXCIIMJVRIYSGHZXFTPHZTCMAZVJVVDPCKVTYEOWG" +
    " BSPZFWMEWVVUEQMYUFXYAOLRTCIETCEGULRUSVFBOLYJBTXUTAKFDRIOHALR" +
    " DJVRMLPCTCMFLVYCWDXULVVIORPNWLRZFRMGAPRKHZHVLAEETVMQXURZTNLN" +
    " ESGCANTNLHMETZHZTPHVNRLBFALVAIKREZRRMZPRGVVVCGEFIHVRRZEAWYEU" +
    " IVRGFHMUEIAUHTXYEVRTXSWEAHIYXUSIELYBMOXYEMEIXURVVZVZHYISEOLN" +
    " MDSIDJYELPKEOATNKAMEGWMEWVVWIZRQBZLIIZORWBTJTVVGBUKXEOXUXLFR" +
    " CFMAMVXYEOIZILWKAIHGALRZGCXFISYKOIMNGZLFRZPRTCIEOWPNVRTCUHIN" +
    " LHXFKZRBYALRTGMRMOCJOPPUTALJPJORGSIRVZQLEVRVLDRRLZYEBMSXXUUL" +
    " IOXUXIYJTVFBOLQPDJSEMHOVTCCOXHOWRJQBNAQPHZEEMHRUTVORMOCWOMQS" +
    " KVQFFAQLWVSIQPSGAALVRVZRGUIMEMQBKLEEDOLRKHZVNIIIXYJCIOXVGNWK" +
    " IGPVLZMKTDRTLAMCLDWFBAXZNBSAMOIGAGPVWIYJTJJCTSPRSEYFMHFFVZQL" +
    " VOEDBZVQHVVRNYLVLLCVSCEIXHPCTCIFXLQZNBSSTKIDOIWGAHXZSYVRTTME" +
    " GVRQMOICAHTYBNLKOZVUBTWKRZEZBUKKHMSJLALVSCEQHDSETCISEVSIAIHZ" +
    " RZSLLAVBFVYKTCEGLOEUORXUTAPZENJYHHXZNBSAMOIWLJSELOECLWIYBMXV DIIIXYQFRZ";

    }
}
