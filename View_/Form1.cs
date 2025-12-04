using System;
using System.Windows.Forms;
using System.Xml.Linq;
using admtarefas.Controller;
using admtarefas.Controller;
using admTarefas;

namespace admtarefas.View_
{
    public partial class FormTarefas : Form
    {
        TarefaController controller = new TarefaController();

        public FormTarefas()
        {
            InitializeComponent();

            cbStatus.Items.Add("Pendente");
            cbStatus.Items.Add("Em andamento");
            cbStatus.Items.Add("Concluída");
            cbStatus.SelectedIndex = 0;

            AtualizarGrid();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            DateTime data = dtData.Value;
            string status = cbStatus.SelectedItem.ToString();

            controller.CadastrarTarefa(nome, data, status);
            AtualizarGrid();

            txtNome.Text = "                ";
            cbStatus.SelectedIndex = 0;
        }

        private void AtualizarGrid()
        {
            dgTarefas.DataSource = null;
            dgTarefas.DataSource = controller.ListarTarefas();
        }

        private void InitializeComponent()
        {
            cbStatus = new ComboBox();
            dtData = new DateTimePicker();
            txtNome = new TextBox();
            dgTarefas = new DataGridView();
            btnCadastrar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            funcionáriosToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgTarefas).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Location = new Point(307, 114);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(147, 33);
            cbStatus.TabIndex = 0;
            // 
            // dtData
            // 
            dtData.Location = new Point(532, 114);
            dtData.Name = "dtData";
            dtData.Size = new Size(149, 31);
            dtData.TabIndex = 1;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(131, 117);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 31);
            txtNome.TabIndex = 2;
            // 
            // dgTarefas
            // 
            dgTarefas.BackgroundColor = Color.FromArgb(64, 64, 64);
            dgTarefas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgTarefas.Location = new Point(131, 208);
            dgTarefas.Name = "dgTarefas";
            dgTarefas.RowHeadersWidth = 62;
            dgTarefas.Size = new Size(676, 284);
            dgTarefas.TabIndex = 3;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = SystemColors.ControlDarkDark;
            btnCadastrar.Location = new Point(735, 101);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(193, 60);
            btnCadastrar.TabIndex = 4;
            btnCadastrar.Text = "Cadastrar Tarefa";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(63, 123);
            label1.Name = "label1";
            label1.Size = new Size(62, 25);
            label1.TabIndex = 5;
            label1.Text = "Tarefa:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(237, 123);
            label2.Name = "label2";
            label2.Size = new Size(64, 25);
            label2.TabIndex = 6;
            label2.Text = "Status:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(473, 123);
            label3.Name = "label3";
            label3.Size = new Size(53, 25);
            label3.TabIndex = 7;
            label3.Text = "Data:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(307, 38);
            label4.Name = "label4";
            label4.Size = new Size(246, 45);
            label4.TabIndex = 8;
            label4.Text = "Cadastrar Tarefa";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(953, 33);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { funcionáriosToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(73, 29);
            toolStripMenuItem1.Text = "Menu";
            // 
            // funcionáriosToolStripMenuItem
            // 
            funcionáriosToolStripMenuItem.Name = "funcionáriosToolStripMenuItem";
            funcionáriosToolStripMenuItem.Size = new Size(214, 34);
            funcionáriosToolStripMenuItem.Text = "Funcionários";
            funcionáriosToolStripMenuItem.Click += funcionáriosToolStripMenuItem_Click;
            // 
            // FormTarefas
            // 
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(953, 508);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCadastrar);
            Controls.Add(dgTarefas);
            Controls.Add(txtNome);
            Controls.Add(dtData);
            Controls.Add(cbStatus);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormTarefas";
            Text = "Cadastro de Tarefas";
            ((System.ComponentModel.ISupportInitialize)dgTarefas).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        private ComboBox cbStatus;
        private DateTimePicker dtData;
        private TextBox txtNome;
        private DataGridView dgTarefas;
        private Button btnCadastrar;

        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            DateTime data = dtData.Value;
            string status = cbStatus.SelectedItem.ToString();

            controller.CadastrarTarefa(nome, data, status);
            AtualizarGrid();

            txtNome.Text = "";
            cbStatus.SelectedIndex = 0;
        }

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem funcionáriosToolStripMenuItem;

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFuncionários  frm = new FormFuncionários();
            frm.Show();
        }
    }
}
