﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlunosPorCurso
{
    class Aluno
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        
        public Aluno(int codigo, string nome)
        {
            this.Codigo = codigo;
            this.Nome = nome;
        }


    }
}
