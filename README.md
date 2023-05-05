# Fabric Software
Fabric Software é uma empresa que atua no seguimento de ERPs para gestão empresarial.


# Cálculo inss
**Como utilizar**

Para usar este programa, basta inserir o valor do salário desejado na variável **salario_oficial** e executar o programa. O valor da contribuição do INSS será exibido na variável **valor_do_inss_oficial.**

# Cálculo imposto de renda
**Funcionamento**

O programa recebe o salário bruto (salario_p) e o valor do INSS a ser descontado (inss_p).

É feita a verificação se o salário é inferior ao limite de isenção. Se for, não é necessário entregar a declaração de Imposto de Renda e o programa encerra a execução.

Caso o salário seja superior ao limite de isenção, é calculado o salário líquido (salario_oficial) subtraindo-se o valor do INSS.

É feita uma série de verificações para identificar em qual faixa o salário se enquadra, e calcular o valor do IRRF a ser descontado. O valor do IRRF é armazenado na variável irpf.

O programa encerra a execução exibindo o valor do IRRF a ser descontado do salário do funcionário.

# Cálculo férias
**Como utilizar**

Ao executar o programa, o usuário deve informar a sua remuneração bruta. O programa então irá calcular o valor das férias a partir deste valor, descontando o INSS e o IRRF e adicionando o terço constitucional.


# Cálculo deposito fgts
**Como funciona o programa?**
O programa recebe como entrada o número de meses que o funcionário trabalhou e o seu salário. Em seguida, ele calcula o valor mensal a ser depositado de FGTS, com base em uma constante definida (PORCENTAGEM_FGTS = 8%). Por fim, ele multiplica o valor mensal pelo número de meses trabalhados para obter o valor total de depósito de FGTS a ser feito pelo empregador.

# Cálculo fgts
**Como utilizar o programa**

Abra o arquivo.

Digite o valor do salário na variável "salario_p" na linha 1 do código.

Compile e execute o programa.

O valor mensal do FGTS será exibido na tela.

# Cálculo seguro desemprego
**Funcionamento**

O programa solicita algumas informações para o usuário, tais como: se o colaborador foi dispensado por justa causa, se ele está em situação de desemprego, se possui renda própria e se está recebendo benefício de prestação contínua da previdência social (exceto pensão por morte ou auxílio-acidente).

Em seguida, o programa solicita a quantidade de tempo que o colaborador trabalhou na empresa (em meses) e verifica se ele tem direito ao seguro desemprego e quantas parcelas ele receberá.

O programa exibe uma mensagem indicando se o colaborador tem ou não direito ao seguro desemprego, bem como o número de parcelas a que ele tem direito.

# Cálculo vale transporte
**Como utilizar o programa**

O programa solicitará que o usuário informe o salário.

Em seguida, o usuário deve informar se utiliza meio de transporte público coletivo, digitando "s" para sim ou "n" para não.

Se o usuário informar que utiliza transporte público, o sistema solicitará as informações sobre quantidade de vales necessários por dia e valor da passagem.

O sistema calculará o valor a ser descontado do salário do colaborador e informará se é vantajoso utilizar o vale transporte.

O programa finalizará a execução com uma mensagem de agradecimento ao usuário.

# Cálculo pis
O programa então calcula o valor a ser recebido pelo usuário e verifica se o usuário tem direito ao PIS. Caso o usuário tenha menos de 5 anos de cadastro no PIS, ele não tem direito ao programa. Caso contrário, o programa informa o valor a ser recebido pelo usuário.

O programa irá calcular e informar se o usuário tem direito ao PIS e qual o valor a ser recebido.

# Cálculo adcional noturno
**Como usar**

Ao rodar o programa, o usuário será solicitado a informar as seguintes informações:

Quantas horas mensais o funcionário trabalha;

Quantas horas noturnas trabalhou a mais em relação a sua carga horária mensal.

Com base nessas informações, o programa irá calcular o adicional noturno a ser pago ao funcionário e retornar o valor calculado.
# Cálculo periculosidade
**Como utilizar**
Ao executar o programa, será necessário informar o valor do salário. O programa calculará o adicional de periculosidade, que será retornado como resultado.

**Observações**
O valor do adicional de periculosidade é calculado a partir do valor do salário, que é informado pelo usuário.

O valor do adicional de periculosidade é calculado como sendo 30% do valor do salário informado.

O resultado do cálculo é retornado pelo programa.

# Cálculo hora extra
Este é um programa que calcula o salário de um colaborador com base no salário base, carga horária mensal e horas extras trabalhadas. O programa também considera horas extras trabalhadas em dias úteis, domingos e feriados, e aplica taxas diferentes para cada tipo de hora extra.

# Tela Inss
**Como utilizar**

Para utilizar a calculadora de INSS, basta executar o programa e seguir as instruções apresentadas na tela. O usuário deve digitar o valor do seu salário e, em seguida, o programa irá calcular o valor do INSS correspondente. O usuário pode optar por voltar ao menu principal para realizar uma nova operação ou finalizar o programa.

