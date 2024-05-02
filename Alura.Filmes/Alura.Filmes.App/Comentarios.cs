/*
O Entity usa convenções (convenção == regra implícita) (Convenção sobre Configuração) => facilita o trabalho do desenvolvedor

Uma das convenções usadas faz com que, para mapear o nome da tabela (neste caso representada pela Classe Ator), ele usa o nome da propriedade DbSet da classe em questão (ou seja, Atores)

Para burlar a convenção, o desenvolvedor configura (explicita) aquilo que for desviar da convenção implícita

Para quebrar a regra de nome de tabela diferente, usa-se o DataAnnotation [Table()] com o nome da tabela no banco de dados

Para quebrar a regra do nome de coluna diferente, usa-se o DataAnnotation [Column()] com o nome da coluna no banco de dados

Método onModelCreation
      => separa a configuração do modelo da configuração do contexto
      => o código descrito neste método é chamado de Fluent API
      => é uma boa prática separar o mapeamento do contexto (mundo relacional) da classe (mundo orientado a objetos)

DataAnnotations
      => são atributos que podem ser aplicados a classes, propriedades, métodos, parâmetros, retornos de métodos
      => servem para validar a instância

CLR
      => Common Language Runtime
      => é a máquina virtual que executa o código gerado pelo compilador

Tipos CLR => tipos que são reconhecidos pela CLR

Shadow properties => propriedades que não existem na classe, mas que existem no banco de dados

Triggers
      => são procedimentos armazenados que são executados automaticamente em resposta a determinados eventos no banco de dados
      => são usados para manter a integridade dos dados
      => são usados em shadows properties para manter a integridade dos dados

Short => tipo primitivo representa um inteiro de 16 bits

Configuration
      => classe que implementa a interface IEntityTypeConfiguration
      => é usada para configurar o mapeamento de uma entidade de forma separada do contexto

Include => método linq que faz o entity entender que precisa realizar um join

Para toda chave estrangeira o Entity criará um índice

O Entity não suporta nativamente restrições do tipo CHECK
      => para contornar isso, é necessário criar uma migração vazia e adicionar manualmente a restrição a ela

*/