using System;
using System.Collections.Generic;
using admtarefas.Model;

namespace admtarefas.Controller
{
    public class TarefaController
    {
        // Lista onde as tarefas ficam guardadas em memória
        private List<Tarefa> listaTarefas = new List<Tarefa>();

        // Método para cadastrar uma nova tarefa
        public void CadastrarTarefa(string nome, DateTime data, string status)
        {
            Tarefa nova = new Tarefa(nome, data, status);
            listaTarefas.Add(nova);
        }

        // Retorna todas as tarefas para a View exibir
        public List<Tarefa> ListarTarefas()
        {
            return listaTarefas;
        }
    }
}
