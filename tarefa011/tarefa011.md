# Tarefa 011 - Padrões de Codificação (Leiaute e estilo), Reflexão e Programação defensiva

  ### 2.1 - A definição de cada um destes conceitos;

  **Padrões de codificação** são regras pré estabelecidas dentro de equipes de desenvolvimento para facilitar a codificação e o entendimento do código do colega. É através dos padrões de codificação que uma equipe consegue ser mais produtiva na hora de codificar, revisar códigos, refatorar e etc.

  **Reflexão** é um recurso fornecido por linguagens de programação que permite às pessoas desenvolvedoras obter informações internas de assemblies, métodos, atributos, propriedades. Com reflexão, é possível um tipo de uma instância e invocar seus métodos, instanciar um tipo genérico e etc.

  **Programação defensiva** é uma boa prática de codificação para evitar que possíveis imprevistos aconteçam no código. A programação defensiva une a retirada de código desnecessário com a realização de testes extensivos.

  ### 2.2 - Um descrição de quando, onde e porque utilizá-lo e

  **Padrões de codificação** podem e devem ser utilizados por equipes de desenvolvimento seja para iniciar um novo projeto ou dar manutenção num projeto já existente. Isso evita reprovação na revisão de código e mantém a qualidade do software.

  A **reflexão** pode ser utilizada em padrões de projeto, como por exemplo o Factory. Dinamicamente, não se sabe o que pode chegar para ser instanciado, com isso, a reflexão se faz necessária para descobrir os tipos e instanciar os objetos corretamente.

  A **programação defensiva** deve ser um pilar para desenvolvedores, uma vez que hoje, os sistemas contam com muitas integrações e comunicações, fazendo com que haja um risco maior na hora de expor um serviço por exemplo.

  ### 2.3 - Um exemplo de utilização.

  **Padrão de codificação**: No C#, todos os métodos são definidos com a inicial maiúscula.
  **Reflexão**: Para invocar métodos de um classe com base em seu tipo.
  **Programação**: defensiva: No tratamento de SQL Injection na definição de formulários.
