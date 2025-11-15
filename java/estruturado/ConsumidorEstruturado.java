import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class ConsumidorEstruturado {
    
    // Estrutura de dados para armazenar consumidores
    static class Consumidor {
        String nome;
        String endereco;
        String cidade;
    }
    
    static List<Consumidor> consumidores = new ArrayList<>();
    static Scanner scanner = new Scanner(System.in);
    
    // Função para cadastrar um consumidor
    static void cadastrarConsumidor(String nome, String endereco, String cidade) {
        Consumidor c = new Consumidor();
        c.nome = nome;
        c.endereco = endereco;
        c.cidade = cidade;
        consumidores.add(c);
        System.out.println("✓ Consumidor cadastrado com sucesso!");
    }
    
    // Função para listar todos os consumidores
    static void listarConsumidores() {
        if (consumidores.isEmpty()) {
            System.out.println("Nenhum consumidor cadastrado.");
            return;
        }
        System.out.println("\n=== LISTA DE CONSUMIDORES ===");
        for (int i = 0; i < consumidores.size(); i++) {
            Consumidor c = consumidores.get(i);
            System.out.println((i + 1) + ". Nome: " + c.nome + " | Endereco: " + c.endereco + " | Cidade: " + c.cidade);
        }
        System.out.println("=============================\n");
    }
    
    // Função para buscar consumidor por nome
    static void buscarConsumidor(String nome) {
        for (Consumidor c : consumidores) {
            if (c.nome.equalsIgnoreCase(nome)) {
                System.out.println("\n✓ Consumidor encontrado!");
                System.out.println("Nome: " + c.nome + " | Endereco: " + c.endereco + " | Cidade: " + c.cidade + "\n");
                return;
            }
        }
        System.out.println("\n✗ Consumidor não encontrado.\n");
    }
    
    // Função para deletar consumidor
    static void deletarConsumidor(String nome) {
        for (int i = 0; i < consumidores.size(); i++) {
            if (consumidores.get(i).nome.equalsIgnoreCase(nome)) {
                consumidores.remove(i);
                System.out.println("✓ Consumidor removido com sucesso!");
                return;
            }
        }
        System.out.println("✗ Consumidor não encontrado.");
    }
    
    // Menu interativo
    static void menu() {
        while (true) {
            System.out.println("\n=== SISTEMA DE CADASTRO DE CONSUMIDORES ===");
            System.out.println("1. Cadastrar consumidor");
            System.out.println("2. Listar consumidores");
            System.out.println("3. Buscar consumidor");
            System.out.println("4. Deletar consumidor");
            System.out.println("5. Sair");
            System.out.print("Escolha uma opção: ");
            
            int opcao = scanner.nextInt();
            scanner.nextLine();
            
            switch (opcao) {
                case 1:
                    System.out.print("Nome: ");
                    String nome = scanner.nextLine();
                    System.out.print("Endereco: ");
                    String endereco = scanner.nextLine();
                    System.out.print("Cidade: ");
                    String cidade = scanner.nextLine();
                    cadastrarConsumidor(nome, endereco, cidade);
                    break;
                case 2:
                    listarConsumidores();
                    break;
                case 3:
                    System.out.print("Digite o nome para buscar: ");
                    String busca = scanner.nextLine();
                    buscarConsumidor(busca);
                    break;
                case 4:
                    System.out.print("Digite o nome para deletar: ");
                    String deletar = scanner.nextLine();
                    deletarConsumidor(deletar);
                    break;
                case 5:
                    System.out.println("Encerrando...");
                    scanner.close();
                    return;
                default:
                    System.out.println("Opção inválida!");
            }
        }
    }
    
    public static void main(String[] args) {
        menu();
    }
}