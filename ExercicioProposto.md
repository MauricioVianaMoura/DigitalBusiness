Exercício de Fixação: Cadastro de Produtos
Descrição do Exercício:
Desenvolva uma aplicação simples em C# que permita gerenciar o cadastro de produtos. O objetivo é praticar o uso do Entity Framework Core com PostgreSQL, realizando operações básicas de inserção, leitura, atualização e exclusão de dados.

Requisitos Funcionais
1. Cadastro de Produtos:
    * Cada produto deve ter:
        * Id (chave primária, gerado automaticamente pelo banco de dados).
        * Nome.
        * Preço.
        * Quantidade em Estoque.
2. Operações CRUD:
    * Adicionar: Um novo produto no banco de dados.
    * Listar: Todos os produtos cadastrados.
    * Atualizar: Os dados de um produto.
    * Excluir: Um produto pelo ID.
3. Menu Interativo:
    * A aplicação deve ter um menu interativo no console para que o usuário possa escolher qual operação deseja realizar.
    * O menu deve ser exibido continuamente até o usuário optar por sair.

Explicação do Código
1. O Menu e o Loop while
* O loop while (true) é utilizado para manter o programa em execução até que o usuário escolha explicitamente sair.
* Dentro do while, um menu interativo é exibido ao usuário no console, com as opções disponíveis: adicionar, listar, atualizar, excluir ou sair.
* O fluxo da aplicação é controlado por um switch, que verifica a entrada do usuário e executa a operação correspondente.

Explicação Detalhada:
1. Exibição do Menu: O menu é exibido ao usuário sempre que o loop começa. Isso garante que o usuário possa realizar várias operações na mesma execução do programa.
2. Entrada do Usuário: O programa aguarda que o usuário digite uma opção (número entre 1 e 5). A entrada é lida pelo Console.ReadLine() e armazenada na variável option.
3. Decisão com switch: O switch avalia a entrada do usuário e chama a função correspondente:
    * "1" chama AddProduct para adicionar um produto.
    * "2" chama ListProducts para listar os produtos.
    * "3" chama UpdateProduct para atualizar um produto.
    * "4" chama DeleteProduct para excluir um produto.
    * "5" encerra o programa com return.
4. Condição de Saída:
    * O programa só é encerrado quando o usuário digita "5", o que aciona o comando return.
    * Caso contrário, o loop reinicia e exibe o menu novamente.
5. Validação: Se o usuário digitar uma opção inválida, como "abc" ou "6", o default é executado, exibindo a mensagem "Opção inválida.".

2. Classe Product
A classe Product representa a entidade que será salva no banco de dados. Ela contém as seguintes propriedades:
* Id: Identificador único do produto.
* Name: Nome do produto.
* Price: Preço do produto.
* StockQuantity: Quantidade em estoque.

3. Configuração do Banco de Dados
O contexto do banco de dados, representado pela classe AppDbContext, é configurado para gerenciar a entidade Product e conectar-se ao PostgreSQL.

4. Operações CRUD
Cada operação do CRUD está encapsulada em métodos separados no Program.cs:

Objetivo do Exercício
* Praticar operações CRUD básicas com o Entity Framework Core.
* Aprender a usar um menu interativo com while.
* Familiarizar-se com a conexão a um banco de dados PostgreSQL.

