//O Entity usa convenções (convenção == regra implícita) (Convenção sobre Configuração) => facilita o trabalho do desenvolvedor

//Uma das convenções usadas faz com que, para mapear o nome da tabela (neste caso representada pela Classe Ator), ele usa o nome da propriedade DbSet da classe em questão (ou seja, Atores)

//Para burlar a convenção, o desenvolvedor configura (explicita) aquilo que for desviar da convenção implícita

//Para quebrar a regra de nome de tabela diferente, usa-se o DataAnnotation [Table()] com o nome da tabela no banco de dados

//Para quebrar a regra do nome de coluna diferente, usa-se o DataAnnotation [Column()] com o nome da coluna no banco de dados