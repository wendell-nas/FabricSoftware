# FabricSoftware
Fabric Software é uma empresa que atua no seguimento de ERPs para gestão empresarial.


# Simuladores

# Cálculo inss
Este programa calcula a contribuição do INSS (Instituto Nacional do Seguro Social) com base no salário de um indivíduo.

**Cálculo**

O programa calcula a contribuição do INSS verificando em qual faixa de tributação o salário se enquadra e aplicando a taxa de tributação e os valores de dedução apropriados. O valor da contribuição para cada faixa de tributação é armazenado na matriz **valor_do_inss** e depois somado para obter o valor total da contribuição em **valor_do_inss_oficial.**

**Como utilizar**

Para usar este programa, basta inserir o valor do salário desejado na variável **salario_oficial** e executar o programa. O valor da contribuição do INSS será exibido na variável **valor_do_inss_oficial.**

# Cálculo imposto de renda
Este programa calcula o valor do Imposto de Renda Retido na Fonte (IRRF) a ser descontado do salário de um funcionário, com base em seu salário bruto e na tabela de alíquotas vigente.

**Funcionamento**

O programa recebe o salário bruto (salario_p) e o valor do INSS a ser descontado (inss_p).

É feita a verificação se o salário é inferior ao limite de isenção. Se for, não é necessário entregar a declaração de Imposto de Renda e o programa encerra a execução.

Caso o salário seja superior ao limite de isenção, é calculado o salário líquido (salario_oficial) subtraindo-se o valor do INSS.

É feita uma série de verificações para identificar em qual faixa o salário se enquadra, e calcular o valor do IRRF a ser descontado. O valor do IRRF é armazenado na variável irpf.

O programa encerra a execução exibindo o valor do IRRF a ser descontado do salário do funcionário.

**Como Executar**

Para executar o programa, basta informar os valores do salário bruto e do INSS a serem descontados. O programa irá exibir o valor do IRRF a ser descontado do salário do funcionário.


# Cálculo férias
Este programa realiza o cálculo do valor das férias de um colaborador com base no salário bruto informado pelo usuário. O programa utiliza uma constante para o cálculo do desconto do INSS e do IRRF, e considera um período de férias de 30 dias.

**Como utilizar**

Ao executar o programa, o usuário deve informar a sua remuneração bruta. O programa então irá calcular o valor das férias a partir deste valor, descontando o INSS e o IRRF e adicionando o terço constitucional.


# Cálculo deposito fgts
Esse é um programa que calcula o valor do depósito do FGTS (Fundo de Garantia do Tempo de Serviço) a ser depositado pelo empregador em nome do funcionário, com base no número de meses trabalhados e no salário do funcionário.

**Como funciona o programa?**
O programa recebe como entrada o número de meses que o funcionário trabalhou e o seu salário. Em seguida, ele calcula o valor mensal a ser depositado de FGTS, com base em uma constante definida (PORCENTAGEM_FGTS = 8%). Por fim, ele multiplica o valor mensal pelo número de meses trabalhados para obter o valor total de depósito de FGTS a ser feito pelo empregador.

**Como usar o programa?**
**Para utilizar o programa, siga as instruções abaixo:**

Abra o programa.

Defina a variável 'salario_p' com o valor do salário do funcionário (se necessário).

Execute o programa.

Quando solicitado, informe o número de meses que o funcionário trabalhou.

Aguarde o programa calcular o valor do depósito de FGTS e exibir o resultado.



# Cálculo fgts
Este programa foi desenvolvido para calcular o valor mensal do FGTS (Fundo de Garantia por Tempo de Serviço) a partir do salário informado pelo usuário.

**Como utilizar o programa**

Abra o arquivo.

Digite o valor do salário na variável "salario_p" na linha 1 do código.

Compile e execute o programa.

O valor mensal do FGTS será exibido na tela.

**Funcionamento do programa**

O programa inicia com a declaração da variável "salario_p" que armazena o valor do salário informado pelo usuário. Em seguida, é declarada a variável "fgts_mensal" que armazena o valor mensal do FGTS.

A constante "PORCENTAGEM_FGTS" é utilizada para definir a porcentagem de 8% que é aplicada sobre o valor do salário para o cálculo do FGTS.

Na linha 3, o cálculo é realizado multiplicando o valor do salário pela porcentagem do FGTS e dividindo por 100.

Por fim, o valor mensal do FGTS é retornado na linha 4 do código.



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
Este é um programa simples que calcula o adicional de periculosidade a partir do salário informado.

**Como utilizar**
Ao executar o programa, será necessário informar o valor do salário. O programa calculará o adicional de periculosidade, que será retornado como resultado.

**Observações**
O valor do adicional de periculosidade é calculado a partir do valor do salário, que é informado pelo usuário.

O valor do adicional de periculosidade é calculado como sendo 30% do valor do salário informado.

O resultado do cálculo é retornado pelo programa.

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

# Tela Inss
Este programa é uma calculadora de INSS. Ele permite que o usuário insira seu salário e calcula o valor do INSS que deve ser pago com base em uma determinada tabela de alíquotas. O resultado é apresentado na tela em formato de moeda.

**Como utilizar**

Para utilizar a calculadora de INSS, basta executar o programa e seguir as instruções apresentadas na tela. O usuário deve digitar o valor do seu salário e, em seguida, o programa irá calcular o valor do INSS correspondente. O usuário pode optar por voltar ao menu principal para realizar uma nova operação ou finalizar o programa.

