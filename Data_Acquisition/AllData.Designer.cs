namespace Data_Acquisition1
{
    partial class AllData
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bT_EXPORT_EXCEL = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE_TIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FREQUENCY_RICH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CURRENT_RICH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FREQUENCY_DELTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CURRENT_DELTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TYPE_OF_PRODUCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUALITY_PRODUCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ERROR_PRODUCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHIEU_DAI_SPLOI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DUONG_KINH_ONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BE_DAY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHIEU_DAI_CAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MOTOR_SPEED = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DC_VOLT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DC_AMPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HEATER_9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HEATER_1_3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HEATER_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HEATER_8_10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZONE_1B_2B = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZONE_3B_4B = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZONE_1A_2A = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZONE_3A_4A = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LOSAY_CAO_TREN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LOSAY_CAO_DUOI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LOSAY_THAP_TREN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LOSAY_THAP_DUOI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bT_EXPORT_EXCEL
            // 
            this.bT_EXPORT_EXCEL.Location = new System.Drawing.Point(12, 12);
            this.bT_EXPORT_EXCEL.Name = "bT_EXPORT_EXCEL";
            this.bT_EXPORT_EXCEL.Size = new System.Drawing.Size(166, 53);
            this.bT_EXPORT_EXCEL.TabIndex = 2;
            this.bT_EXPORT_EXCEL.Text = "EXPORT TO EXCEL";
            this.bT_EXPORT_EXCEL.UseVisualStyleBackColor = true;
            this.bT_EXPORT_EXCEL.Click += new System.EventHandler(this.bT_EXPORT_EXCEL_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.DATE_TIME,
            this.FREQUENCY_RICH,
            this.CURRENT_RICH,
            this.FREQUENCY_DELTA,
            this.CURRENT_DELTA,
            this.TYPE_OF_PRODUCT,
            this.QUALITY_PRODUCT,
            this.ERROR_PRODUCT,
            this.CHIEU_DAI_SPLOI,
            this.DUONG_KINH_ONG,
            this.BE_DAY,
            this.CHIEU_DAI_CAT,
            this.MOTOR_SPEED,
            this.DC_VOLT,
            this.DC_AMPE,
            this.HEATER_9,
            this.HEATER_1_3,
            this.HEATER_2,
            this.HEATER_8_10,
            this.ZONE_1B_2B,
            this.ZONE_3B_4B,
            this.ZONE_1A_2A,
            this.ZONE_3A_4A,
            this.LOSAY_CAO_TREN,
            this.LOSAY_CAO_DUOI,
            this.LOSAY_THAP_TREN,
            this.LOSAY_THAP_DUOI});
            this.dataGridView1.Location = new System.Drawing.Point(0, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1366, 672);
            this.dataGridView1.TabIndex = 3;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // DATE_TIME
            // 
            this.DATE_TIME.DataPropertyName = "DATE_TIME";
            this.DATE_TIME.HeaderText = "DATE TIME";
            this.DATE_TIME.Name = "DATE_TIME";
            // 
            // FREQUENCY_RICH
            // 
            this.FREQUENCY_RICH.DataPropertyName = "FREQUENCY_RICH";
            this.FREQUENCY_RICH.HeaderText = "FREQUENCY RICH";
            this.FREQUENCY_RICH.Name = "FREQUENCY_RICH";
            // 
            // CURRENT_RICH
            // 
            this.CURRENT_RICH.DataPropertyName = "CURRENT_RICH";
            this.CURRENT_RICH.HeaderText = "CURRENT RICH";
            this.CURRENT_RICH.Name = "CURRENT_RICH";
            // 
            // FREQUENCY_DELTA
            // 
            this.FREQUENCY_DELTA.DataPropertyName = "FREQUENCY_DELTA";
            this.FREQUENCY_DELTA.HeaderText = "FREQUENCY DELTA";
            this.FREQUENCY_DELTA.Name = "FREQUENCY_DELTA";
            // 
            // CURRENT_DELTA
            // 
            this.CURRENT_DELTA.DataPropertyName = "CURRENT_DELTA";
            this.CURRENT_DELTA.HeaderText = "CURRENT DELTA";
            this.CURRENT_DELTA.Name = "CURRENT_DELTA";
            // 
            // TYPE_OF_PRODUCT
            // 
            this.TYPE_OF_PRODUCT.DataPropertyName = "TYPE_OF_PRODUCT";
            this.TYPE_OF_PRODUCT.HeaderText = "TYPE OF PRODUCT";
            this.TYPE_OF_PRODUCT.Name = "TYPE_OF_PRODUCT";
            // 
            // QUALITY_PRODUCT
            // 
            this.QUALITY_PRODUCT.DataPropertyName = "QUALITY_PRODUCT";
            this.QUALITY_PRODUCT.HeaderText = "QUALITY PRODUCT";
            this.QUALITY_PRODUCT.Name = "QUALITY_PRODUCT";
            // 
            // ERROR_PRODUCT
            // 
            this.ERROR_PRODUCT.DataPropertyName = "ERROR_PRODUCT";
            this.ERROR_PRODUCT.HeaderText = "ERROR PRODUCT";
            this.ERROR_PRODUCT.Name = "ERROR_PRODUCT";
            // 
            // CHIEU_DAI_SPLOI
            // 
            this.CHIEU_DAI_SPLOI.DataPropertyName = "CHIEU_DAI_SPLOI";
            this.CHIEU_DAI_SPLOI.HeaderText = "CHIEU DAI SP LOI";
            this.CHIEU_DAI_SPLOI.Name = "CHIEU_DAI_SPLOI";
            // 
            // DUONG_KINH_ONG
            // 
            this.DUONG_KINH_ONG.DataPropertyName = "DUONG_KINH_ONG";
            this.DUONG_KINH_ONG.HeaderText = "DUONG KINH ONG";
            this.DUONG_KINH_ONG.Name = "DUONG_KINH_ONG";
            // 
            // BE_DAY
            // 
            this.BE_DAY.DataPropertyName = "BE_DAY";
            this.BE_DAY.HeaderText = "BE DAY";
            this.BE_DAY.Name = "BE_DAY";
            // 
            // CHIEU_DAI_CAT
            // 
            this.CHIEU_DAI_CAT.DataPropertyName = "CHIEU_DAI_CAT";
            this.CHIEU_DAI_CAT.HeaderText = "CHIEU DAI CAT";
            this.CHIEU_DAI_CAT.Name = "CHIEU_DAI_CAT";
            // 
            // MOTOR_SPEED
            // 
            this.MOTOR_SPEED.DataPropertyName = "MOTOR_SPEED";
            this.MOTOR_SPEED.HeaderText = "MOTOR SPEED";
            this.MOTOR_SPEED.Name = "MOTOR_SPEED";
            // 
            // DC_VOLT
            // 
            this.DC_VOLT.DataPropertyName = "DC_VOLT";
            this.DC_VOLT.HeaderText = "DC VOLT";
            this.DC_VOLT.Name = "DC_VOLT";
            // 
            // DC_AMPE
            // 
            this.DC_AMPE.DataPropertyName = "DC_AMPE";
            this.DC_AMPE.HeaderText = "DCAMPE";
            this.DC_AMPE.Name = "DC_AMPE";
            // 
            // HEATER_9
            // 
            this.HEATER_9.DataPropertyName = "HEATER_9";
            this.HEATER_9.HeaderText = "HEATER_9";
            this.HEATER_9.Name = "HEATER_9";
            // 
            // HEATER_1_3
            // 
            this.HEATER_1_3.DataPropertyName = "HEATER_1_3";
            this.HEATER_1_3.HeaderText = "HEATER_1_3";
            this.HEATER_1_3.Name = "HEATER_1_3";
            // 
            // HEATER_2
            // 
            this.HEATER_2.DataPropertyName = "HEATER_2";
            this.HEATER_2.HeaderText = "HEATER_2";
            this.HEATER_2.Name = "HEATER_2";
            // 
            // HEATER_8_10
            // 
            this.HEATER_8_10.DataPropertyName = "HEATER_8_10";
            this.HEATER_8_10.HeaderText = "HEATER_8_10";
            this.HEATER_8_10.Name = "HEATER_8_10";
            // 
            // ZONE_1B_2B
            // 
            this.ZONE_1B_2B.DataPropertyName = "ZONE_1B_2B";
            this.ZONE_1B_2B.HeaderText = "ZONE_1B_2B";
            this.ZONE_1B_2B.Name = "ZONE_1B_2B";
            // 
            // ZONE_3B_4B
            // 
            this.ZONE_3B_4B.DataPropertyName = "ZONE_3B_4B";
            this.ZONE_3B_4B.HeaderText = "ZONE_3B_4B";
            this.ZONE_3B_4B.Name = "ZONE_3B_4B";
            // 
            // ZONE_1A_2A
            // 
            this.ZONE_1A_2A.DataPropertyName = "ZONE_1A_2A";
            this.ZONE_1A_2A.HeaderText = "ZONE_1A_2A";
            this.ZONE_1A_2A.Name = "ZONE_1A_2A";
            // 
            // ZONE_3A_4A
            // 
            this.ZONE_3A_4A.DataPropertyName = "ZONE_3A_4A";
            this.ZONE_3A_4A.HeaderText = "ZONE_3A_4A";
            this.ZONE_3A_4A.Name = "ZONE_3A_4A";
            // 
            // LOSAY_CAO_TREN
            // 
            this.LOSAY_CAO_TREN.DataPropertyName = "LOSAY_CAO_TREN";
            this.LOSAY_CAO_TREN.HeaderText = "LOSAY_CAO_TREN";
            this.LOSAY_CAO_TREN.Name = "LOSAY_CAO_TREN";
            // 
            // LOSAY_CAO_DUOI
            // 
            this.LOSAY_CAO_DUOI.DataPropertyName = "LOSAY_CAO_DUOI";
            this.LOSAY_CAO_DUOI.HeaderText = "LOSAY_CAO_DUOI";
            this.LOSAY_CAO_DUOI.Name = "LOSAY_CAO_DUOI";
            // 
            // LOSAY_THAP_TREN
            // 
            this.LOSAY_THAP_TREN.DataPropertyName = "LOSAY_THAP_TREN";
            this.LOSAY_THAP_TREN.HeaderText = "LOSAY_THAP_TREN";
            this.LOSAY_THAP_TREN.Name = "LOSAY_THAP_TREN";
            // 
            // LOSAY_THAP_DUOI
            // 
            this.LOSAY_THAP_DUOI.DataPropertyName = "LOSAY_THAP_DUOI";
            this.LOSAY_THAP_DUOI.HeaderText = "LOSAY_THAP_DUOI";
            this.LOSAY_THAP_DUOI.Name = "LOSAY_THAP_DUOI";
            // 
            // AllData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 750);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bT_EXPORT_EXCEL);
            this.Name = "AllData";
            this.Text = "AllData";
            this.Load += new System.EventHandler(this.AllData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bT_EXPORT_EXCEL;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE_TIME;
        private System.Windows.Forms.DataGridViewTextBoxColumn FREQUENCY_RICH;
        private System.Windows.Forms.DataGridViewTextBoxColumn CURRENT_RICH;
        private System.Windows.Forms.DataGridViewTextBoxColumn FREQUENCY_DELTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CURRENT_DELTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TYPE_OF_PRODUCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUALITY_PRODUCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ERROR_PRODUCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHIEU_DAI_SPLOI;
        private System.Windows.Forms.DataGridViewTextBoxColumn DUONG_KINH_ONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn BE_DAY;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHIEU_DAI_CAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MOTOR_SPEED;
        private System.Windows.Forms.DataGridViewTextBoxColumn DC_VOLT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DC_AMPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn HEATER_9;
        private System.Windows.Forms.DataGridViewTextBoxColumn HEATER_1_3;
        private System.Windows.Forms.DataGridViewTextBoxColumn HEATER_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn HEATER_8_10;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZONE_1B_2B;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZONE_3B_4B;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZONE_1A_2A;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZONE_3A_4A;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOSAY_CAO_TREN;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOSAY_CAO_DUOI;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOSAY_THAP_TREN;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOSAY_THAP_DUOI;
    }
}