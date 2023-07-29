namespace Mehrwertsteuerermittlung
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            btn_Create = new Button();
            btn_cancel = new Button();
            label1 = new Label();
            txt_CSVFileName = new TextBox();
            button1 = new Button();
            txt_SavePath = new TextBox();
            SuspendLayout();
            // 
            // btn_Create
            // 
            btn_Create.Location = new Point(22, 90);
            btn_Create.Name = "btn_Create";
            btn_Create.Size = new Size(102, 23);
            btn_Create.TabIndex = 0;
            btn_Create.Text = "Erstellen";
            btn_Create.UseVisualStyleBackColor = true;
            btn_Create.Click += btn_Create_Click;
            // 
            // btn_cancel
            // 
            btn_cancel.Location = new Point(281, 90);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(95, 23);
            btn_cancel.TabIndex = 1;
            btn_cancel.Text = "Abbrechen";
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 24);
            label1.Name = "label1";
            label1.Size = new Size(224, 15);
            label1.TabIndex = 2;
            label1.Text = "Geben sie den Namen der CSV-Datei ein: ";
            // 
            // txt_CSVFileName
            // 
            txt_CSVFileName.Location = new Point(251, 21);
            txt_CSVFileName.Name = "txt_CSVFileName";
            txt_CSVFileName.Size = new Size(125, 23);
            txt_CSVFileName.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(22, 50);
            button1.Name = "button1";
            button1.Size = new Size(124, 23);
            button1.TabIndex = 4;
            button1.Text = "Speichern unter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txt_SavePath
            // 
            txt_SavePath.Location = new Point(152, 51);
            txt_SavePath.Name = "txt_SavePath";
            txt_SavePath.Size = new Size(224, 23);
            txt_SavePath.TabIndex = 5;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(388, 134);
            Controls.Add(txt_SavePath);
            Controls.Add(button1);
            Controls.Add(txt_CSVFileName);
            Controls.Add(label1);
            Controls.Add(btn_cancel);
            Controls.Add(btn_Create);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            Text = "CSV-File erstellen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Create;
        private Button btn_cancel;
        private Label label1;
        private TextBox txt_CSVFileName;
        private Button button1;
        private TextBox txt_SavePath;
    }
}