# Atividade 3.4 – Paradigmas de Programação: Estruturado vs Orientado a Objetos

## Descrição da atividade

Esta atividade tem como objetivo comparar abordagens de programação estruturada e orientada a objetos para um sistema de cadastro de consumidores, utilizando Java, C# e Python. Cada consumidor possui:
- Nome
- Endereço
- Cidade

Foi solicitado também um relatório comparativo entre as abordagens.

---

## Estrutura de Pastas

```
atividade_3_4/
├─ java/
│  ├─ estruturado/
│  │   └─ ConsumidorEstruturado.java
│  └─ oop/
│      └─ ConsumidorOOP.java
├─ csharp/
│  ├─ estruturado/
│  │   └─ Program.cs
│  └─ oop/
│      └─ Program.cs
├─ python/
│  ├─ estruturado/
│  │   └─ consumidor_estruturado.py
│  └─ oop/
│      └─ consumidor_oop.py
├─ relatorio/
│   └─ comparativo.md
└─ README.md
```

---

## Como executar os exemplos

### Java

```bash
# Estruturado
cd atividade_3_4/java/estruturado
javac ConsumidorEstruturado.java
java ConsumidorEstruturado

# OOP
cd ../oop
javac ConsumidorOOP.java
java ConsumidorOOP
```

### C#

```bash
# Estruturado
cd atividade_3_4/csharp/estruturado
dotnet build
dotnet run

# OOP
cd ../oop
dotnet build
dotnet run
```

### Python

```bash
# Estruturado
cd atividade_3_4/python/estruturado
python consumidor_estruturado.py

# OOP
cd ../oop
python consumidor_oop.py
```

---

## Relatório comparativo

O relatório com as diferenças entre as abordagens está no arquivo [`relatorio/comparativo.md`](relatorio/comparativo.md).

---

## Autor

Felipe Alves  
Aluno de Engenharia de Software – Jala University

---

*Para dúvidas ou sugestões, consulte os códigos nas respectivas pastas ou abra uma issue no repositório.*