# Tela Imposto de renda 
**Como utilizar**

Ao executar o programa, o usuário será apresentado com a seguinte mensagem: **DIGITE SEU SALÁRIO:**

O usuário deverá digitar seu salário e pressionar enter. Em seguida, o programa irá realizar o cálculo e apresentar o resultado da seguinte forma:  **SEU IRPF É IGUAL A:**

O usuário terá a opção de voltar ao menu principal ou finalizar o programa.

#Tela Férias 
**Como utilizar**

Execute o programa.

Informe o valor do seu salário.

O programa irá calcular o valor total das suas férias considerando o desconto do INSS e do IRPF.

O resultado será exibido na tela.

Você poderá escolher se deseja voltar ao menu principal ou finalizar o programa.

# Tela Fgts
**Como utilizar**

Execute o programa.

Ao iniciar o programa, você será apresentado a tela de boas-vindas com a opção de digitar o seu salário.

Digite o valor do seu salário e tecle ENTER.

O programa irá calcular o valor do seu FGTS mensal e apresentá-lo na tela.

Será perguntado se deseja voltar ao menu principal ou finalizar o programa.

Se escolher voltar ao menu principal, o programa irá retornar para a tela inicial. Se escolher finalizar o programa, o programa irá encerrar.

# Tela Deposito Fgts
O programa solicita ao usuário que digite o valor do salário e, em seguida, converte esse valor para um número real para que possa ser calculado o valor do depósito FGTS.

Após realizar o cálculo, o programa exibe o valor do depósito FGTS arredondado em duas casas decimais.

O programa também oferece a opção de voltar ao menu principal ou finalizar o programa após o cálculo ser concluído.

A interface do usuário é apresentada em uma caixa com bordas que delimitam o texto exibido.

# Tela Seguro desemprego
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
**Como executar o programa**

Para executar o programa, basta inserir as informaçoes necessárias.

O usuário será solicitado a fornecer a resposta para a pergunta sobre o direito ao vale-transporte, e o valor calculado será exibido como resultado.

# Tela Pis
**Funcionamento do programa**

O programa solicita que o usuário informe o salário como uma string.

A string é convertida em um valor real utilizando a função **convertor_de_cadeia_para_real.**

O programa calcula o valor do PIS utilizando a função **calculador_e_verificador_de_piss.**

Se o valor do PIS for diferente de zero, o programa exibe uma mensagem informando o valor.

Caso contrário, exibe uma mensagem informando que o usuário não tem direito ao benefício.

O programa oferece a opção de voltar ao menu principal ou finalizar o programa.

# Tela Adicional Noturno
**Funcionamento**

Ao ser executado, o programa exibe um menu principal com as seguintes opções:

Digitar salário: o usuário deve inserir seu salário.

Calcular adicional noturno: o programa irá calcular o valor do adicional noturno e exibir o resultado na tela.

Voltar ao menu principal: retorna ao menu principal.

O usuário deve inserir seu salário e, em seguida, escolher a opção de calcular o adicional noturno. O programa irá então calcular o valor do adicional noturno e exibi-lo na tela, juntamente com o valor do salário mais o adicional noturno.

O usuário pode escolher voltar ao menu principal para realizar novos cálculos ou finalizar o programa.

# Tela 2 Adicional Noturno
**Como funciona o programa**

O programa recebe o salário mensal do funcionário e a carga horária mensal trabalhada.

É solicitado ao usuário que informe a quantidade de horas noturnas extras trabalhadas.

Com base nas informações fornecidas, o programa calcula o valor da hora trabalhada.

Em seguida, o programa calcula o valor do adicional noturno, que é igual a 20% do valor da hora trabalhada multiplicado pelo número de horas noturnas extras trabalhadas.

Por fim, o programa retorna o valor do adicional noturno calculado.

# Tela Periculosidade

**Funcionamento**

O programa solicita que o usuário digite o salário e, em seguida, converte a entrada de string para um valor real. Em seguida, a função calculador_de_periculosidade é chamada para calcular a periculosidade do trabalhador, que é arredondada para duas casas decimais. O resultado é então exibido na tela.

O programa oferece opções ao usuário para voltar ao menu principal ou finalizar o programa.

# Tela 2 Periculosidade
**Como usar o programa**

O usuário deve fornecer o salário do funcionário na variável "salario_p".

O programa solicita ao usuário que informe se a empresa oferece adicional de periculosidade.

O usuário deve digitar "s" caso a empresa ofereça o benefício ou "n" caso contrário.

O programa realiza o cálculo do adicional de periculosidade, caso a resposta seja "s", e armazena o resultado na variável "periculosidade".

# Tela Horas Extras 
Este é um programa simples que calcula o valor total do salário de hora extra com base no salário oficial informado pelo usuário. O programa foi desenvolvido utilizando a linguagem de programação não especificada.

**Como usar**

Execute o programa.

Digite seu salário oficial quando solicitado.

