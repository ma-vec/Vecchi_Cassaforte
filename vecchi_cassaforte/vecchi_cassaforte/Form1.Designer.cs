namespace vecchi_cassaforte
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
            textBoxCodUtente = new TextBox();
            buttonApri = new Button();
            buttonChiudi = new Button();
            textBoxCodSblocco = new TextBox();
            buttonSblocca = new Button();
            labelStato = new Label();
            labelTentativiFissa = new Label();
            labelTentativi = new Label();
            labelImpostaFissa = new Label();
            textBoxImpostaCod = new TextBox();
            buttonImposta = new Button();
            dateTimePickerProg = new DateTimePicker();
            buttonImpostaData = new Button();
            dateTimePickerOggi = new DateTimePicker();
            label1 = new Label();
            buttonApriProg = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // textBoxCodUtente
            // 
            textBoxCodUtente.Location = new Point(37, 34);
            textBoxCodUtente.Name = "textBoxCodUtente";
            textBoxCodUtente.Size = new Size(100, 23);
            textBoxCodUtente.TabIndex = 0;
            // 
            // buttonApri
            // 
            buttonApri.Location = new Point(173, 34);
            buttonApri.Name = "buttonApri";
            buttonApri.Size = new Size(75, 23);
            buttonApri.TabIndex = 1;
            buttonApri.Text = "Apri";
            buttonApri.UseVisualStyleBackColor = true;
            buttonApri.Click += buttonApri_Click;
            // 
            // buttonChiudi
            // 
            buttonChiudi.Location = new Point(37, 94);
            buttonChiudi.Name = "buttonChiudi";
            buttonChiudi.Size = new Size(211, 23);
            buttonChiudi.TabIndex = 2;
            buttonChiudi.Text = "Chiudi";
            buttonChiudi.UseVisualStyleBackColor = true;
            buttonChiudi.Click += buttonChiudi_Click;
            // 
            // textBoxCodSblocco
            // 
            textBoxCodSblocco.Location = new Point(37, 151);
            textBoxCodSblocco.Name = "textBoxCodSblocco";
            textBoxCodSblocco.Size = new Size(100, 23);
            textBoxCodSblocco.TabIndex = 3;
            // 
            // buttonSblocca
            // 
            buttonSblocca.Location = new Point(173, 151);
            buttonSblocca.Name = "buttonSblocca";
            buttonSblocca.Size = new Size(75, 23);
            buttonSblocca.TabIndex = 4;
            buttonSblocca.Text = "Sblocca";
            buttonSblocca.UseVisualStyleBackColor = true;
            buttonSblocca.Click += buttonSblocca_Click;
            // 
            // labelStato
            // 
            labelStato.AutoSize = true;
            labelStato.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            labelStato.Location = new Point(492, 58);
            labelStato.Name = "labelStato";
            labelStato.Size = new Size(0, 65);
            labelStato.TabIndex = 5;
            // 
            // labelTentativiFissa
            // 
            labelTentativiFissa.AutoSize = true;
            labelTentativiFissa.Location = new Point(45, 205);
            labelTentativiFissa.Name = "labelTentativiFissa";
            labelTentativiFissa.Size = new Size(106, 15);
            labelTentativiFissa.TabIndex = 6;
            labelTentativiFissa.Text = "Tentativi Apertura: ";
            // 
            // labelTentativi
            // 
            labelTentativi.AutoSize = true;
            labelTentativi.Location = new Point(173, 205);
            labelTentativi.Name = "labelTentativi";
            labelTentativi.Size = new Size(0, 15);
            labelTentativi.TabIndex = 7;
            // 
            // labelImpostaFissa
            // 
            labelImpostaFissa.AutoSize = true;
            labelImpostaFissa.Location = new Point(45, 342);
            labelImpostaFissa.Name = "labelImpostaFissa";
            labelImpostaFissa.Size = new Size(93, 15);
            labelImpostaFissa.TabIndex = 8;
            labelImpostaFissa.Text = "Imposta Codice:";
            // 
            // textBoxImpostaCod
            // 
            textBoxImpostaCod.Location = new Point(173, 334);
            textBoxImpostaCod.MaxLength = 5;
            textBoxImpostaCod.Name = "textBoxImpostaCod";
            textBoxImpostaCod.PasswordChar = '*';
            textBoxImpostaCod.Size = new Size(100, 23);
            textBoxImpostaCod.TabIndex = 9;
            // 
            // buttonImposta
            // 
            buttonImposta.Location = new Point(301, 334);
            buttonImposta.Name = "buttonImposta";
            buttonImposta.Size = new Size(75, 23);
            buttonImposta.TabIndex = 10;
            buttonImposta.Text = "Imposta";
            buttonImposta.UseVisualStyleBackColor = true;
            buttonImposta.Click += buttonImposta_Click;
            // 
            // dateTimePickerProg
            // 
            dateTimePickerProg.Location = new Point(45, 394);
            dateTimePickerProg.Name = "dateTimePickerProg";
            dateTimePickerProg.Size = new Size(228, 23);
            dateTimePickerProg.TabIndex = 11;
            // 
            // buttonImpostaData
            // 
            buttonImpostaData.Location = new Point(527, 392);
            buttonImpostaData.Name = "buttonImpostaData";
            buttonImpostaData.Size = new Size(75, 23);
            buttonImpostaData.TabIndex = 12;
            buttonImpostaData.Text = "Imposta";
            buttonImpostaData.UseVisualStyleBackColor = true;
            buttonImpostaData.Click += buttonImpostaData_Click;
            // 
            // dateTimePickerOggi
            // 
            dateTimePickerOggi.Location = new Point(301, 394);
            dateTimePickerOggi.Name = "dateTimePickerOggi";
            dateTimePickerOggi.Size = new Size(211, 23);
            dateTimePickerOggi.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 420);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 14;
            label1.Text = "Data Programmata";
            // 
            // buttonApriProg
            // 
            buttonApriProg.Location = new Point(664, 392);
            buttonApriProg.Name = "buttonApriProg";
            buttonApriProg.Size = new Size(75, 23);
            buttonApriProg.TabIndex = 15;
            buttonApriProg.Text = "Apri";
            buttonApriProg.UseVisualStyleBackColor = true;
            buttonApriProg.Click += buttonApriProg_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(301, 426);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 16;
            label2.Text = "Data Oggi";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(buttonApriProg);
            Controls.Add(label1);
            Controls.Add(dateTimePickerOggi);
            Controls.Add(buttonImpostaData);
            Controls.Add(dateTimePickerProg);
            Controls.Add(buttonImposta);
            Controls.Add(textBoxImpostaCod);
            Controls.Add(labelImpostaFissa);
            Controls.Add(labelTentativi);
            Controls.Add(labelTentativiFissa);
            Controls.Add(labelStato);
            Controls.Add(buttonSblocca);
            Controls.Add(textBoxCodSblocco);
            Controls.Add(buttonChiudi);
            Controls.Add(buttonApri);
            Controls.Add(textBoxCodUtente);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxCodUtente;
        private Button buttonApri;
        private Button buttonChiudi;
        private TextBox textBoxCodSblocco;
        private Button buttonSblocca;
        private Label labelStato;
        private Label labelTentativiFissa;
        private Label labelTentativi;
        private Label labelImpostaFissa;
        private TextBox textBoxImpostaCod;
        private Button buttonImposta;
        private DateTimePicker dateTimePickerProg;
        private Button buttonImpostaData;
        private DateTimePicker dateTimePickerOggi;
        private Label label1;
        private Button buttonApriProg;
        private Label label2;
    }
}
