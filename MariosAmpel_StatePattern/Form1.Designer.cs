namespace MariosAmpel_StatePattern
{
    partial class Form1
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
            this.btn_state_change = new System.Windows.Forms.Button();
            this.panel_oben = new System.Windows.Forms.Panel();
            this.panel_mitte = new System.Windows.Forms.Panel();
            this.panel_unten = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btn_state_change
            // 
            this.btn_state_change.Location = new System.Drawing.Point(25, 23);
            this.btn_state_change.Name = "btn_state_change";
            this.btn_state_change.Size = new System.Drawing.Size(75, 43);
            this.btn_state_change.TabIndex = 0;
            this.btn_state_change.Text = "State Change";
            this.btn_state_change.UseVisualStyleBackColor = true;
            this.btn_state_change.Click += new System.EventHandler(this.btn_state_change_Click);
            // 
            // panel_oben
            // 
            this.panel_oben.Location = new System.Drawing.Point(130, 23);
            this.panel_oben.Name = "panel_oben";
            this.panel_oben.Size = new System.Drawing.Size(109, 100);
            this.panel_oben.TabIndex = 2;
            // 
            // panel_mitte
            // 
            this.panel_mitte.Location = new System.Drawing.Point(130, 129);
            this.panel_mitte.Name = "panel_mitte";
            this.panel_mitte.Size = new System.Drawing.Size(109, 100);
            this.panel_mitte.TabIndex = 4;
            // 
            // panel_unten
            // 
            this.panel_unten.Location = new System.Drawing.Point(130, 235);
            this.panel_unten.Name = "panel_unten";
            this.panel_unten.Size = new System.Drawing.Size(109, 100);
            this.panel_unten.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 356);
            this.Controls.Add(this.panel_unten);
            this.Controls.Add(this.panel_mitte);
            this.Controls.Add(this.panel_oben);
            this.Controls.Add(this.btn_state_change);
            this.Name = "Form1";
            this.Text = "Ampel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_state_change;
        private System.Windows.Forms.Panel panel_oben;
        private System.Windows.Forms.Panel panel_mitte;
        private System.Windows.Forms.Panel panel_unten;
    }
}