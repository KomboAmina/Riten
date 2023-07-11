using Riten021.Classes;
namespace Riten021
{
    partial class RitenWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RitenWindow));
            this.TabRiten = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnSimpleGenerate = new System.Windows.Forms.Button();
            this.txtSimpleTime = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSimpleRate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSimplePrincipal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblSimpleTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSimpleInterest = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnCompoundGenerate = new System.Windows.Forms.Button();
            this.cmbFrequency = new System.Windows.Forms.ComboBox();
            this.txtCompoundTime = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCompoundRate = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCompoundDeposit = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCompoundInitial = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblCompoundTotal = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblCompoundInterest = new System.Windows.Forms.Label();
            this.lblSimpleFull = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblCompoundFull = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TabRiten.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabRiten
            // 
            resources.ApplyResources(this.TabRiten, "TabRiten");
            this.TabRiten.Controls.Add(this.tabPage1);
            this.TabRiten.Controls.Add(this.tabPage2);
            this.TabRiten.Name = "TabRiten";
            this.TabRiten.SelectedIndex = 0;
            this.TabRiten.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.tabPage1.Controls.Add(this.btnSimpleGenerate);
            this.tabPage1.Controls.Add(this.txtSimpleTime);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtSimpleRate);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtSimplePrincipal);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            // 
            // btnSimpleGenerate
            // 
            this.btnSimpleGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(22)))), ((int)(((byte)(20)))));
            resources.ApplyResources(this.btnSimpleGenerate, "btnSimpleGenerate");
            this.btnSimpleGenerate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(230)))), ((int)(((byte)(226)))));
            this.btnSimpleGenerate.Name = "btnSimpleGenerate";
            this.btnSimpleGenerate.UseVisualStyleBackColor = false;
            this.btnSimpleGenerate.Click += new System.EventHandler(this.btnSimpleGenerate_Click);
            // 
            // txtSimpleTime
            // 
            resources.ApplyResources(this.txtSimpleTime, "txtSimpleTime");
            this.txtSimpleTime.Name = "txtSimpleTime";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // txtSimpleRate
            // 
            resources.ApplyResources(this.txtSimpleRate, "txtSimpleRate");
            this.txtSimpleRate.Name = "txtSimpleRate";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // txtSimplePrincipal
            // 
            resources.ApplyResources(this.txtSimplePrincipal, "txtSimplePrincipal");
            this.txtSimplePrincipal.Name = "txtSimplePrincipal";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(230)))), ((int)(((byte)(226)))));
            this.panel2.Controls.Add(this.lblSimpleFull);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.lblSimpleTotal);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblSimpleInterest);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // lblSimpleTotal
            // 
            resources.ApplyResources(this.lblSimpleTotal, "lblSimpleTotal");
            this.lblSimpleTotal.Name = "lblSimpleTotal";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // lblSimpleInterest
            // 
            resources.ApplyResources(this.lblSimpleInterest, "lblSimpleInterest");
            this.lblSimpleInterest.Name = "lblSimpleInterest";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(230)))), ((int)(((byte)(226)))));
            this.panel1.Controls.Add(this.label1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnCompoundGenerate);
            this.tabPage2.Controls.Add(this.cmbFrequency);
            this.tabPage2.Controls.Add(this.txtCompoundTime);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.txtCompoundRate);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.txtCompoundDeposit);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.txtCompoundInitial);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.panel4);
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnCompoundGenerate
            // 
            this.btnCompoundGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(22)))), ((int)(((byte)(20)))));
            resources.ApplyResources(this.btnCompoundGenerate, "btnCompoundGenerate");
            this.btnCompoundGenerate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(230)))), ((int)(((byte)(226)))));
            this.btnCompoundGenerate.Name = "btnCompoundGenerate";
            this.btnCompoundGenerate.UseVisualStyleBackColor = false;
            this.btnCompoundGenerate.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbFrequency
            // 
            this.cmbFrequency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cmbFrequency, "cmbFrequency");
            this.cmbFrequency.FormattingEnabled = true;
            this.cmbFrequency.Items.AddRange(new object[] {
            resources.GetString("cmbFrequency.Items"),
            resources.GetString("cmbFrequency.Items1"),
            resources.GetString("cmbFrequency.Items2"),
            resources.GetString("cmbFrequency.Items3"),
            resources.GetString("cmbFrequency.Items4"),
            resources.GetString("cmbFrequency.Items5"),
            resources.GetString("cmbFrequency.Items6"),
            resources.GetString("cmbFrequency.Items7"),
            resources.GetString("cmbFrequency.Items8"),
            resources.GetString("cmbFrequency.Items9")});
            this.cmbFrequency.Name = "cmbFrequency";
            // 
            // txtCompoundTime
            // 
            resources.ApplyResources(this.txtCompoundTime, "txtCompoundTime");
            this.txtCompoundTime.Name = "txtCompoundTime";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // txtCompoundRate
            // 
            resources.ApplyResources(this.txtCompoundRate, "txtCompoundRate");
            this.txtCompoundRate.Name = "txtCompoundRate";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // txtCompoundDeposit
            // 
            resources.ApplyResources(this.txtCompoundDeposit, "txtCompoundDeposit");
            this.txtCompoundDeposit.Name = "txtCompoundDeposit";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // txtCompoundInitial
            // 
            resources.ApplyResources(this.txtCompoundInitial, "txtCompoundInitial");
            this.txtCompoundInitial.Name = "txtCompoundInitial";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(230)))), ((int)(((byte)(226)))));
            this.panel3.Controls.Add(this.label7);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(230)))), ((int)(((byte)(226)))));
            this.panel4.Controls.Add(this.lblCompoundFull);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.lblCompoundTotal);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.lblCompoundInterest);
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // lblCompoundTotal
            // 
            resources.ApplyResources(this.lblCompoundTotal, "lblCompoundTotal");
            this.lblCompoundTotal.Name = "lblCompoundTotal";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // lblCompoundInterest
            // 
            resources.ApplyResources(this.lblCompoundInterest, "lblCompoundInterest");
            this.lblCompoundInterest.Name = "lblCompoundInterest";
            // 
            // lblSimpleFull
            // 
            resources.ApplyResources(this.lblSimpleFull, "lblSimpleFull");
            this.lblSimpleFull.Name = "lblSimpleFull";
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            // 
            // lblCompoundFull
            // 
            resources.ApplyResources(this.lblCompoundFull, "lblCompoundFull");
            this.lblCompoundFull.Name = "lblCompoundFull";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // RitenWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(247)))), ((int)(((byte)(239)))));
            this.Controls.Add(this.TabRiten);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(22)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RitenWindow";
            this.TabRiten.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.TabControl TabRiten;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblSimpleInterest;
        private System.Windows.Forms.TextBox txtSimplePrincipal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSimpleGenerate;
        private System.Windows.Forms.TextBox txtSimpleTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSimpleRate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSimpleTotal;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblCompoundTotal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblCompoundInterest;
        private System.Windows.Forms.TextBox txtCompoundInitial;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCompoundDeposit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCompoundRate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCompoundTime;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbFrequency;
        private System.Windows.Forms.Button btnCompoundGenerate;
        private System.Windows.Forms.Label lblSimpleFull;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblCompoundFull;
        private System.Windows.Forms.Label label11;
    }
}