# Tela Imposto de renda 
Este programa é uma calculadora de Imposto de Renda de Pessoa Física (IRPF). O usuário deverá informar seu salário, e a calculadora irá calcular automaticamente o valor devido de IRPF e apresentar o resultado.

**Como utilizar**

Ao executar o programa, o usuário será apresentado com a seguinte mensagem: **DIGITE SEU SALÁRIO:**

O usuário deverá digitar seu salário e pressionar enter. Em seguida, o programa irá realizar o cálculo e apresentar o resultado da seguinte forma:  **SEU IRPF É IGUAL A:**

O usuário terá a opção de voltar ao menu principal ou finalizar o programa.

#Tela Férias 
Este programa tem como objetivo calcular o valor total das suas férias com base no salário informado, considerando o desconto do INSS e do IRPF.

**Como utilizar**

Execute o programa.

Informe o valor do seu salário.

O programa irá calcular o valor total das suas férias considerando o desconto do INSS e do IRPF.

O resultado será exibido na tela.

Você poderá escolher se deseja voltar ao menu principal ou finalizar o programa.

# Tela Fgts
Este programa é uma calculadora de FGTS mensal, onde o usuário insere o seu salário e o programa retorna o valor mensal do FGTS correspondente.

**Como utilizar**

Execute o programa.

Ao iniciar o programa, você será apresentado a tela de boas-vindas com a opção de digitar o seu salário.

Digite o valor do seu salário e tecle ENTER.

O programa irá calcular o valor do seu FGTS mensal e apresentá-lo na tela.

Será perguntado se deseja voltar ao menu principal ou finalizar o programa.

Se escolher voltar ao menu principal, o programa irá retornar para a tela inicial. Se escolher finalizar o programa, o programa irá encerrar.

# Tela Deposito Fgts
Este é um programa que calcula o valor do depósito FGTS (Fundo de Garantia do Tempo de Serviço) com base no salário informado pelo usuário.

O programa solicita ao usuário que digite o valor do salário e, em seguida, converte esse valor para um número real para que possa ser calculado o valor do depósito FGTS.

Após realizar o cálculo, o programa exibe o valor do depósito FGTS arredondado em duas casas decimais.

O programa também oferece a opção de voltar ao menu principal ou finalizar o programa após o cálculo ser concluído.

A interface do usuário é apresentada em uma caixa com bordas que delimitam o texto exibido.

**Como usar**

Para utilizar este programa, basta executar o código em um ambiente de programação não especificado. O programa solicitará que o usuário informe o valor do salário, que deve ser digitado após a mensagem "DIGITE SEU SALÁRIO: R$".

O programa exibirá o valor do depósito FGTS calculado com base no salário informado, e o usuário terá a opção de voltar ao menu principal ou finalizar o programa.

# Tela Seguro desemprego
Este programa tem como objetivo verificar o status do seguro desemprego de uma pessoa. Ele exibe uma tela com o resultado da verificação e oferece a opção de voltar ao menu principal ou finalizar o programa.

**Funcionamento**

Ao ser executado, o programa chama a função **verificador_de_seguro_desemprego** para realizar a verificação do seguro desemprego. Em seguida, a tela é limpa e exibida uma mensagem de cabeçalho.

Depois, o programa exibe o resultado da verificação na tela, por meio da variável **seguro_desemprego**. O usuário pode escolher entre voltar ao menu principal ou finalizar o programa. Se optar por voltar ao menu, o programa chama a função **tela_seguro_desemprego**. Caso contrário, é exibida a **função final**

# Tela Vale Transporte 
Esse é um programa simples que verifica se o usuário tem direito ao Vale Transporte de acordo com seu salário.

**Como usar**

Execute o programa.

Digite seu salário quando solicitado.

O programa irá verificar se você tem direito ao Vale Transporte e irá exibir a mensagem correspondente.

Você pode optar por voltar ao menu principal ou finalizar o programa.

# Tela 2 Vale Transporte 
Este programa calcula o valor do vale-transporte a ser pago ao funcionário de acordo com o salário e a resposta do usuário sobre o direito ao benefício.

**Funcionamento**

O programa inicia solicitando ao usuário a resposta para a pergunta **"NA SUA EMPRESA VOCÊ TEM O DIREITO VALE TRANSPOTE?(s)SIM/(n)NÃO:"**. O valor digitado é armazenado na variável **resposta_em_cadeia**. Em seguida, a função **t.caixa_baixa** é usada para transformar a resposta em minúsculo e a função **ti.cadeia_para_caracter** é usada para converter a resposta em caracter, armazenando o resultado na **variável resposta_do_usuario**.

A partir daí, o programa usa a estrutura de controle escolha para definir o valor do vale-transporte de acordo com a resposta do usuário. Se a resposta for "s", o valor do vale-transporte será calculado multiplicando o salário pela constante **porcentagem_para_calculo** e armazenado na variável **vale_transporte**. Se a resposta for "n", o valor do vale-transporte será igual a zero. Caso contrário, o programa exibe uma mensagem de erro solicitando que o usuário digite uma resposta correta.

Por fim, o valor do vale-transporte é retornado pelo programa.

**Como executar o programa**

Para executar o programa, basta copiar e colar o código em um ambiente de desenvolvimento que suporte a linguagem de programação em que ele foi escrito (não especificado no código fornecido) e rodar o programa. O usuário será solicitado a fornecer a resposta para a pergunta sobre o direito ao vale-transporte, e o valor calculado será exibido como resultado.
