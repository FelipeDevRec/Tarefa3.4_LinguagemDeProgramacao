using System;
using System.Collections.Generic;
using System.Linq;

// Classe Representando o Consumidor
class Consumidor {
    public string Nome { get; set; }
    public string Endereco { get; set; }
    public string Cidade { get; set; }

    public Consumidor(string nome, string endereco, string cidade) {
        Nome = nome;
        Endereco = endereco;
        Cidade = cidade;
    }

    public void Exibir() {
        Console.WriteLine($"Nome: {Nome} | Endereco: {Endereco} | Cidade: {Cidade}");
    }
}

// Classe Sistema de Cadastro
class Program {
    List<Consumidor> consumidores = new List<Consumidor>();

    void CadastrarConsumidor() {
        Console.Write("Nome: ");
        string nome = Console.ReadLine();
        Console.Write("Endereco: ");
        string endereco = Console.ReadLine();
        Console.Write("Cidade: ");
        string cidade = Console.ReadLine();
        consumidores.Add(new Consumidor(nome, endereco, cidade));
        Console.WriteLine("✓ Consumidor cadastrado com sucesso!");
    }

    void ListarConsumidores() {
        if (consumidores.Count == 0) {
            Console.WriteLine("Nenhum consumidor cadastrado.");
            return;
        }
        Console.WriteLine("\n=== LISTA DE CONSUMIDORES ===");
        consumidores.ForEach(c => c.Exibir());
        Console.WriteLine("=============================\n");
    }

    void BuscarConsumidor() {
        Console.Write("Digite o nome para buscar: ");
        string nome = Console.ReadLine();
        var consumidor = consumidores.FirstOrDefault(c => c.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
        if (consumidor != null) {
            Console.WriteLine("\n✓ Consumidor encontrado!");
            consumidor.Exibir();
        } else {
            Console.WriteLine("\n✗ Consumidor não encontrado.\n");
        }
    }

    void DeletarConsumidor() {
        Console.Write("Digite o nome para deletar: ");
        string nome = Console.ReadLine();
        int removidos = consumidores.RemoveAll(c => c.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
        Console.WriteLine(removidos > 0 ? "✓ Consumidor removido com sucesso!" : "✗ Consumidor não encontrado.");
    }

    void Menu() {
        while (true) {
            Console.WriteLine("\n=== SISTEMA DE CADASTRO DE CONSUMIDORES (OOP) ===");
            Console.WriteLine("1. Cadastrar consumidor");
            Console.WriteLine("2. Listar consumidores");
            Console.WriteLine("3. Buscar consumidor");
            Console.WriteLine("4. Deletar consumidor");
            Console.WriteLine("5. Sair");
            Console.Write("Escolha uma opção: ");
            if (int.TryParse(Console.ReadLine(), out int opcao)) {
                switch (opcao) {
                    case 1:
                        CadastrarConsumidor();
                        break;
                    case 2:
                        ListarConsumidores();
                        break;
                    case 3:
                        BuscarConsumidor();
                        break;
                    case 4:
                        DeletarConsumidor();
                        break;
                    case 5:
                        Console.WriteLine("Encerrando...");
                        return;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            } else {
                Console.WriteLine("Entrada inválida!");
            }
        }
    }

    static void Main() {
        new Program().Menu();
    }
}
