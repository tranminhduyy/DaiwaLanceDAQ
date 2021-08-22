using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using S7.Net;
using S7.Net.Types;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Data_Acquisition1
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=TTBTECH;Initial Catalog=DAQ;Integrated Security=True;");
        //SqlConnection con = new SqlConnection("Data Source=LAPTOP-KTU4214O;Initial Catalog=DAQ;Integrated Security=True;");
        SqlCommand cmd;
        private Plc plc = null;

        float fre_rich;
        float cur_rich;
        float fre_delta;
        float cur_delta;
        string pro_type;
        int qua_pro;
        int err_pro;
        float chieu_dai_ong_loi;
        float duong_kinh_ong;
        float be_day;
        float chieu_dai_cat;
        float motor_speed;
        float dc_volt;
        float dc_ampe;
        float lonung_ch1;
        float lonung_ch2;
        float lonung_ch3;
        float lonung_ch4;
        float lonung_ch5;
        float lonung_ch6;
        float lonung_ch7;
        float lonung_ch8;
        float losay_ch1;
        float losay_ch2;
        float losay_ch3;
        float losay_ch4;

        string cur_date_time;
       

        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            //plc = new Plc(CpuType.S71200, "192.168.0.2", 0, 1);

            //try
            //{
            //    plc.Open();
            //}
            //catch
            //{
            //    ;
            //}
            
            //if (plc.IsConnected)
            //{
            //    MessageBox.Show("DEVICE CONNECTED");
            //}
            //else
            //{
            //    MessageBox.Show("DEVICE NOT CONNECTED");
            //}

            //con.Open();

            //timer1.Enabled = true;
            //timer2.Enabled = true;
            //string time_update = tb_update.Text;
            //timer2.Interval = Int32.Parse(time_update);
            timer3.Enabled = true;
            
        }

        private void Form1_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            throw new System.NotImplementedException();
            con.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(plc.IsConnected)
            {
                object obj_fre_rich = plc.Read("MD600");
                if (obj_fre_rich != null)
                {
                    fre_rich = ((uint)obj_fre_rich).ConvertToFloat();
                    string s_fre_rich = System.String.Format("{0:0.#}", fre_rich);
                    TB_FREQUENCY_INVERTER.Text = s_fre_rich;
                }

                object obj_cur_rich = plc.Read("MD604");
                if (obj_cur_rich != null)
                {
                    cur_rich = ((uint)obj_cur_rich).ConvertToFloat();
                    string s_cur_rich = System.String.Format("{0:0.#}", cur_rich);
                    TB_CURRENT_RICH.Text = s_cur_rich;
                }

                object obj_fre_delta = plc.Read("MD608");
                if (obj_fre_delta != null)
                {
                    fre_delta = ((uint)obj_fre_delta).ConvertToFloat();
                    string s_fre_delta = System.String.Format("{0:0.#}", fre_delta);
                    tB_FREQUENCY_DELTA.Text = s_fre_delta;
                }

                object obj_cur_delta = plc.Read("MD612");
                if (obj_cur_delta != null)
                {
                    cur_delta = ((uint)obj_cur_delta).ConvertToFloat();
                    string s_cur_delta = System.String.Format("{0:0.#}", cur_delta);
                    TB_CURRENT_DELTA.Text = s_cur_delta;
                }

                object obj_CHAR1 = plc.Read("MB1416");
                object obj_CHAR2 = plc.Read("MB1418");
                if ((obj_CHAR1 != null) && (obj_CHAR2 != null))
                {
                    char s_CHAR1 = Convert.ToChar(obj_CHAR1);
                    char s_CHAR2 = Convert.ToChar(obj_CHAR2);              
                    string s_CHAR = s_CHAR1.ToString() + s_CHAR2.ToString(); ;
                    tb_pro_type.Text = s_CHAR; 
                }

                object obj_pro = plc.Read("MW1400");
                if (obj_pro != null)
                {
                    qua_pro = (ushort)obj_pro;
                    string s_pro = System.String.Format("{0}", qua_pro);
                    TB_PRODUCT_NUMBER.Text = s_pro;
                }

                object obj_err = plc.Read("MW1422");
                if (obj_pro != null)
                {
                    err_pro = (ushort)obj_err;
                    string s_err = System.String.Format("{0}", err_pro);
                    tb_error_product.Text = s_err;
                }

                object obj_chieudaiongloi = plc.Read("MD24");
                if (obj_chieudaiongloi != null)
                {
                    chieu_dai_ong_loi = ((uint)obj_chieudaiongloi).ConvertToFloat();
                    string s_chieudaiongloi = System.String.Format("{0:0.#}", chieu_dai_ong_loi);
                    TB_CHIEUDAILOI.Text = s_chieudaiongloi;
                }

                object obj_duongkinhong = plc.Read("MD680");
                if (obj_duongkinhong != null)
                {
                    duong_kinh_ong = ((uint)obj_duongkinhong).ConvertToFloat();
                    string s_duongkinhong = System.String.Format("{0:0.#}", duong_kinh_ong);
                    TB_DUONGKINHONG.Text = s_duongkinhong;
                }

                object obj_beday = plc.Read("MD684");
                if (obj_beday != null)
                {
                    be_day = ((uint)obj_beday).ConvertToFloat();
                    string s_beday = System.String.Format("{0:0.#}", be_day);
                    TB_BEDAYONG.Text = s_beday;
                }

                object obj_chieudaicat = plc.Read("MD1408");
                if (obj_chieudaicat != null)
                {
                    chieu_dai_cat = ((uint)obj_chieudaicat).ConvertToFloat();
                    string s_chieudaicat = System.String.Format("{0:0.#}", chieu_dai_cat);
                    TB_CHIEUDAICAT.Text = s_chieudaicat;
                }

                object obj_speed = plc.Read("MD620");
                if (obj_speed != null)
                {
                    motor_speed = ((uint)obj_speed).ConvertToFloat();
                    string s_speed = System.String.Format("{0:0.#}", motor_speed);
                    TB_MOTOR_SPEED.Text = s_speed;
                }

                object obj_dc_volt = plc.Read("MD624");
                if (obj_dc_volt != null)
                {
                     dc_volt= ((uint)obj_dc_volt).ConvertToFloat();
                    string s_dc_volt = System.String.Format("{0:0.#}", dc_volt);
                    TB_DCVOLT.Text = s_dc_volt;
                }


             
                object obj_dc_ampe = plc.Read("MD628");
                if (obj_dc_volt != null)
                {
                    dc_ampe = ((uint)obj_dc_ampe).ConvertToFloat();
                    string s_dc_ampe = System.String.Format("{0:0.#}", dc_ampe);
                    TB_DC_AMPE.Text = s_dc_ampe;
                }

                object obj_lonungch1 = plc.Read("MD632");
                if (obj_lonungch1 != null)
                {
                    lonung_ch1 = ((uint)obj_lonungch1).ConvertToFloat();
                    string s_lonungch1 = System.String.Format("{0:0.#}", lonung_ch1);
                    TB_F_C1.Text = s_lonungch1;
                }

                object obj_lonungch2 = plc.Read("MD636");
                if (obj_lonungch2 != null)
                {
                    lonung_ch2 = ((uint)obj_lonungch2).ConvertToFloat();
                    string s_lonungch2 = System.String.Format("{0:0.#}", lonung_ch2);
                    TB_F_C2.Text = s_lonungch2;
                }

                object obj_lonungch3 = plc.Read("MD640");
                if (obj_lonungch3 != null)
                {
                    lonung_ch3 = ((uint)obj_lonungch3).ConvertToFloat();
                    string s_lonungch3 = System.String.Format("{0:0.#}", lonung_ch3);
                    TB_F_C3.Text = s_lonungch3;
                }

                object obj_lonungch4 = plc.Read("MD644");
                if (obj_lonungch4 != null)
                {
                    lonung_ch4 = ((uint)obj_lonungch4).ConvertToFloat();
                    string s_lonungch4 = System.String.Format("{0:0.#}", lonung_ch4);
                    TB_F_C4.Text = s_lonungch4;
                }

                object obj_lonungch5 = plc.Read("MD648");
                if (obj_lonungch5 != null)
                {
                    lonung_ch5 = ((uint)obj_lonungch5).ConvertToFloat();
                    string s_lonungch5 = System.String.Format("{0:0.#}", lonung_ch5);
                    TB_F_C5.Text = s_lonungch5;
                }

                object obj_lonungch6 = plc.Read("MD652");
                if (obj_lonungch6 != null)
                {
                    lonung_ch6 = ((uint)obj_lonungch6).ConvertToFloat();
                    string s_lonungch6 = System.String.Format("{0:0.#}", lonung_ch6);
                    TB_F_C6.Text = s_lonungch6;
                }

                object obj_lonungch7 = plc.Read("MD656");
                if (obj_lonungch7 != null)
                {
                    lonung_ch7 = ((uint)obj_lonungch7).ConvertToFloat();
                    string s_lonungch7 = System.String.Format("{0:0.#}", lonung_ch7);
                    TB_F_C7.Text = s_lonungch7;
                }

                object obj_lonungch8 = plc.Read("MD660");
                if (obj_lonungch8 != null)
                {
                    lonung_ch8 = ((uint)obj_lonungch8).ConvertToFloat();
                    string s_lonungch8 = System.String.Format("{0:0.#}", lonung_ch8);
                    TB_F_C8.Text = s_lonungch8;
                }

                object obj_losaych1 = plc.Read("MD664");
                if (obj_losaych1 != null)
                {
                    losay_ch1 = ((uint)obj_losaych1).ConvertToFloat();
                    string s_losaych1 = System.String.Format("{0:0.#}", losay_ch1);
                    TB_D_C1.Text = s_losaych1;
                }

                object obj_losaych2 = plc.Read("MD668");
                if (obj_losaych2 != null)
                {
                    losay_ch2 = ((uint)obj_losaych2).ConvertToFloat();
                    string s_losaych2 = System.String.Format("{0:0.#}", losay_ch2);
                    TB_D_C2.Text = s_losaych2;
                }

                object obj_losaych3 = plc.Read("MD672");
                if (obj_losaych3 != null)
                {
                    losay_ch3 = ((uint)obj_losaych3).ConvertToFloat();
                    string s_losaych3 = System.String.Format("{0:0.#}", losay_ch3);
                    TB_D_C3.Text = s_losaych3;
                }

                object obj_losaych4 = plc.Read("MD676");
                if (obj_losaych4 != null)
                {
                    losay_ch4 = ((uint)obj_losaych4).ConvertToFloat();
                    string s_losaych4 = System.String.Format("{0:0.#}", losay_ch4);
                    TB_D_C4.Text = s_losaych4;
                }

               

            }


        }
       


        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                string s_fre_rich = System.String.Format("{0:0.#}", fre_rich);
                string s_cur_rich = System.String.Format("{0:0.#}", cur_rich);
                string s_fre_delta = System.String.Format("{0:0.#}", fre_delta);
                string s_cur_delta = System.String.Format("{0:0.#}", cur_delta);
                string s_pro = System.String.Format("{0}", qua_pro);
                string s_err = System.String.Format("{0}", err_pro);
                string s_chieudaiongloi = System.String.Format("{0:0.#}", chieu_dai_ong_loi);
                string s_duongkinhong = System.String.Format("{0:0.#}", duong_kinh_ong);
                string s_beday = System.String.Format("{0:0.#}", be_day);
                string s_chieudaicat = System.String.Format("{0:0.#}", chieu_dai_cat);
                string s_motor_speed = System.String.Format("{0:0.#}", motor_speed);
                string s_dc_volt = System.String.Format("{0:0.#}", dc_volt);
                string s_dc_ampe = System.String.Format("{0:0.#}", dc_ampe);
                string s_lonungch1 = System.String.Format("{0:0.#}", lonung_ch1);
                string s_lonungch2 = System.String.Format("{0:0.#}", lonung_ch2);
                string s_lonungch3 = System.String.Format("{0:0.#}", lonung_ch3);
                string s_lonungch4 = System.String.Format("{0:0.#}", lonung_ch4);
                string s_lonungch5 = System.String.Format("{0:0.#}", lonung_ch5);
                string s_lonungch6 = System.String.Format("{0:0.#}", lonung_ch6);
                string s_lonungch7 = System.String.Format("{0:0.#}", lonung_ch7);
                string s_lonungch8 = System.String.Format("{0:0.#}", lonung_ch8);
                string s_losaych1 = System.String.Format("{0:0.#}", losay_ch1);
                string s_losaych2 = System.String.Format("{0:0.#}", losay_ch2);
                string s_losaych3 = System.String.Format("{0:0.#}", losay_ch3);
                string s_losaych4 = System.String.Format("{0:0.#}", losay_ch4);
                cmd = new SqlCommand("Insert into VARIABLE_DAQ values( '" + cur_date_time + "','" + s_fre_rich + "','" + s_cur_rich + "','" + s_fre_delta + "','" + s_cur_delta +
                    "','" + tb_pro_type.Text + "','" + s_pro + "','" + s_err + "','" + s_chieudaiongloi + "','" + s_duongkinhong +
                    "','" + s_beday + "','" + s_chieudaicat + "','" + s_motor_speed +
                    "','" + s_dc_volt + "','" + s_dc_ampe + "','" +
                    s_lonungch3 + "','" + s_lonungch8 + "','" + s_lonungch1 + "','" + s_lonungch2 + "','" +
                    s_lonungch6 +
                    "','" + s_lonungch4 + "','" + s_lonungch5 + "','" + s_lonungch7 +
                    "','" + s_losaych3 + "','" + s_losaych2 + "','" + s_losaych4 + "','" + s_losaych1 + "')", con);
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }            
        }

        private void bt_viewdataform_Click(object sender, EventArgs e)
        {
            AllData g = new AllData();         
            g.Show();
           
            
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            DateTime cur_time = DateTime.Now;
            //string dt = DateTime.UtcNow.ToString("yyyy-MM--ddTHH:mm:ssZ");
            label_datetime.Text = cur_time.ToString();
            cur_date_time = cur_time.ToString();
          


        }

        private void TB_F_C8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_datetime_Click(object sender, EventArgs e)
        {

        }

        private void TB_F_C7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label41_Click(object sender, EventArgs e)
        {

        }

        private void TB_D_C1_TextChanged(object sender, EventArgs e)
        {

        }

    

        //private void button_TYPE_Click(object sender, EventArgs e)
        //{
        //    if (plc.IsConnected)
        //    {
        //        try
        //        {
        //            int dbnumber = 9;
        //            int start_add = 0;
        //            string input = tb_pro_type.Text;
        //            byte[] dataBytes = S7.Net.Types.String.ToByteArray(input, 2);
        //            List<byte> values = new List<byte>();
        //            byte maxLength = (byte)input.Length;
        //            byte actualLength = (byte)input.Length;
        //            values.Add(maxLength);
        //            values.Add(actualLength);
        //            values.AddRange(dataBytes);
        //            plc.WriteBytes(DataType.DataBlock, dbnumber, start_add, values.ToArray());
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show(this, ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //    }
           
        //}

        private void button_update_Click(object sender, EventArgs e)
        {
            timer2.Interval = Int32.Parse(tb_update.Text);
        }

        private void btConnectPLC_Click(object sender, EventArgs e)
        {
            plc = new Plc(CpuType.S71200, tbIpAddress.Text.ToString(), 0, 1);

            try
            {
                plc.Open();
            }
            catch
            {
                ;
            }

            if (plc.IsConnected)
            {
                MessageBox.Show("DEVICE CONNECTED");
                con.Open();

                btConnectPLC.Text = "Connected";
                btConnectPLC.Enabled = false;

                timer1.Enabled = true;
                timer2.Enabled = true;
            }
            else
            {
                MessageBox.Show("DEVICE NOT CONNECTED");
            }
            
            string time_update = tb_update.Text;
            timer2.Interval = Int32.Parse(time_update);
        }
    }
}
