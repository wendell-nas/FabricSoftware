# FabricSoftware
Fabric Software é uma empresa que atua no seguimento de ERPs para gestão empresarial.




# Cálculo inss




# Cálculo imposto de renda




# Cálculo férias
Este programa realiza o cálculo do valor das férias de um colaborador com base no salário bruto informado pelo usuário. O programa utiliza uma constante para o cálculo do desconto do INSS e do IRRF, e considera um período de férias de 30 dias.

**Como utilizar**

Ao executar o programa, o usuário deve informar a sua remuneração bruta. O programa então irá calcular o valor das férias a partir deste valor, descontando o INSS e o IRRF e adicionando o terço constitucional.


# Cálculo deposito fgts




# Cálculo multa fgts




# Cálculo seguro desemprego
Este programa foi criado para verificar se o colaborador tem direito ao seguro desemprego, de acordo com as regras estabelecidas pelo governo brasileiro.

**Funcionamento**

O programa solicita algumas informações para o usuário, tais como: se o colaborador foi dispensado por justa causa, se ele está em situação de desemprego, se possui renda própria e se está recebendo benefício de prestação contínua da previdência social (exceto pensão por morte ou auxílio-acidente).

Em seguida, o programa solicita a quantidade de tempo que o colaborador trabalhou na empresa (em meses) e verifica se ele tem direito ao seguro desemprego e quantas parcelas ele receberá, de acordo com as regras abaixo:

**Primeira solicitação:**

12 meses ou mais: 5 parcelas

Entre 9 e 11 meses: 4 parcelas

Menos de 9 meses: sem direito

**Segunda solicitação:**

9 meses ou mais: 5 parcelas

Entre 12 e 23 meses: 4 parcelas

Entre 6 e 11 meses: 3 parcelas

Menos de 6 meses: sem direito

**Terceira solicitação ou mais:**

6 meses ou mais: 5 parcelas

Entre 12 e 23 meses: 4 parcelas

Menos de 12 meses: 3 parcelas

Sem direito

O programa exibe uma mensagem indicando se o colaborador tem ou não direito ao seguro desemprego, bem como o número de parcelas a que ele tem direito.

**Utilização**
Para utilizar o programa, basta inserir as informações necessárias para que o programa possa verificar se o colaborador tem direito ao seguro desemprego e quantas parcelas ele receberá.


# Cálculo vale transporte
Este programa permite ao usuário calcular se vale a pena utilizar o vale transporte oferecido pela empresa onde trabalha. Para isso, o colaborador precisa informar o seu salário e se utiliza meio de transporte público coletivo. Caso a resposta seja positiva, o sistema solicita informações sobre a quantidade de vales necessários por dia e o valor da passagem, e verifica se é vantajoso utilizar o vale transporte.
O programa também desconta 6% do salário do colaborador para o vale transporte e informa se é vantajoso utilizar o benefício.

**Como utilizar o programa**

O programa solicitará que o usuário informe o salário.

Em seguida, o usuário deve informar se utiliza meio de transporte público coletivo, digitando "s" para sim ou "n" para não.

Se o usuário informar que utiliza transporte público, o sistema solicitará as informações sobre quantidade de vales necessários por dia e valor da passagem.

O sistema calculará o valor a ser descontado do salário do colaborador e informará se é vantajoso utilizar o vale transporte.

O programa finalizará a execução com uma mensagem de agradecimento ao usuário.

# Cálculo pis
Este programa calcula o valor do PIS (Programa de Integração Social) a ser recebido pelo usuário com base em seu salário e tempo de trabalho. O usuário deve informar sua remuneração mensal, o tempo em que está cadastrado no PIS e quantos anos trabalha na empresa.

O programa então calcula o valor a ser recebido pelo usuário e verifica se o usuário tem direito ao PIS. Caso o usuário tenha menos de 5 anos de cadastro no PIS, ele não tem direito ao programa. Caso contrário, o programa informa o valor a ser recebido pelo usuário.


**Biblioteca utilizada**

O programa utiliza a biblioteca Matemática para arredondar o valor do PIS com 3 casas decimais.


**Como utilizar o programa**

Abra o programa.

Execute o programa.

Informe a remuneração mensal.

Informe o tempo em que está cadastrado no PIS.

Informe quantos anos trabalha na empresa.

O programa irá calcular e informar se o usuário tem direito ao PIS e qual o valor a ser recebido.

# Cálculo adcional noturno
Este programa foi criado para calcular o salário de um trabalhador com adicional noturno. Ele solicita ao usuário informações sobre seu salário, horas mensais trabalhadas e horas noturnas adicionais, e, em seguida, calcula o valor do adicional noturno.

**Como usar**

Ao executar o programa, ele irá solicitar que o usuário insira as informações necessárias e, em seguida, exibirá o valor do salário com o adicional noturno adicionado.

# Cálculo periculosidade




# Cálculo hora extra
Este é um programa que calcula o salário de um colaborador com base no salário base, carga horária mensal e horas extras trabalhadas. O programa também considera horas extras trabalhadas em dias úteis, domingos e feriados, e aplica taxas diferentes para cada tipo de hora extra.

**Bibliotecas utilizadas**

O programa utiliza duas bibliotecas: Matematica e Texto.

Matematica: para cálculos matemáticos, como arredondamento de valores.

Texto: para manipulação de strings, como transformar caracteres em caixa baixa.

**Funcionamento do programa**

**Ao ser executado, o programa solicita as seguintes informações ao usuário:**

Valor do salário base.

Carga horária mensal do colaborador de acordo com o contrato de trabalho do mesmo.

Se o colaborador realizou trabalho em domingos e feriados.

Se o colaborador realizou hora extra em dias úteis, caso tenha respondido "s" na pergunta anterior.

Quantidade de horas extras trabalhadas em dias úteis, caso tenha respondido "s" na pergunta anterior.

Quantidade de horas extras trabalhadas em domingos e feriados, caso tenha respondido "s" na pergunta anterior.

**Com base nessas informações, o programa realiza os seguintes cálculos:**

Calcula o valor da hora extra 100%, caso o colaborador tenha trabalhado em domingos e feriados.

Calcula o valor da hora extra 50%, caso o colaborador tenha trabalhado em dias úteis.

Calcula o valor total das horas extras 100%, caso o colaborador tenha trabalhado em domingos e feriados.

Calcula o valor total das horas extras 50%, caso o colaborador tenha trabalhado em dias úteis.

Calcula o valor bruto do salário, somando o salário base com as horas extras.

O valor bruto do salário é então arredondado para duas casas decimais e exibido na tela.

