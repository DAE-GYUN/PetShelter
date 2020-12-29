
namespace PetShelter
{
    partial class MainForm
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
            this.btnShowDogs = new DevExpress.XtraEditors.SimpleButton();
            this.btnShowAdoptingStep = new DevExpress.XtraEditors.SimpleButton();
            this.btnShowBranches = new DevExpress.XtraEditors.SimpleButton();
            this.btnDissolutionOfAdoptionRequest = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // btnShowDogs
            // 
            this.btnShowDogs.Location = new System.Drawing.Point(57, 142);
            this.btnShowDogs.Name = "btnShowDogs";
            this.btnShowDogs.Size = new System.Drawing.Size(149, 250);
            this.btnShowDogs.TabIndex = 0;
            this.btnShowDogs.Text = "강아지 보기";
            this.btnShowDogs.Click += new System.EventHandler(this.btnShowDogs_Click);
            // 
            // btnShowAdoptingStep
            // 
            this.btnShowAdoptingStep.Location = new System.Drawing.Point(233, 142);
            this.btnShowAdoptingStep.Name = "btnShowAdoptingStep";
            this.btnShowAdoptingStep.Size = new System.Drawing.Size(149, 250);
            this.btnShowAdoptingStep.TabIndex = 1;
            this.btnShowAdoptingStep.Text = "입양 절차";
            this.btnShowAdoptingStep.Click += new System.EventHandler(this.btnShowAdoptingStep_Click);
            // 
            // btnShowBranches
            // 
            this.btnShowBranches.Location = new System.Drawing.Point(411, 142);
            this.btnShowBranches.Name = "btnShowBranches";
            this.btnShowBranches.Size = new System.Drawing.Size(149, 250);
            this.btnShowBranches.TabIndex = 1;
            this.btnShowBranches.Text = "지점 안내";
            // 
            // btnDissolutionOfAdoptionRequest
            // 
            this.btnDissolutionOfAdoptionRequest.Location = new System.Drawing.Point(588, 142);
            this.btnDissolutionOfAdoptionRequest.Name = "btnDissolutionOfAdoptionRequest";
            this.btnDissolutionOfAdoptionRequest.Size = new System.Drawing.Size(149, 250);
            this.btnDissolutionOfAdoptionRequest.TabIndex = 2;
            this.btnDissolutionOfAdoptionRequest.Text = "파양 신청";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(353, 40);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(122, 18);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "강아강아 대동강아지";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnDissolutionOfAdoptionRequest);
            this.Controls.Add(this.btnShowBranches);
            this.Controls.Add(this.btnShowAdoptingStep);
            this.Controls.Add(this.btnShowDogs);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnShowDogs;
        private DevExpress.XtraEditors.SimpleButton btnShowAdoptingStep;
        private DevExpress.XtraEditors.SimpleButton btnShowBranches;
        private DevExpress.XtraEditors.SimpleButton btnDissolutionOfAdoptionRequest;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}