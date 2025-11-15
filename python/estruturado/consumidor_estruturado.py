# Dicionários para armazenar dados dos consumidores
consumidores = []

def cadastrar_consumidor(nome, endereco, cidade):
    """Cadastra um novo consumidor"""
    consumidor = {
        'nome': nome,
        'endereco': endereco,
        'cidade': cidade
    }
    consumidores.append(consumidor)
    print("✓ Consumidor cadastrado com sucesso!")

def listar_consumidores():
    """Lista todos os consumidores cadastrados"""
    if not consumidores:
        print("Nenhum consumidor cadastrado.")
        return
    
    print("\n=== LISTA DE CONSUMIDORES ===")
    for i, c in enumerate(consumidores, 1):
        print(f"{i}. Nome: {c['nome']} | Endereco: {c['endereco']} | Cidade: {c['cidade']}")
    print("=============================\n")

def buscar_consumidor(nome):
    """Busca um consumidor por nome"""
    for c in consumidores:
        if c['nome'].lower() == nome.lower():
            print(f"\n✓ Consumidor encontrado!")
            print(f"Nome: {c['nome']} | Endereco: {c['endereco']} | Cidade: {c['cidade']}\n")
            return
    print("\n✗ Consumidor não encontrado.\n")

def deletar_consumidor(nome):
    """Deleta um consumidor por nome"""
    for i, c in enumerate(consumidores):
        if c['nome'].lower() == nome.lower():
            consumidores.pop(i)
            print("✓ Consumidor removido com sucesso!")
            return
    print("✗ Consumidor não encontrado.")

def menu():
    """Menu interativo do sistema"""
    while True:
        print("\n=== SISTEMA DE CADASTRO DE CONSUMIDORES ===")
        print("1. Cadastrar consumidor")
        print("2. Listar consumidores")
        print("3. Buscar consumidor")
        print("4. Deletar consumidor")
        print("5. Sair")
        
        opcao = input("Escolha uma opção: ")
        
        if opcao == '1':
            nome = input("Nome: ")
            endereco = input("Endereco: ")
            cidade = input("Cidade: ")
            cadastrar_consumidor(nome, endereco, cidade)
        
        elif opcao == '2':
            listar_consumidores()
        
        elif opcao == '3':
            busca = input("Digite o nome para buscar: ")
            buscar_consumidor(busca)
        
        elif opcao == '4':
            deletar = input("Digite o nome para deletar: ")
            deletar_consumidor(deletar)
        
        elif opcao == '5':
            print("Encerrando...")
            break
        
        else:
            print("Opção inválida!")

if __name__ == "__main__":
    menu()