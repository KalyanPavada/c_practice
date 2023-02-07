namespace calcu_WinFormsApp1
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

        private TextBox txtNum1;
        private TextBox txtNum2;
        private TextBox txtResult;
        private Button btnAdd;
        private Button btnSub;
        private Button btnMul;
        private Button btnDiv;
        private Button btnSet;
        private Button btnGet;
        private Button btnClear;
        
    }
}