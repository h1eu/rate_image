namespace FormRateIamge
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
            txt_name = new Label();
            txt_age = new Label();
            txt_gender = new Label();
            txt_can_comfirm = new Label();
            txt_form = new Label();
            tb_name = new TextBox();
            tb_age = new TextBox();
            cb_female = new CheckBox();
            cb_male = new CheckBox();
            cb_yes = new CheckBox();
            cb_no = new CheckBox();
            btn_next = new Button();
            SuspendLayout();
            // 
            // txt_name
            // 
            txt_name.AutoSize = true;
            txt_name.Location = new Point(258, 73);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(25, 15);
            txt_name.TabIndex = 0;
            txt_name.Text = "Tên";
            txt_name.Click += txt_name_Click;
            // 
            // txt_age
            // 
            txt_age.AutoSize = true;
            txt_age.Location = new Point(260, 128);
            txt_age.Name = "txt_age";
            txt_age.Size = new Size(30, 15);
            txt_age.TabIndex = 1;
            txt_age.Text = "Tuổi";
            // 
            // txt_gender
            // 
            txt_gender.AutoSize = true;
            txt_gender.Location = new Point(260, 174);
            txt_gender.Name = "txt_gender";
            txt_gender.Size = new Size(52, 15);
            txt_gender.TabIndex = 2;
            txt_gender.Text = "Giới tính";
            txt_gender.Click += txt_gender_Click;
            // 
            // txt_can_comfirm
            // 
            txt_can_comfirm.AutoSize = true;
            txt_can_comfirm.Location = new Point(260, 219);
            txt_can_comfirm.Name = "txt_can_comfirm";
            txt_can_comfirm.Size = new Size(124, 15);
            txt_can_comfirm.TabIndex = 3;
            txt_can_comfirm.Text = "Có bị cận hay không ?";
            // 
            // txt_form
            // 
            txt_form.AutoSize = true;
            txt_form.Location = new Point(306, 23);
            txt_form.Name = "txt_form";
            txt_form.Size = new Size(141, 15);
            txt_form.TabIndex = 4;
            txt_form.Text = "Thông tin người đánh giá";
            // 
            // tb_name
            // 
            tb_name.Location = new Point(260, 93);
            tb_name.Name = "tb_name";
            tb_name.Size = new Size(257, 23);
            tb_name.TabIndex = 5;
            // 
            // tb_age
            // 
            tb_age.Location = new Point(260, 146);
            tb_age.Name = "tb_age";
            tb_age.Size = new Size(257, 23);
            tb_age.TabIndex = 6;
            // 
            // cb_female
            // 
            cb_female.AutoSize = true;
            cb_female.Location = new Point(260, 197);
            cb_female.Name = "cb_female";
            cb_female.Size = new Size(42, 19);
            cb_female.TabIndex = 7;
            cb_female.Text = "Nữ";
            cb_female.UseVisualStyleBackColor = true;
            cb_female.CheckedChanged += cb_female_CheckedChanged;
            // 
            // cb_male
            // 
            cb_male.AutoSize = true;
            cb_male.Location = new Point(375, 197);
            cb_male.Name = "cb_male";
            cb_male.Size = new Size(52, 19);
            cb_male.TabIndex = 8;
            cb_male.Text = "Nam";
            cb_male.UseVisualStyleBackColor = true;
            cb_male.CheckedChanged += cb_male_CheckedChanged;
            // 
            // cb_yes
            // 
            cb_yes.AutoSize = true;
            cb_yes.Location = new Point(260, 249);
            cb_yes.Name = "cb_yes";
            cb_yes.Size = new Size(41, 19);
            cb_yes.TabIndex = 9;
            cb_yes.Text = "Có";
            cb_yes.UseVisualStyleBackColor = true;
            cb_yes.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // cb_no
            // 
            cb_no.AutoSize = true;
            cb_no.Location = new Point(375, 249);
            cb_no.Name = "cb_no";
            cb_no.Size = new Size(61, 19);
            cb_no.TabIndex = 10;
            cb_no.Text = "Không";
            cb_no.UseVisualStyleBackColor = true;
            cb_no.CheckedChanged += cb_no_CheckedChanged;
            // 
            // btn_next
            // 
            btn_next.Location = new Point(306, 337);
            btn_next.Name = "btn_next";
            btn_next.Size = new Size(141, 30);
            btn_next.TabIndex = 11;
            btn_next.Text = "Tiếp";
            btn_next.UseVisualStyleBackColor = true;
            btn_next.Click += btn_next_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_next);
            Controls.Add(cb_no);
            Controls.Add(cb_yes);
            Controls.Add(cb_male);
            Controls.Add(cb_female);
            Controls.Add(tb_age);
            Controls.Add(tb_name);
            Controls.Add(txt_form);
            Controls.Add(txt_can_comfirm);
            Controls.Add(txt_gender);
            Controls.Add(txt_age);
            Controls.Add(txt_name);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txt_name;
        private Label txt_age;
        private Label txt_gender;
        private Label txt_can_comfirm;
        private Label txt_form;
        private TextBox tb_name;
        private TextBox tb_age;
        private CheckBox cb_female;
        private CheckBox cb_male;
        private CheckBox cb_yes;
        private CheckBox cb_no;
        private Button btn_next;
    }
}