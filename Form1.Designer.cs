namespace tarea_U5
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
            txtbuscar = new TextBox();
            btnbuscar = new Button();
            listarchivos = new ListView();
            richtxtcontenido = new ListView();
            SuspendLayout();
            // 
            // txtbuscar
            // 
            txtbuscar.Location = new Point(57, 28);
            txtbuscar.Name = "txtbuscar";
            txtbuscar.Size = new Size(131, 27);
            txtbuscar.TabIndex = 0;
            // 
            // btnbuscar
            // 
            btnbuscar.Location = new Point(194, 26);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(69, 31);
            btnbuscar.TabIndex = 1;
            btnbuscar.Text = "Buscar";
            btnbuscar.UseVisualStyleBackColor = true;
            btnbuscar.Click += btnbuscar_Click;
            // 
            // listarchivos
            // 
            listarchivos.Location = new Point(40, 89);
            listarchivos.Name = "listarchivos";
            listarchivos.Size = new Size(294, 329);
            listarchivos.TabIndex = 2;
            listarchivos.UseCompatibleStateImageBehavior = false;
            listarchivos.SelectedIndexChanged += listarchivos_SelectedIndexChanged;
            // 
            // richtxtcontenido
            // 
            richtxtcontenido.Location = new Point(450, 89);
            richtxtcontenido.Name = "richtxtcontenido";
            richtxtcontenido.Size = new Size(294, 329);
            richtxtcontenido.TabIndex = 3;
            richtxtcontenido.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richtxtcontenido);
            Controls.Add(listarchivos);
            Controls.Add(btnbuscar);
            Controls.Add(txtbuscar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtbuscar;
        private Button btnbuscar;
        private ListView listarchivos;
        private ListView richtxtcontenido;
    }
}