O programa calculará o valor total das suas horas extras e exibirá na tela.

Você pode escolher voltar ao menu principal ou finalizar o programa.

# Tela 2 Horas Extras
**Funcionamento do programa**

O usuário deverá informar a quantidade de horas extras trabalhadas em dias úteis quando for solicitado pelo programa. Em seguida, o programa calculará o valor das horas extras trabalhadas, considerando a taxa de acréscimo de 50% sobre o valor da hora normal de trabalho. O valor bruto das horas extras trabalhadas será retornado ao usuário.

# Tela Detalhamento
**Funcionamento**

Ao executar o programa, o usuário é apresentado a uma tela inicial com algumas informações sobre o programa e instruções para digitar o seu salário bruto. Após inserir o valor, o programa realiza uma série de cálculos para determinar o valor do salário líquido, considerando benefícios como vale transporte, periculosidade, hora extra e adicional noturno, além de descontos como INSS e IRPF.

Ao final dos cálculos, o programa exibe na tela um detalhamento do valor de cada benefício e desconto, bem como o valor final do salário líquido. O usuário pode optar por voltar ao menu inicial para inserir um novo valor de salário bruto, ou pode optar por exibir novamente o detalhamento do último cálculo realizado.

# Funções Adicionais

# Função Conversão de Salário de Cadeia para Real 
**Como funciona o programa**

O programa segue os seguintes passos para converter o salário de cadeia para real:

Recebe uma cadeia de caracteres contendo o valor do salário em formato de cadeia como entrada.

Cria uma variável **"salario_cadeia"** do tipo string e atribui a ela a cadeia de caracteres recebida como entrada.

Cria uma variável **"salario_real"** do tipo real.

Usa a função **"substituir" do objeto "t"** para substituir o caractere "," por "." na variável **"salario_cadeia".**

Usa a função **"cadeia_para_real"** do objeto "ti" para converter a variável **"salario_cadeia"** em um valor de salário em formato de número real.

Atribui o valor convertido para a variável "salario_real".

Retorna o valor de **"salario_real".**

# Função Voltar Menu
**Funcionamento**

O programa apresenta uma pergunta ao usuário: "Quer repetir esse programa(s)SIM/(n)NÃO:". O usuário pode digitar 's' para sim ou 'n' para não. Se a entrada do usuário for diferente de 's' ou 'n', o programa considera que o usuário digitou uma entrada inválida e repete a pergunta.

Se o usuário digitar 's', o programa retorna True e a ação é repetida. Se o usuário digitar 'n', o programa retorna False e a ação é encerrada.

O programa continuará perguntando ao usuário se ele deseja repetir a ação até que o usuário digite 'n' para sair.

# Função Finalizar Programa
Este programa tem como objetivo perguntar ao usuário se ele deseja mostrar o detalhamento e finalizar o programa ou não.

# Função Banco de Dados
O programa Cadeia Salário é um sistema que solicita informações pessoais do usuário, incluindo nome completo, telefone, e-mail, idade e CEP. Em seguida, ele realiza uma busca no serviço de consulta de CEP do site ViaCEP, com base no CEP informado, e separa os dados do endereço em diferentes variáveis.

**Como funciona**
Ao ser executado, o programa solicita ao usuário que informe seu nome completo, telefone, e-mail, idade e CEP. Em seguida, ele faz uma busca no serviço do ViaCEP para obter os dados do endereço correspondente ao CEP informado. A partir dos dados obtidos, o programa separa o endereço em diferentes variáveis, incluindo logradouro, complemento, bairro, localidade e UF.

Os dados do usuário e do endereço são armazenados em um arquivo de texto chamado **"banco de dados.txt"**, que é criado na pasta do programa. Se o arquivo já existir, o programa adicionará as informações do usuário como uma nova linha no final do arquivo.
# Função Fazer outro cadastro
Este programa permite que o usuário realize o cadastro de informações pessoais e de salário, além de possibilitar a escolha de finalizar o cadastro ou realizar um novo.

# Funçoes de Menu de Tela

# Funçao final
O programa será executado e exibirá a mensagem de agradecimento ao usuário.

# Função Menu
Este programa foi desenvolvido para calcular diversos cálculos de registro de funcionários, tais como INSS, IRPF, valor das férias, FGTS mensal, depósito do FGTS, seguro desemprego, vale transporte, PIS, adicional noturno, periculosidade, hora extra e salário líquido do final do mês.

# Função Seletor Programa 
Este programa é destinado a realizar o cálculo de diversos benefícios trabalhistas, tais como INSS, IRPF, férias, FGTS mensal, depósito de FGTS, seguro-desemprego, vale-transporte, PIS, adicional noturno, periculosidade e hora extra.

# Função Detalhamento
Este programa exibe os proventos e descontos do salário bruto do usuário e calcula o salário líquido mensal. Os proventos incluem hora extra, adicional noturno, periculosidade e depósito do FGTS. Já os descontos são referentes ao INSS, IRPF e vale transporte.


