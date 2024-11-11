namespace OrderInsertion
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
            btnAgregar = new Button();
            btnOrdenar = new Button();
            listViewCambios = new ListBox();
            txtNumero = new TextBox();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(133, 272);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Add";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnOrdenar
            // 
            btnOrdenar.Location = new Point(244, 272);
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(75, 23);
            btnOrdenar.TabIndex = 1;
            btnOrdenar.Text = "Sorting";
            btnOrdenar.UseVisualStyleBackColor = true;
            btnOrdenar.Click += btnOrdenar_Click;
            // 
            // listViewCambios
            // 
            listViewCambios.FormattingEnabled = true;
            listViewCambios.ItemHeight = 15;
            listViewCambios.Location = new Point(259, 77);
            listViewCambios.Name = "listViewCambios";
            listViewCambios.Size = new Size(329, 169);
            listViewCambios.TabIndex = 2;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(121, 77);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNumero);
            Controls.Add(listViewCambios);
            Controls.Add(btnOrdenar);
            Controls.Add(btnAgregar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private Button btnOrdenar;
        private ListBox listViewCambios;
        private TextBox txtNumero;
    }
}
