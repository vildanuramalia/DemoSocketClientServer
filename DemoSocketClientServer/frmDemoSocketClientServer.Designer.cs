
namespace DemoSocketClientServer
{
    partial class frmDemoSocketClientServer
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtTerimaData = new System.Windows.Forms.TextBox();
            this.btnListen = new System.Windows.Forms.Button();
            this.txtIPServer = new System.Windows.Forms.TextBox();
            this.txtPortServer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtKirimData = new System.Windows.Forms.TextBox();
            this.btnKirimDataKeServer = new System.Windows.Forms.Button();
            this.txtIPTujuan = new System.Windows.Forms.TextBox();
            this.txtPortClient = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(710, 396);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtTerimaData);
            this.tabPage1.Controls.Add(this.btnListen);
            this.tabPage1.Controls.Add(this.txtIPServer);
            this.tabPage1.Controls.Add(this.txtPortServer);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(702, 367);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Server";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtTerimaData
            // 
            this.txtTerimaData.Location = new System.Drawing.Point(20, 57);
            this.txtTerimaData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTerimaData.Multiline = true;
            this.txtTerimaData.Name = "txtTerimaData";
            this.txtTerimaData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTerimaData.Size = new System.Drawing.Size(660, 256);
            this.txtTerimaData.TabIndex = 5;
            // 
            // btnListen
            // 
            this.btnListen.Location = new System.Drawing.Point(534, 12);
            this.btnListen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnListen.Name = "btnListen";
            this.btnListen.Size = new System.Drawing.Size(84, 35);
            this.btnListen.TabIndex = 4;
            this.btnListen.Text = "Listen";
            this.btnListen.UseVisualStyleBackColor = true;
            this.btnListen.Click += new System.EventHandler(this.btnListen_Click);
            // 
            // txtIPServer
            // 
            this.txtIPServer.Location = new System.Drawing.Point(318, 18);
            this.txtIPServer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIPServer.Name = "txtIPServer";
            this.txtIPServer.Size = new System.Drawing.Size(210, 22);
            this.txtIPServer.TabIndex = 3;
            this.txtIPServer.Text = "192.168.43.24";
            // 
            // txtPortServer
            // 
            this.txtPortServer.Location = new System.Drawing.Point(56, 18);
            this.txtPortServer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPortServer.Name = "txtPortServer";
            this.txtPortServer.Size = new System.Drawing.Size(186, 22);
            this.txtPortServer.TabIndex = 2;
            this.txtPortServer.Text = "16375";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "IP Server";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtKirimData);
            this.tabPage2.Controls.Add(this.btnKirimDataKeServer);
            this.tabPage2.Controls.Add(this.txtIPTujuan);
            this.tabPage2.Controls.Add(this.txtPortClient);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(702, 367);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Client";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtKirimData
            // 
            this.txtKirimData.Location = new System.Drawing.Point(20, 56);
            this.txtKirimData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKirimData.Multiline = true;
            this.txtKirimData.Name = "txtKirimData";
            this.txtKirimData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtKirimData.Size = new System.Drawing.Size(660, 256);
            this.txtKirimData.TabIndex = 5;
            // 
            // btnKirimDataKeServer
            // 
            this.btnKirimDataKeServer.Location = new System.Drawing.Point(596, 330);
            this.btnKirimDataKeServer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKirimDataKeServer.Name = "btnKirimDataKeServer";
            this.btnKirimDataKeServer.Size = new System.Drawing.Size(84, 26);
            this.btnKirimDataKeServer.TabIndex = 4;
            this.btnKirimDataKeServer.Text = "Kirim";
            this.btnKirimDataKeServer.UseVisualStyleBackColor = true;
            this.btnKirimDataKeServer.Click += new System.EventHandler(this.btnKirimDataKeServer_Click);
            // 
            // txtIPTujuan
            // 
            this.txtIPTujuan.Location = new System.Drawing.Point(318, 18);
            this.txtIPTujuan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIPTujuan.Name = "txtIPTujuan";
            this.txtIPTujuan.Size = new System.Drawing.Size(210, 22);
            this.txtIPTujuan.TabIndex = 3;
            this.txtIPTujuan.Text = "192.168.43.24";
            // 
            // txtPortClient
            // 
            this.txtPortClient.Location = new System.Drawing.Point(56, 18);
            this.txtPortClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPortClient.Name = "txtPortClient";
            this.txtPortClient.Size = new System.Drawing.Size(186, 22);
            this.txtPortClient.TabIndex = 2;
            this.txtPortClient.Text = "16375";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(247, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "IP Tujuan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Port";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmDemoSocketClientServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 396);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmDemoSocketClientServer";
            this.Text = "Demo Socket Client Server";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtTerimaData;
        private System.Windows.Forms.Button btnListen;
        private System.Windows.Forms.TextBox txtIPServer;
        private System.Windows.Forms.TextBox txtPortServer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKirimDataKeServer;
        private System.Windows.Forms.TextBox txtIPTujuan;
        private System.Windows.Forms.TextBox txtPortClient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKirimData;
        private System.Windows.Forms.Timer timer1;
    }
}
