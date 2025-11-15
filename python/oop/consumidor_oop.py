class Consumidor:
    def __init__(self, nome, endereco, cidade):
        self.nome = nome
        self.endereco = endereco
        self.cidade = cidade

    def exibir(self):
        print(f"Nome: {self.nome} | Endereco: {self.endereco} | Cidade: {self.cidade}")

class SistemaCadastro:
    def __init__(self):
        self.consumidores = []

    def cadastrar_consumidor(self):
        nome = input("Nome: ")
        endereco = input("Endereco: ")
        cidade = input("Cidade: ")
        self.consumidores.append(Consumidor(nome, endereco, cidade))
        print("✓ Consumidor cadastrado com sucesso!")

    def listar_consumidores(self):
        if not self.consumidores:
            print("Nenhum consumidor cadastrado.")
            return
        print("\n=== LISTA DE CONSUMIDORES ===")
        for consumidor in self.consumidores:
            consumidor.exibir()
        print("=============================\n")

    def buscar_consumidor(self):
        nome = input("Digite o nome para buscar: ")
        for consumidor in self.consumidores:
            if consumidor.nome.lower() == nome.lower():
                print("\n✓ Consumidor encontrado!")
                consumidor.exibir()
                return
        print("\n✗ Consumidor não encontrado.\n")

    def deletar_consumidor(self):
        nome = input("Digite o nome para deletar: ")
        removidos = [c for c in self.consumidores if c.nome.lower() == nome.lower()]
        self.consumidores = [c for c in self.consumidores if c.nome.lower() != nome.lower()]
        print("✓ Consumidor removido com sucesso!" if removidos else "✗ Consumidor não encontrado.")

    def menu(self):
        while True:
            print("\n=== SISTEMA DE CADASTRO DE CONSUMIDORES (OOP) ===")
            print("1. Cadastrar consumidor")
            print("2. Listar consumidores")
            print("3. Buscar consumidor")
            print("4. Deletar consumidor")
            print("5. Sair")
            opcao = input("Escolha uma opção: ")

            if opcao == '1':
                self.cadastrar_consumidor()
            elif opcao == '2':
                self.listar_consumidores()
            elif opcao == '3':
                self.buscar_consumidor()
            elif opcao == '4':
                self.deletar_consumidor()
            elif opcao == '5':
                print("Encerrando...")
                break
            else:
                print("Opção inválida!")

if __name__ == "__main__":
    SistemaCadastro().menu()
