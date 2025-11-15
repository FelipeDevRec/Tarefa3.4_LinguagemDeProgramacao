import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

// Classe Representando o Consumidor
class Consumidor {
    private String nome;
    private String endereco;
    private String cidade;

    public Consumidor(String nome, String endereco, String cidade) {
        this.nome = nome;
        this.endereco = endereco;
        this.cidade = cidade;
    }

    public String getNome() { return nome; }
    public String getEndereco() { return endereco; }
    public String getCidade() { return cidade; }

    public void exibir() {
        System.out.println("Nome: " + nome + " | Endereco: " + endereco + " | Cidade: " + cidade);
    }
}

// Classe Sistema de Cadastro
public class ConsumidorOOP {
    private List<Consumidor> consumidores = new ArrayList<>();
    private Scanner scanner = new Scanner(System.in);

    public void cadastrarConsumidor() {
        System.out.print("Nome: ");
        String nome = scanner.nextLine();
        System.out.print("Endereco: ");
        String endereco = scanner.nextLine();
        System.out.print("Cidade: ");
        String cidade = scanner.nextLine();
        consumidores.add(new Consumidor(nome, endereco, cidade));
        System.out.println("✓ Consumidor cadastrado com sucesso!");
    }

    public void listarConsumidores() {
        if (consumidores.isEmpty()) {
            System.out.println("Nenhum consumidor cadastrado.");
            return;
        }
        System.out.println("\n=== LISTA DE CONSUMIDORES ===");
        consumidores.forEach(Consumidor::exibir);
        System.out.println("=============================\n");
    }

    public void buscarConsumidor() {
        System.out.print("Digite o nome para buscar: ");
        String nome = scanner.nextLine();
        for (Consumidor c : consumidores) {
            if (c.getNome().equalsIgnoreCase(nome)) {
                System.out.println("\n✓ Consumidor encontrado!");
                c.exibir();
                return;
            }
        }
        System.out.println("\n✗ Consumidor não encontrado.\n");
    }

    public void deletarConsumidor() {
        System.out.print("Digite o nome para deletar: ");
        String nome = scanner.nextLine();
        consumidores.removeIf(c -> c.getNome().equalsIgnoreCase(nome));
        System.out.println("Operação concluída. (Caso o nome existisse, foi removido)");
    }

    public void menu() {
        while (true) {
            System.out.println("\n=== SISTEMA DE CADASTRO DE CONSUMIDORES (OOP) ===");
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
                    cadastrarConsumidor();
                    break;
                case 2:
                    listarConsumidores();
                    break;
                case 3:
                    buscarConsumidor();
                    break;
                case 4:
                    deletarConsumidor();
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
        new ConsumidorOOP().menu();
    }
}
