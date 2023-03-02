
namespace GestionAbsences
{
    partial class Absence
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
            this.button_enregistrer = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.text_total_absences = new System.Windows.Forms.TextBox();
            this.text_id = new System.Windows.Forms.TextBox();
            this.text_nbAbsences = new System.Windows.Forms.TextBox();
            this.comboBox_semaine = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button_enregistrer
            // 
            this.button_enregistrer.Location = new System.Drawing.Point(382, 75);
            this.button_enregistrer.Name = "button_enregistrer";
            this.button_enregistrer.Size = new System.Drawing.Size(140, 35);
            this.button_enregistrer.TabIndex = 17;
            this.button_enregistrer.Text = "Enregistrer";
            this.button_enregistrer.UseVisualStyleBackColor = true;
            this.button_enregistrer.Click += new System.EventHandler(this.button_enregistrer_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(569, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Total Absences";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Semaine";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nbr Absences";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID";
            // 
            // text_total_absences
            // 
            this.text_total_absences.Location = new System.Drawing.Point(573, 84);
            this.text_total_absences.Name = "text_total_absences";
            this.text_total_absences.Size = new System.Drawing.Size(180, 26);
            this.text_total_absences.TabIndex = 15;
            // 
            // text_id
            // 
            this.text_id.Location = new System.Drawing.Point(161, 33);
            this.text_id.Name = "text_id";
            this.text_id.Size = new System.Drawing.Size(155, 26);
            this.text_id.TabIndex = 13;
            // 
            // text_nbAbsences
            // 
            this.text_nbAbsences.Location = new System.Drawing.Point(161, 84);
            this.text_nbAbsences.Name = "text_nbAbsences";
            this.text_nbAbsences.Size = new System.Drawing.Size(155, 26);
            this.text_nbAbsences.TabIndex = 14;
            // 
            // comboBox_semaine
            // 
            this.comboBox_semaine.FormattingEnabled = true;
            this.comboBox_semaine.Location = new System.Drawing.Point(161, 130);
            this.comboBox_semaine.Name = "comboBox_semaine";
            this.comboBox_semaine.Size = new System.Drawing.Size(155, 28);
            this.comboBox_semaine.TabIndex = 18;
            // 
            // Absence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(800, 187);
            this.Controls.Add(this.comboBox_semaine);
            this.Controls.Add(this.button_enregistrer);
            this.Controls.Add(this.text_total_absences);
            this.Controls.Add(this.text_nbAbsences);
            this.Controls.Add(this.text_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Absence";
            this.Text = "Absence";
            this.Load += new System.EventHandler(this.Absence_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_enregistrer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_total_absences;
        private System.Windows.Forms.TextBox text_id;
        private System.Windows.Forms.TextBox text_nbAbsences;
        private System.Windows.Forms.ComboBox comboBox_semaine;
    }
}