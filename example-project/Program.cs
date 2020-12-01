using System;

namespace example_project
{
  class Program
  {
    static void Main(string[] args)
    {

      string opc = PrintOptions();
      Aluno[] alunos = new Aluno[5];

      int alunoIndex = 0;
      while (opc != "9")
      {

        switch (opc)
        {
          case "1":
            Console.WriteLine($"Insira o nome do aluno {alunoIndex + 1}");

            Aluno aluno = new Aluno();
            aluno.name = Console.ReadLine();

            Console.WriteLine($"Insira a nota do aluno {alunoIndex + 1}");

            if (decimal.TryParse(Console.ReadLine(), out decimal note))
            {
              aluno.note = note;
            }
            else
            {
              throw new ArgumentException();
            }
            alunos[alunoIndex] = aluno;
            alunoIndex++;
            break;
          case "2":
            foreach (var item in alunos)
            {
              if (!string.IsNullOrEmpty(item.name))
              {
                Console.WriteLine($"Aluno: {item.name} - Nota: {item.note}");
              }
            }
            break;
          case "3":
            decimal total = 0;
            for (int i = 0; i < alunos.Length; i++)
            {
              total += alunos[i].note;
            }
            total /= alunos.Length;

            Estado estado = total < 5 ? Estado.Ruim : (total < 7 ? Estado.Regular : Estado.Bom);
            
            Console.WriteLine($"Média geral: {total} - Estado da sala: {estado}");
            break;
          default:
            throw new ArgumentOutOfRangeException();
        }

        opc = PrintOptions();


      }

      string PrintOptions()
      {
        Console.WriteLine(
                  "Bem vindo! \n" +
                  "Escolha uma opção \n" +
                  "1 - Inserir Aluno \n" +
                  "2 - Listar Alunos \n" +
                  "3 - Calcular Média \n" +
                  "9 - Sair \n"
                  );

        string opc = Console.ReadLine();
        return opc;
      }
    }
  }
}

