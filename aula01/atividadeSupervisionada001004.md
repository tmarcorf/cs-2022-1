### Semana 1 - Dia 25/05/2022 - Aulas 001a004 - Atividade Supervisionada

Primeiramente temos que nos atentar ao conceito de API (Application Program Interface). Sendo assim, uma API pode ser definida como um tipo de software que possui um conjunto de requisições que permite a comunicação de dados entre aplicações.
Essas requisições são responsáveis por fazer a manipulação dos dados e as principais são: 

- POST: realiza a criação de dados no servidor;
- GET: realiza a leitura dos dados no host;
- DELETE: exclui as informações;
- PUT: atualiza os registros existentes.

Já o conceito de Rest trata sobre um conjunto de restrições que devem ser atendidas para que as requisições HTTP estejam de acordo com a arquitetura.
As restrições determinadas pela arquitetura Rest são:

- cliente-servidor: as aplicações existentes no servidor e no cliente devem ser separadas;
- sem estado: as requisições são feitas de forma independente, ou seja, cada uma executa apenas uma determinada ação;
- cache: a API deve utilizar o cache para evitar chamadas recorrentes ao servidor;
- interface uniforme: agrupa mais outros quatro conceitos em que determina que os recursos devem ser identificados, a manipulação dos recursos deve ser por meio de representação, com mensagens autodescritivas e utilizar links para navegar pelo aplicativo.

Com isso, podemos também citar o fato de que existem três tipos de APIs:

- privadas: que são utilizadas internamente entre as aplicações de uma empresa, ou seja, de forma local;
- parceiros: que são utilizadas entre parceiros de negócios ou para permitir a intergração entre diferentes softwares;
- públicas: que podem ser utilizadas livremente. Muitas vezes são disponibilizadas por empresa para que os desenvolvedores possam fazer a integração com outras aplicações.

Portanto, percebemos que uma API que segue o padrão Rest consegue prover uma maior confiabilidade  escalabilidade para a aplicação, além de ser multiplataforma, permitindo uma melhor integração entre sistemas.