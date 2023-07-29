namespace Mehrwertsteuerermittlung
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_BetragInput = new TextBox();
            txt_BetragOutput = new TextBox();
            btn_berechnen = new Button();
            btn_SelectAndSaveInCSV = new Button();
            rBtn_Seven = new RadioButton();
            rBtn_Nineteen = new RadioButton();
            btn_CreateCSVFile = new Button();
            btn_Close = new Button();
            txt_dateiName = new TextBox();
            btn_Save = new Button();
            label4 = new Label();
            label5 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // txt_BetragInput
            // 
            resources.ApplyResources(txt_BetragInput, "txt_BetragInput");
            txt_BetragInput.Name = "txt_BetragInput";
            // 
            // txt_BetragOutput
            // 
            resources.ApplyResources(txt_BetragOutput, "txt_BetragOutput");
            txt_BetragOutput.Name = "txt_BetragOutput";
            // 
            // btn_berechnen
            // 
            resources.ApplyResources(btn_berechnen, "btn_berechnen");
            btn_berechnen.Name = "btn_berechnen";
            btn_berechnen.UseVisualStyleBackColor = true;
            btn_berechnen.Click += btn_berechnen_Click;
            // 
            // btn_SelectAndSaveInCSV
            // 
            resources.ApplyResources(btn_SelectAndSaveInCSV, "btn_SelectAndSaveInCSV");
            btn_SelectAndSaveInCSV.Name = "btn_SelectAndSaveInCSV";
            btn_SelectAndSaveInCSV.UseVisualStyleBackColor = true;
            btn_SelectAndSaveInCSV.Click += btn_SelectAndSaveInCSV_Click;
            // 
            // rBtn_Seven
            // 
            resources.ApplyResources(rBtn_Seven, "rBtn_Seven");
            rBtn_Seven.Name = "rBtn_Seven";
            rBtn_Seven.TabStop = true;
            rBtn_Seven.UseVisualStyleBackColor = true;
            // 
            // rBtn_Nineteen
            // 
            resources.ApplyResources(rBtn_Nineteen, "rBtn_Nineteen");
            rBtn_Nineteen.Name = "rBtn_Nineteen";
            rBtn_Nineteen.TabStop = true;
            rBtn_Nineteen.UseVisualStyleBackColor = true;
            // 
            // btn_CreateCSVFile
            // 
            resources.ApplyResources(btn_CreateCSVFile, "btn_CreateCSVFile");
            btn_CreateCSVFile.Name = "btn_CreateCSVFile";
            btn_CreateCSVFile.UseVisualStyleBackColor = true;
            btn_CreateCSVFile.Click += btn_CreateCSVFile_Click;
            // 
            // btn_Close
            // 
            resources.ApplyResources(btn_Close, "btn_Close");
            btn_Close.Name = "btn_Close";
            btn_Close.UseVisualStyleBackColor = true;
            btn_Close.Click += btn_Close_Click;
            // 
            // txt_dateiName
            // 
            resources.ApplyResources(txt_dateiName, "txt_dateiName");
            txt_dateiName.Name = "txt_dateiName";
            // 
            // btn_Save
            // 
            resources.ApplyResources(btn_Save, "btn_Save");
            btn_Save.Name = "btn_Save";
            btn_Save.UseVisualStyleBackColor = true;
            btn_Save.Click += btn_Save_Click;
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.Name = "label5";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txt_BetragInput);
            groupBox1.Controls.Add(rBtn_Nineteen);
            groupBox1.Controls.Add(btn_Save);
            groupBox1.Controls.Add(rBtn_Seven);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btn_berechnen);
            groupBox1.Controls.Add(txt_BetragOutput);
            groupBox1.Controls.Add(label3);
            resources.ApplyResources(groupBox1, "groupBox1");
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(btn_CreateCSVFile);
            resources.ApplyResources(groupBox2, "groupBox2");
            groupBox2.Name = "groupBox2";
            groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(btn_SelectAndSaveInCSV);
            groupBox3.Controls.Add(txt_dateiName);
            resources.ApplyResources(groupBox3, "groupBox3");
            groupBox3.Name = "groupBox3";
            groupBox3.TabStop = false;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btn_Close);
            Name = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_BetragInput;
        private TextBox txt_BetragOutput;
        private Button btn_berechnen;
        private Button btn_SelectAndSaveInCSV;
        private RadioButton rBtn_Seven;
        private RadioButton rBtn_Nineteen;
        private Button btn_CreateCSVFile;
        private Button btn_Close;
        private TextBox txt_dateiName;
        private Button btn_Save;
        private Label label4;
        private Label label5;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
    }
}