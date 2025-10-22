# 📚 Estudo: Serialização e Desserialização de Dados (Newtonsoft.Json)

Este repositório é um projeto de estudo focado na manipulação avançada de objetos JSON em C# utilizando a biblioteca **Newtonsoft.Json**.

O objetivo é demonstrar a capacidade de controlar o processo de conversão entre objetos C# e o formato JSON, aplicando as melhores práticas para legibilidade e segurança.

### 🚀 Conceitos e Habilidades Demonstradas

| Conceito | Descrição |
| :--- | :--- |
| **Atributos de Controle** | Uso dos atributos `[JsonProperty]` para renomear campos e `[JsonIgnore]` para **impedir a serialização de dados internos** (`SenhaInterna`). |
| **Configuração de Formato** | Implementação de `JsonSerializerSettings` estáticas para garantir **formatação padronizada** (JSON Indentado e formato de data `dd/MM/yyyy`). |
| **Fluxo Completo** | Demonstração clara dos processos de **Serialização** (Objeto -> JSON) e **Desserialização** (JSON -> Objeto). |
| **Controle de Tipos** | Uso de `[JsonConstructor]` para garantir a correta desserialização de objetos complexos com construtores customizados. |

---

### 💻 Como Testar o Projeto

Este é um projeto de Console Application, o que facilita a análise imediata do código e da saída.

#### 1. Requisitos

- **.NET SDK 8.0** (ou superior)

#### 2. Execução (30 segundos)

1. Clone o repositório:
    ```bash
    git clone https://github.com/Ca22io/Estudo-Serializacao-Desserializacao
    ```

2. Vá até o diretório do projeto e execute a aplicação:
    ```bash
    cd Estudo-Serializacao-Desserializacao
    dotnet run
    ```

#### 3. Resultado Esperado

A aplicação deve imprimir no console o JSON formatado e, em seguida, as propriedades do objeto desserializado, confirmando que o campo `SenhaInterna` foi corretamente omitido.
```markdown
/* Exemplo da Saída JSON Formatada */
{
  "id": 101,
  "titulo": "O Código Limpo",
  "autor": "Robert Martin",
  "dataPublicacao": "11/08/2008"
}
