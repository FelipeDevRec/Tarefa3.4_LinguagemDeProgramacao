using System;
using System.Collections.Generic;
using System.Linq;

class Program {
    struct Consumidor {
        public string Nome;
        public string Endereco;
        public string Cidade;
    }

    static List<Consumidor> consumidores = new List<Consumidor>();

    static void CadastrarConsumidor(string nome, string endereco, string cidade) {
        Consumidor c = new Consumidor {
            Nome = nome,
            Endereco = endereco,
            Cidade = cidade
        };
        consumidores.Add(c);
        Console.WriteLine("✓ Consumidor cadastrado com sucesso!");
    }

    static void ListarConsumidores() {
        if (consumidores.Count == 0) {
            Console.WriteLine("Nenhum consumidor cadastrado.");
            return;
        }
        Console.WriteLine("\n=== LISTA DE CONSUMIDORES ===");
        for (int i = 0; i < consumidores.Count; i++) {
            Consumidor c = consumidores[i];
            Console.WriteLine($"{i + 1}. Nome: {c.Nome} | Endereco: {c.Endereco} | Cidade: {c.Cidade}");
        }
        Console.WriteLine("=============================\n");
    }

    static void BuscarConsumidor(string nome) {
        var encontrado = consumidores.FirstOrDefault(c => c.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
        if (string.IsNullOrEmpty(encontrado.Nome)) {
            Console.WriteLine("\n✗ Consumidor não encontrado.\n");
        } else {
            Console.WriteLine("\n✓ Consumidor encontrado!");
            Console.WriteLine($"Nome: {encontrado.Nome} | Endereco: {encontrado.Endereco} | Cidade: {encontrado.Cidade}\n");
        }
    }

    static void DeletarConsumidor(string nome) {
        var consumidor = consumidores.FirstOrDefault(c => c.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
        if (!string.IsNullOrEmpty(consumidor.Nome)
            && consumidores.Remove(consumidor)) {
            Console.WriteLine("✓ Consumidor removido com sucesso!");
        } else {
            Console.WriteLine("✗ Consumidor não encontrado.");
        }
    }

    static void Menu() {
        while (true) {
            Console.WriteLine("\n=== SISTEMA DE CADASTRO DE CONSUMIDORES ===");
            Console.WriteLine("1. Cadastrar consumidor");
            Console.WriteLine("2. Listar consumidores");
            Console.WriteLine("3. Buscar consumidor");
            Console.WriteLine("4. Deletar consumidor");
            Console.WriteLine("5. Sair");
            Console.Write("Escolha uma opção: ");

            if (int.TryParse(Console.ReadLine(), out int opcao)) {
                switch (opcao) {
                    case 1:
                        Console.Write("Nome: ");
                        string nome = Console.ReadLine();
                        Console.Write("Endereco: ");
                        string endereco = Console.ReadLine();
                        Console.Write("Cidade: ");
                        string cidade = Console.ReadLine();
                        CadastrarConsumidor(nome, endereco, cidade);
                        break;
                    case 2:
                        ListarConsumidores();
                        break;
                    case 3:
                        Console.Write("Digite o nome para buscar: ");
                        string busca = Console.ReadLine();
                        BuscarConsumidor(busca);
                        break;
                    case 4:
                        Console.Write("Digite o nome para deletar: ");
                        string deletar = Console.ReadLine();
                        DeletarConsumidor(deletar);
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
        Menu();
    }
}
