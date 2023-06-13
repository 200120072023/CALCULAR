namespace rEVISÃO
{
    partial class calcular
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
            bt_calcular = new Button();
            tx_valor1 = new TextBox();
            tx_valor2 = new TextBox();
            lb_resultado = new Label();
            SuspendLayout();
            // 
            // bt_calcular
            // 
            bt_calcular.Location = new Point(361, 329);
            bt_calcular.Name = "bt_calcular";
            bt_calcular.Size = new Size(75, 23);
            bt_calcular.TabIndex = 0;
            bt_calcular.Text = "calcular";
            bt_calcular.UseVisualStyleBackColor = true;
            bt_calcular.Click += bt_calcular_Click;
            // 
            // tx_valor1
            // 
            tx_valor1.Location = new Point(315, 109);
            tx_valor1.Name = "tx_valor1";
            tx_valor1.Size = new Size(178, 23);
            tx_valor1.TabIndex = 1;
            // 
            // tx_valor2
            // 
            tx_valor2.Location = new Point(315, 170);
            tx_valor2.Name = "tx_valor2";
            tx_valor2.Size = new Size(178, 23);
            tx_valor2.TabIndex = 2;
            // 
            // lb_resultado
            // 
            lb_resultado.AutoSize = true;
            lb_resultado.Location = new Point(376, 398);
            lb_resultado.Name = "lb_resultado";
            lb_resultado.Size = new Size(56, 15);
            lb_resultado.TabIndex = 3;
            lb_resultado.Text = "resultado";
            // 
            // calcular
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lb_resultado);
            Controls.Add(tx_valor2);
            Controls.Add(tx_valor1);
            Controls.Add(bt_calcular);
            Name = "calcular";
            Text = "calcular";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bt_calcular;
        private TextBox tx_valor1;
        private TextBox tx_valor2;
        private Label lb_resultado;
    }
}