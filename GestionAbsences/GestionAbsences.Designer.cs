
namespace GestionAbsences
{
    partial class GestionAbsences
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.text_id = new System.Windows.Forms.TextBox();
            this.text_nom = new System.Windows.Forms.TextBox();
            this.text_prenom = new System.Windows.Forms.TextBox();
            this.text_groupe = new System.Windows.Forms.TextBox();
            this.button_ajouter = new System.Windows.Forms.Button();
            this.button_modifier = new System.Windows.Forms.Button();
            this.button_supprimer = new System.Windows.Forms.Button();
            this.button_rechercher = new System.Windows.Forms.Button();
            this.button_gestion_absences = new System.Windows.Forms.Button();
            this.dataEleve = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Groupe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataEleve)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prenom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Groupe";
            // 
            // text_id
            // 
            this.text_id.Location = new System.Drawing.Point(231, 51);
            this.text_id.Name = "text_id";
            this.text_id.Size = new System.Drawing.Size(355, 26);
            this.text_id.TabIndex = 4;
            // 
            // text_nom
            // 
            this.text_nom.Location = new System.Drawing.Point(231, 102);
            this.text_nom.Name = "text_nom";
            this.text_nom.Size = new System.Drawing.Size(355, 26);
            this.text_nom.TabIndex = 5;
            // 
            // text_prenom
            // 
            this.text_prenom.Location = new System.Drawing.Point(231, 150);
            this.text_prenom.Name = "text_prenom";
            this.text_prenom.Size = new System.Drawing.Size(355, 26);
            this.text_prenom.TabIndex = 6;
            // 
            // text_groupe
            // 
            this.text_groupe.Location = new System.Drawing.Point(231, 203);
            this.text_groupe.Name = "text_groupe";
            this.text_groupe.Size = new System.Drawing.Size(355, 26);
            this.text_groupe.TabIndex = 7;
            // 
            // button_ajouter
            // 
            this.button_ajouter.Location = new System.Drawing.Point(722, 42);
            this.button_ajouter.Name = "button_ajouter";
            this.button_ajouter.Size = new System.Drawing.Size(200, 35);
            this.button_ajouter.TabIndex = 8;
            this.button_ajouter.Text = "Ajouter";
            this.button_ajouter.UseVisualStyleBackColor = true;
            this.button_ajouter.Click += new System.EventHandler(this.button_ajouter_Click);
            // 
            // button_modifier
            // 
            this.button_modifier.Location = new System.Drawing.Point(722, 83);
            this.button_modifier.Name = "button_modifier";
            this.button_modifier.Size = new System.Drawing.Size(200, 35);
            this.button_modifier.TabIndex = 9;
            this.button_modifier.Text = "Modifier";
            this.button_modifier.UseVisualStyleBackColor = true;
            this.button_modifier.Click += new System.EventHandler(this.button_modifier_Click);
            // 
            // button_supprimer
            // 
            this.button_supprimer.Location = new System.Drawing.Point(722, 124);
            this.button_supprimer.Name = "button_supprimer";
            this.button_supprimer.Size = new System.Drawing.Size(200, 35);
            this.button_supprimer.TabIndex = 10;
            this.button_supprimer.Text = "Supprimer";
            this.button_supprimer.UseVisualStyleBackColor = true;
            this.button_supprimer.Click += new System.EventHandler(this.button_supprimer_Click);
            // 
            // button_rechercher
            // 
            this.button_rechercher.Location = new System.Drawing.Point(722, 165);
            this.button_rechercher.Name = "button_rechercher";
            this.button_rechercher.Size = new System.Drawing.Size(200, 35);
            this.button_rechercher.TabIndex = 11;
            this.button_rechercher.Text = "Rechercher";
            this.button_rechercher.UseVisualStyleBackColor = true;
            this.button_rechercher.Click += new System.EventHandler(this.button_rechercher_Click);
            // 
            // button_gestion_absences
            // 
            this.button_gestion_absences.Location = new System.Drawing.Point(722, 206);
            this.button_gestion_absences.Name = "button_gestion_absences";
            this.button_gestion_absences.Size = new System.Drawing.Size(200, 35);
            this.button_gestion_absences.TabIndex = 12;
            this.button_gestion_absences.Text = "Gestion d\'absences";
            this.button_gestion_absences.UseVisualStyleBackColor = true;
            this.button_gestion_absences.Click += new System.EventHandler(this.button_gestion_absences_Click);
            // 
            // dataEleve
            // 
            this.dataEleve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataEleve.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nom,
            this.Prenom,
            this.Groupe});
            this.dataEleve.Location = new System.Drawing.Point(27, 342);
            this.dataEleve.Name = "dataEleve";
            this.dataEleve.RowHeadersWidth = 62;
            this.dataEleve.RowTemplate.Height = 28;
            this.dataEleve.Size = new System.Drawing.Size(999, 172);
            this.dataEleve.TabIndex = 13;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.Width = 150;
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.MinimumWidth = 8;
            this.Nom.Name = "Nom";
            this.Nom.Width = 150;
            // 
            // Prenom
            // 
            this.Prenom.HeaderText = "Prenom";
            this.Prenom.MinimumWidth = 8;
            this.Prenom.Name = "Prenom";
            this.Prenom.Width = 150;
            // 
            // Groupe
            // 
            this.Groupe.HeaderText = "Groupe";
            this.Groupe.MinimumWidth = 8;
            this.Groupe.Name = "Groupe";
            this.Groupe.Width = 150;
            // 
            // GestionAbsences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1085, 668);
            this.Controls.Add(this.dataEleve);
            this.Controls.Add(this.button_gestion_absences);
            this.Controls.Add(this.button_rechercher);
            this.Controls.Add(this.button_supprimer);
            this.Controls.Add(this.button_modifier);
            this.Controls.Add(this.button_ajouter);
            this.Controls.Add(this.text_groupe);
            this.Controls.Add(this.text_prenom);
            this.Controls.Add(this.text_nom);
            this.Controls.Add(this.text_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GestionAbsences";
            this.Text = "Gestion des absences";
            this.Load += new System.EventHandler(this.GestionAbsences_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataEleve)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.TextBox text_groupe;
        private System.Windows.Forms.TextBox text_prenom;
        private System.Windows.Forms.TextBox text_nom;
        private System.Windows.Forms.TextBox text_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_gestion_absences;
        private System.Windows.Forms.Button button_rechercher;
        private System.Windows.Forms.Button button_supprimer;
        private System.Windows.Forms.Button button_modifier;
        private System.Windows.Forms.Button button_ajouter;
        private System.Windows.Forms.DataGridView dataEleve;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Groupe;
    }
}

