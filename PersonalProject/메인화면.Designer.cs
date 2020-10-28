namespace PersonalProject
{
    partial class ShipReservation
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.회원전용ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.개인정보수정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.개인정보확인ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.회원탈퇴ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.관리자전용ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.항구등록ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.섬등록ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.배등록ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.운행등록ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.예약승인ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnReserveCheck = new System.Windows.Forms.Button();
            this.btnReserve = new System.Windows.Forms.Button();
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnMemberLogin = new System.Windows.Forms.Button();
            this.btnAdminLogin = new System.Windows.Forms.Button();
            this.btnNewResigister = new System.Windows.Forms.Button();
            this.dgvCheckData = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReserchNumber = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckData)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.회원전용ToolStripMenuItem,
            this.관리자전용ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(723, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 회원전용ToolStripMenuItem
            // 
            this.회원전용ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.개인정보수정ToolStripMenuItem,
            this.개인정보확인ToolStripMenuItem,
            this.회원탈퇴ToolStripMenuItem});
            this.회원전용ToolStripMenuItem.Name = "회원전용ToolStripMenuItem";
            this.회원전용ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.회원전용ToolStripMenuItem.Text = "회원전용";
            // 
            // 개인정보수정ToolStripMenuItem
            // 
            this.개인정보수정ToolStripMenuItem.Name = "개인정보수정ToolStripMenuItem";
            this.개인정보수정ToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.개인정보수정ToolStripMenuItem.Text = "개인정보수정";
            // 
            // 개인정보확인ToolStripMenuItem
            // 
            this.개인정보확인ToolStripMenuItem.Name = "개인정보확인ToolStripMenuItem";
            this.개인정보확인ToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.개인정보확인ToolStripMenuItem.Text = "개인정보확인";
            // 
            // 회원탈퇴ToolStripMenuItem
            // 
            this.회원탈퇴ToolStripMenuItem.Name = "회원탈퇴ToolStripMenuItem";
            this.회원탈퇴ToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.회원탈퇴ToolStripMenuItem.Text = "회원탈퇴";
            this.회원탈퇴ToolStripMenuItem.Click += new System.EventHandler(this.회원탈퇴ToolStripMenuItem_Click);
            // 
            // 관리자전용ToolStripMenuItem
            // 
            this.관리자전용ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.항구등록ToolStripMenuItem,
            this.섬등록ToolStripMenuItem,
            this.배등록ToolStripMenuItem,
            this.운행등록ToolStripMenuItem,
            this.예약승인ToolStripMenuItem});
            this.관리자전용ToolStripMenuItem.Name = "관리자전용ToolStripMenuItem";
            this.관리자전용ToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.관리자전용ToolStripMenuItem.Text = "관리자전용";
            // 
            // 항구등록ToolStripMenuItem
            // 
            this.항구등록ToolStripMenuItem.Name = "항구등록ToolStripMenuItem";
            this.항구등록ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.항구등록ToolStripMenuItem.Text = "항구등록";
            this.항구등록ToolStripMenuItem.Click += new System.EventHandler(this.항구등록ToolStripMenuItem_Click);
            // 
            // 섬등록ToolStripMenuItem
            // 
            this.섬등록ToolStripMenuItem.Name = "섬등록ToolStripMenuItem";
            this.섬등록ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.섬등록ToolStripMenuItem.Text = "섬등록";
            this.섬등록ToolStripMenuItem.Click += new System.EventHandler(this.섬등록ToolStripMenuItem_Click);
            // 
            // 배등록ToolStripMenuItem
            // 
            this.배등록ToolStripMenuItem.Name = "배등록ToolStripMenuItem";
            this.배등록ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.배등록ToolStripMenuItem.Text = "배등록";
            this.배등록ToolStripMenuItem.Click += new System.EventHandler(this.배등록ToolStripMenuItem_Click);
            // 
            // 운행등록ToolStripMenuItem
            // 
            this.운행등록ToolStripMenuItem.Name = "운행등록ToolStripMenuItem";
            this.운행등록ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.운행등록ToolStripMenuItem.Text = "운행등록";
            this.운행등록ToolStripMenuItem.Click += new System.EventHandler(this.운행등록ToolStripMenuItem_Click);
            // 
            // 예약승인ToolStripMenuItem
            // 
            this.예약승인ToolStripMenuItem.Name = "예약승인ToolStripMenuItem";
            this.예약승인ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.예약승인ToolStripMenuItem.Text = "예약승인";
            // 
            // btnReserveCheck
            // 
            this.btnReserveCheck.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnReserveCheck.Location = new System.Drawing.Point(499, 280);
            this.btnReserveCheck.Name = "btnReserveCheck";
            this.btnReserveCheck.Size = new System.Drawing.Size(193, 59);
            this.btnReserveCheck.TabIndex = 2;
            this.btnReserveCheck.Text = "예약확인";
            this.btnReserveCheck.UseVisualStyleBackColor = true;
            this.btnReserveCheck.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnReserve
            // 
            this.btnReserve.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnReserve.Location = new System.Drawing.Point(499, 199);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(193, 59);
            this.btnReserve.TabIndex = 3;
            this.btnReserve.Text = "예약하기";
            this.btnReserve.UseVisualStyleBackColor = true;
            this.btnReserve.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblLogin.Location = new System.Drawing.Point(128, 46);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(256, 27);
            this.lblLogin.TabIndex = 4;
            this.lblLogin.Text = "여객선 예약 시스템";
            // 
            // btnMemberLogin
            // 
            this.btnMemberLogin.Location = new System.Drawing.Point(567, 34);
            this.btnMemberLogin.Name = "btnMemberLogin";
            this.btnMemberLogin.Size = new System.Drawing.Size(116, 26);
            this.btnMemberLogin.TabIndex = 6;
            this.btnMemberLogin.Text = "회원 로그인";
            this.btnMemberLogin.UseVisualStyleBackColor = true;
            // 
            // btnAdminLogin
            // 
            this.btnAdminLogin.Location = new System.Drawing.Point(567, 66);
            this.btnAdminLogin.Name = "btnAdminLogin";
            this.btnAdminLogin.Size = new System.Drawing.Size(116, 26);
            this.btnAdminLogin.TabIndex = 7;
            this.btnAdminLogin.Text = "관리자로그인";
            this.btnAdminLogin.UseVisualStyleBackColor = true;
            // 
            // btnNewResigister
            // 
            this.btnNewResigister.Location = new System.Drawing.Point(567, 100);
            this.btnNewResigister.Name = "btnNewResigister";
            this.btnNewResigister.Size = new System.Drawing.Size(116, 26);
            this.btnNewResigister.TabIndex = 8;
            this.btnNewResigister.Text = "회원가입";
            this.btnNewResigister.UseVisualStyleBackColor = true;
            this.btnNewResigister.Click += new System.EventHandler(this.button6_Click);
            // 
            // dgvCheckData
            // 
            this.dgvCheckData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCheckData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCheckData.Location = new System.Drawing.Point(3, 22);
            this.dgvCheckData.Name = "dgvCheckData";
            this.dgvCheckData.RowTemplate.Height = 23;
            this.dgvCheckData.Size = new System.Drawing.Size(474, 308);
            this.dgvCheckData.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvCheckData);
            this.groupBox1.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(13, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 333);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "등록된운행";
            // 
            // btnReserchNumber
            // 
            this.btnReserchNumber.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnReserchNumber.Location = new System.Drawing.Point(499, 362);
            this.btnReserchNumber.Name = "btnReserchNumber";
            this.btnReserchNumber.Size = new System.Drawing.Size(193, 59);
            this.btnReserchNumber.TabIndex = 11;
            this.btnReserchNumber.Text = "예약번호찾기";
            this.btnReserchNumber.UseVisualStyleBackColor = true;
            // 
            // ShipReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(723, 459);
            this.Controls.Add(this.btnReserchNumber);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnNewResigister);
            this.Controls.Add(this.btnAdminLogin);
            this.Controls.Add(this.btnMemberLogin);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.btnReserve);
            this.Controls.Add(this.btnReserveCheck);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ShipReservation";
            this.Text = "항해예약서비스";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckData)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnReserveCheck;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.ToolStripMenuItem 회원전용ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 개인정보수정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 개인정보확인ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 회원탈퇴ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 관리자전용ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 항구등록ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 섬등록ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 배등록ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 운행등록ToolStripMenuItem;
        private System.Windows.Forms.Button btnMemberLogin;
        private System.Windows.Forms.Button btnAdminLogin;
        private System.Windows.Forms.Button btnNewResigister;
        private System.Windows.Forms.DataGridView dgvCheckData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem 예약승인ToolStripMenuItem;
        private System.Windows.Forms.Button btnReserchNumber;
    }
}

