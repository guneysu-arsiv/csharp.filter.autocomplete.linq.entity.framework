using System.ComponentModel;
using System.Windows.Forms;

namespace Quick_Filter_with_Linq
{
    partial class Gui
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.lstProducts = new System.Windows.Forms.ListView();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstProducts
            // 
            this.lstProducts.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lstProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstProducts.Location = new System.Drawing.Point(0, 30);
            this.lstProducts.Margin = new System.Windows.Forms.Padding(30);
            this.lstProducts.Name = "lstProducts";
            this.lstProducts.Size = new System.Drawing.Size(663, 474);
            this.lstProducts.TabIndex = 1;
            this.lstProducts.UseCompatibleStateImageBehavior = false;
            // 
            // txtProductName
            // 
            this.txtProductName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtProductName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtProductName.BackColor = System.Drawing.Color.Khaki;
            this.txtProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductName.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtProductName.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.txtProductName.Location = new System.Drawing.Point(0, 0);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(10);
            this.txtProductName.MinimumSize = new System.Drawing.Size(0, 30);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(663, 30);
            this.txtProductName.TabIndex = 2;
            this.txtProductName.TextChanged += new System.EventHandler(this.txtProductName_TextChanged);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 504);
            this.Controls.Add(this.lstProducts);
            this.Controls.Add(this.txtProductName);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.Name = "Gui";
            this.Text = ":: GUI ::";
            this.Load += new System.EventHandler(this.GUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView lstProducts;
        private TextBox txtProductName;
    }
}

