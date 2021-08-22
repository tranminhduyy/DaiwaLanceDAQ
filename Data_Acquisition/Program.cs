using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using System.IO;
using System.Drawing;
using System.Data.Sql;
using System.Data.SqlClient;


namespace Data_Acquisition1
{
    public class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        //
       
        [STAThread]
        static void Main()
        {
            
            System.Timers.Timer MainTimer = null;
            MainTimer = new System.Timers.Timer(10000);
            MainTimer.AutoReset = true;
            //MainTimer.Elapsed += new System.Timers.ElapsedEventHandler(DailyExcel);
            MainTimer.Start();
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);

            System.Windows.Forms.Application.Run(new Form1());
        }
        
        static System.DateTime TimeStamp;
        static int Day_Prev = -1;
        //static int dd = 0;
        static SqlConnection cnn = new SqlConnection(@"Data Source=TTBTECH;Initial Catalog=DAQ;Integrated Security=True");
        private static void DailyExcel(object sender, System.Timers.ElapsedEventArgs e)
        {
            
            TimeStamp = DateTime.Now;
            //string s = (TimeStamp.Minute - Day_Prev).ToString();
            //String s = TimeStamp.Minute.ToString();
            //MessageBox.Show(s);
           

            if ((TimeStamp.Day - Day_Prev) != 0)
            {
                
                Form2 f = new Form2();
                f.Show();
                EXPORT_EXCEL_day();
                f.Close();               
            }
            
        }

    

    static string curfile = "";
        static string path = "";
        static void EXPORT_EXCEL_day()
        {
            Day_Prev = TimeStamp.Day;
            try
            {


                DateTime TimeStamp = DateTime.Now;

                Excel.Application xlApp = new Excel.Application();

                string appPath = System.IO.Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath);
                path = appPath;
                Directory.CreateDirectory(path);
                curfile = path + "\\Data\\" + (TimeStamp.Year.ToString() + "_" + TimeStamp.Month.ToString() + "_" + TimeStamp.Day.ToString()
                                                + "_" + TimeStamp.Hour.ToString() + "_" + TimeStamp.Minute.ToString() + "_" + TimeStamp.Second) + ".xlsx";

                if (xlApp == null)
                {
                    MessageBox.Show("Lỗi không thể sử dụng được thư viện EXCEL");
                    return;
                }
                xlApp.Visible = false;

                object misValue = System.Reflection.Missing.Value;

                Workbook wb = xlApp.Workbooks.Add(misValue);

                Worksheet ws = (Worksheet)wb.Worksheets[1];

                if (ws == null)
                {
                    MessageBox.Show("Không thể tạo được WorkSheet");
                    return;
                }
                int row;
                string fontName = "Times New Roman";
                int fontSizeTieuDe = 18;
                int fontSizeTenTruong = 14;
                int fontSizeNoiDung = 12;

                Range CONGTY = ws.get_Range("A1", "AB1");
                CONGTY.Merge();
                CONGTY.Font.Size = fontSizeTieuDe;
                CONGTY.Font.Name = fontName;
                CONGTY.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                CONGTY.Value2 = "CÔNG TY TNHH QUỐC TẾ DAIWA LANCE";

                Range row2_DIACHI = ws.get_Range("A2", "AB2");
                row2_DIACHI.Merge();
                row2_DIACHI.Font.Size = fontSizeTieuDe;
                row2_DIACHI.Font.Name = fontName;
                row2_DIACHI.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                row2_DIACHI.Value2 = "Đường số 20, Khu chế xuất Tân Thuận, Phường Tân Thuận Đông, quận 7 TP.Hồ Chí Minh";

                Range row3_Tieude_daq = ws.get_Range("A3", "AB3");
                row3_Tieude_daq.Merge();
                row3_Tieude_daq.Font.Size = fontSizeTieuDe;
                row3_Tieude_daq.Font.Name = fontName;
                row3_Tieude_daq.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                row3_Tieude_daq.Value2 = "SUPERVISION AND DATA ACQUISITION";

                Range row23_CotTieuDe = ws.get_Range("A1", "AB2");
                //nền vàng
                row23_CotTieuDe.Interior.Color = ColorTranslator.ToOle(System.Drawing.Color.GreenYellow);
                //in đậm
                row23_CotTieuDe.Font.Bold = true;
                //chữ đen
                row23_CotTieuDe.Font.Color = ColorTranslator.ToOle(System.Drawing.Color.Black);

                Range row23_ten = ws.get_Range("A3", "AB3");
                //nền vàng
                row23_ten.Interior.Color = ColorTranslator.ToOle(System.Drawing.Color.Yellow);
                //in đậm
                row23_ten.Font.Bold = true;
                //chữ đen
                row23_ten.Font.Color = ColorTranslator.ToOle(System.Drawing.Color.Black);

                Range row2_ID = ws.get_Range("A4");//Cột A dòng 2 
                //row2_ID.Merge();
                row2_ID.Font.Size = fontSizeTenTruong;
                row2_ID.Font.Name = fontName;
                row2_ID.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row2_ID.Value2 = "ID";


                Range row2_DATETIME = ws.get_Range("B4");//Cột A dòng 2 
                //row2_ID.Merge();
                row2_DATETIME.Font.Size = fontSizeTenTruong;
                row2_DATETIME.Font.Name = fontName;
                row2_DATETIME.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row2_DATETIME.Value2 = "DATE_TIME";
                row2_DATETIME.ColumnWidth = 25;

                Range row2_fre_rich = ws.get_Range("C4");//Cột A dòng 2 
                //row2_ID.Merge();
                row2_fre_rich.Font.Size = fontSizeTenTruong;
                row2_fre_rich.Font.Name = fontName;
                row2_fre_rich.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row2_fre_rich.Value2 = "FREQUENCY_RICH";
                row2_fre_rich.ColumnWidth = 25;

                Range row2_CURRICH = ws.get_Range("D4");//Cột A dòng 2 
                //row2_ID.Merge();
                row2_CURRICH.Font.Size = fontSizeTenTruong;
                row2_CURRICH.Font.Name = fontName;
                row2_CURRICH.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row2_CURRICH.Value2 = "CURRENT_RICH";
                row2_CURRICH.ColumnWidth = 25;

                Range row2_FREDEL = ws.get_Range("E4");//Cột A dòng 2 
                //row2_ID.Merge();
                row2_FREDEL.Font.Size = fontSizeTenTruong;
                row2_FREDEL.Font.Name = fontName;
                row2_FREDEL.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row2_FREDEL.Value2 = "FREQUENCY_DELTA";
                row2_FREDEL.ColumnWidth = 25;

                Range row2_CURDEL = ws.get_Range("F4");//Cột A dòng 2 
                //row2_ID.Merge();
                row2_CURDEL.Font.Size = fontSizeTenTruong;
                row2_CURDEL.Font.Name = fontName;
                row2_CURDEL.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row2_CURDEL.Value2 = "CURRENT_DELTA";
                row2_CURDEL.ColumnWidth = 25;

                Range row2_TYPE = ws.get_Range("G4");//Cột A dòng 2 
                //row2_ID.Merge();
                row2_TYPE.Font.Size = fontSizeTenTruong;
                row2_TYPE.Font.Name = fontName;
                row2_TYPE.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row2_TYPE.Value2 = "TYPE_OF_PRODUCT";
                row2_TYPE.ColumnWidth = 25;

                Range row2_QUAPRO = ws.get_Range("H4");//Cột A dòng 2 
                //row2_ID.Merge();
                row2_QUAPRO.Font.Size = fontSizeTenTruong;
                row2_QUAPRO.Font.Name = fontName;
                row2_QUAPRO.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row2_QUAPRO.Value2 = "QUALITY_PRODUCT";
                row2_QUAPRO.ColumnWidth = 25;

                Range row2_ERRPRO = ws.get_Range("I4");//Cột A dòng 2 
                //row2_ID.Merge();
                row2_ERRPRO.Font.Size = fontSizeTenTruong;
                row2_ERRPRO.Font.Name = fontName;
                row2_ERRPRO.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row2_ERRPRO.Value2 = "ERROR_PRODUCT";
                row2_ERRPRO.ColumnWidth = 25;

                Range row2_CHIEUDAILOI = ws.get_Range("J4");//Cột A dòng 2 
                //row2_ID.Merge();
                row2_CHIEUDAILOI.Font.Size = fontSizeTenTruong;
                row2_CHIEUDAILOI.Font.Name = fontName;
                row2_CHIEUDAILOI.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row2_CHIEUDAILOI.Value2 = "CHIEU_DAI_SPLOI";
                row2_CHIEUDAILOI.ColumnWidth = 25;

                Range row2_duongkinhong = ws.get_Range("K4");//Cột A dòng 2 
                //row2_ID.Merge();
                row2_duongkinhong.Font.Size = fontSizeTenTruong;
                row2_duongkinhong.Font.Name = fontName;
                row2_duongkinhong.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row2_duongkinhong.Value2 = "DUONG_KINH_ONG";
                row2_duongkinhong.ColumnWidth = 25;

                Range row2_BEDAY = ws.get_Range("L4");//Cột A dòng 2 
                //row2_ID.Merge();
                row2_BEDAY.Font.Size = fontSizeTenTruong;
                row2_BEDAY.Font.Name = fontName;
                row2_BEDAY.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row2_BEDAY.Value2 = "BE_DAY";
                row2_BEDAY.ColumnWidth = 25;

                Range row2_CHIEUDAICAT = ws.get_Range("M4");//Cột A dòng 2 
                //row2_ID.Merge();
                row2_CHIEUDAICAT.Font.Size = fontSizeTenTruong;
                row2_CHIEUDAICAT.Font.Name = fontName;
                row2_CHIEUDAICAT.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row2_CHIEUDAICAT.Value2 = "CHIEU_DAI_CAT";
                row2_CHIEUDAICAT.ColumnWidth = 25;

                Range row2_SPEED = ws.get_Range("N4");//Cột A dòng 2 
                //row2_ID.Merge();
                row2_SPEED.Font.Size = fontSizeTenTruong;
                row2_SPEED.Font.Name = fontName;
                row2_SPEED.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row2_SPEED.Value2 = "MOTOR_SPEED";
                row2_SPEED.ColumnWidth = 25;

                Range row2_DCVOLT = ws.get_Range("O4");//Cột A dòng 2 
                //row2_ID.Merge();
                row2_DCVOLT.Font.Size = fontSizeTenTruong;
                row2_DCVOLT.Font.Name = fontName;
                row2_DCVOLT.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row2_DCVOLT.Value2 = "DC_VOLT";
                row2_DCVOLT.ColumnWidth = 25;

                Range row2_DCA = ws.get_Range("P4");//Cột A dòng 2 
                //row2_ID.Merge();
                row2_DCA.Font.Size = fontSizeTenTruong;
                row2_DCA.Font.Name = fontName;
                row2_DCA.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row2_DCA.Value2 = "DC_AMPE";
                row2_DCA.ColumnWidth = 25;

                Range row2_LONUNGCH1 = ws.get_Range("Q4");//Cột A dòng 2 
                //row2_ID.Merge();
                row2_LONUNGCH1.Font.Size = fontSizeTenTruong;
                row2_LONUNGCH1.Font.Name = fontName;
                row2_LONUNGCH1.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row2_LONUNGCH1.Value2 = "HEATER_9";
                row2_LONUNGCH1.ColumnWidth = 25;

                Range row2_LONUNGCH2 = ws.get_Range("R4");//Cột A dòng 2 
                //row2_ID.Merge();
                row2_LONUNGCH2.Font.Size = fontSizeTenTruong;
                row2_LONUNGCH2.Font.Name = fontName;
                row2_LONUNGCH2.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row2_LONUNGCH2.Value2 = "HEATER_1_3";
                row2_LONUNGCH2.ColumnWidth = 25;

                Range row2_LONUNGCH3 = ws.get_Range("S4");//Cột A dòng 2 
                //row2_ID.Merge();
                row2_LONUNGCH3.Font.Size = fontSizeTenTruong;
                row2_LONUNGCH3.Font.Name = fontName;
                row2_LONUNGCH3.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row2_LONUNGCH3.Value2 = "HEATER_2";
                row2_LONUNGCH3.ColumnWidth = 25;

                Range row2_LONUNGCH4 = ws.get_Range("T4");//Cột A dòng 2 
                //row2_ID.Merge();
                row2_LONUNGCH4.Font.Size = fontSizeTenTruong;
                row2_LONUNGCH4.Font.Name = fontName;
                row2_LONUNGCH4.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row2_LONUNGCH4.Value2 = "HEATER_8_10";
                row2_LONUNGCH4.ColumnWidth = 25;

                Range row2_LONUNGCH5 = ws.get_Range("U4");//Cột A dòng 2 
                //row2_ID.Merge();
                row2_LONUNGCH5.Font.Size = fontSizeTenTruong;
                row2_LONUNGCH5.Font.Name = fontName;
                row2_LONUNGCH5.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row2_LONUNGCH5.Value2 = "ZONE_1B_2B";
                row2_LONUNGCH5.ColumnWidth = 25;

                Range row2_LONUNGCH6 = ws.get_Range("V4");//Cột A dòng 2 
                //row2_ID.Merge();
                row2_LONUNGCH6.Font.Size = fontSizeTenTruong;
                row2_LONUNGCH6.Font.Name = fontName;
                row2_LONUNGCH6.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row2_LONUNGCH6.Value2 = "ZONE_3B_4B";
                row2_LONUNGCH6.ColumnWidth = 25;

                Range row2_LONUNGCH7 = ws.get_Range("W4");//Cột A dòng 2 
                //row2_ID.Merge();
                row2_LONUNGCH7.Font.Size = fontSizeTenTruong;
                row2_LONUNGCH7.Font.Name = fontName;
                row2_LONUNGCH7.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row2_LONUNGCH7.Value2 = "ZONE_1A_2A";
                row2_LONUNGCH7.ColumnWidth = 25;

                Range row2_LONUNGCH8 = ws.get_Range("X4");//Cột A dòng 2 
                //row2_ID.Merge();
                row2_LONUNGCH8.Font.Size = fontSizeTenTruong;
                row2_LONUNGCH8.Font.Name = fontName;
                row2_LONUNGCH8.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row2_LONUNGCH8.Value2 = "ZONE_3A_4A";
                row2_LONUNGCH8.ColumnWidth = 25;

                Range row2_LOSAYCH1 = ws.get_Range("Y4");//Cột A dòng 2 
                //row2_ID.Merge();
                row2_LOSAYCH1.Font.Size = fontSizeTenTruong;
                row2_LOSAYCH1.Font.Name = fontName;
                row2_LOSAYCH1.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row2_LOSAYCH1.Value2 = "LOSAY_CAO_TREN";
                row2_LOSAYCH1.ColumnWidth = 25;

                Range row2_LOSAYCH2 = ws.get_Range("Z4");//Cột A dòng 2 
                //row2_ID.Merge();
                row2_LOSAYCH2.Font.Size = fontSizeTenTruong;
                row2_LOSAYCH2.Font.Name = fontName;
                row2_LOSAYCH2.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row2_LOSAYCH2.Value2 = "LOSAY_CAO_DUOI";
                row2_LOSAYCH2.ColumnWidth = 25;

                Range row2_LOSAYCH3 = ws.get_Range("AA4");//Cột A dòng 2 
                //row2_ID.Merge();
                row2_LOSAYCH3.Font.Size = fontSizeTenTruong;
                row2_LOSAYCH3.Font.Name = fontName;
                row2_LOSAYCH3.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row2_LOSAYCH3.Value2 = "LOSAY_THAP_TREN";
                row2_LOSAYCH3.ColumnWidth = 25;

                Range row2_LOSAYCH4 = ws.get_Range("AB4");//Cột A dòng 2 
                //row2_ID.Merge();
                row2_LOSAYCH4.Font.Size = fontSizeTenTruong;
                row2_LOSAYCH4.Font.Name = fontName;
                row2_LOSAYCH4.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row2_LOSAYCH4.Value2 = "LOSAY_THAP_DUOI";
                row2_LOSAYCH4.ColumnWidth = 25;



                int STT = 0;
                row = 4;
                EXPORT_TO_EXCELDataContext context = new EXPORT_TO_EXCELDataContext();
                foreach (DAILY SP in context.DAILies)
                {
                    STT++;
                    row++;
                    dynamic[] arr = { SP.ID, SP.DATE_TIME
                                    , SP.FREQUENCY_RICH, SP.CURRENT_RICH, SP.FREQUENCY_DELTA,SP.CURRENT_DELTA,
                                      SP.TYPE_OF_PRODUCT,SP.QUALITY_PRODUCT, SP.ERROR_PRODUCT ,SP.CHIEU_DAI_SPLOI,
                                        SP.DUONG_KINH_ONG, SP.BE_DAY, SP.CHIEU_DAI_CAT, SP.MOTOR_SPEED,
                                        SP.DC_VOLT, SP.DC_AMPE,
                                    SP.HEATER_9,SP.HEATER_1_3,SP.HEATER_2,SP.HEATER_8_10,
                                    SP.ZONE_1B_2B,SP.ZONE_3B_4B,SP.ZONE_1A_2A,SP.ZONE_3A_4A,
                                    SP.LOSAY_CAO_TREN,SP.LOSAY_CAO_DUOI, SP.LOSAY_THAP_TREN, SP.LOSAY_THAP_DUOI};
                    Range rowData = ws.get_Range("A" + row, "AB" + row);//Lấy dòng thứ row ra để đổ dữ liệu
                    rowData.Font.Size = fontSizeNoiDung;
                    rowData.Font.Name = fontName;
                    rowData.Value2 = arr;
                    rowData.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                }

                BorderAround(ws.get_Range("A4", "AB" + row));
                wb.SaveAs(curfile);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        static void BorderAround(Range range)
        {
            Borders borders = range.Borders;
            borders[XlBordersIndex.xlEdgeLeft].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlEdgeTop].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlEdgeBottom].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlEdgeRight].LineStyle = XlLineStyle.xlContinuous;
            borders.Color = Color.Black;
            borders[XlBordersIndex.xlInsideVertical].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlInsideHorizontal].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlDiagonalUp].LineStyle = XlLineStyle.xlLineStyleNone;
            borders[XlBordersIndex.xlDiagonalDown].LineStyle = XlLineStyle.xlLineStyleNone;
        }
    }
}
