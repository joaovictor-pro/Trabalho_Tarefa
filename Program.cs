using System;
using System.Windows.Forms;
using admtarefas.View_;


namespace admTarefas
{
	static class Program
	{
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.Run(new FormTarefas()); // ← CORRETO
		}
	}
}
