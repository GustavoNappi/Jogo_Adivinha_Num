# Jogo de Adivinhação em C#

Este é um simples jogo de adivinhação de números implementado em C#. O jogador deve tentar adivinhar um número aleatório gerado pelo programa dentro de um intervalo específico.

## Funcionalidades

- **Boas-vindas:** O programa inicia com uma saudação de boas-vindas.
- **Informações do Programa:** Exibe o ano de desenvolvimento do programa.
- **Jogo de Adivinhação:** O jogador é solicitado a adivinhar um número dentro de um intervalo especificado.
- **Feedback de Adivinhação:** O jogador recebe feedback se sua tentativa é muito alta ou muito baixa em relação ao número a ser adivinhado.
- **Vitória:** Quando o jogador adivinha corretamente, o programa informa o número correto e o número de tentativas.
- **Opção de Jogar Novamente:** O jogador pode optar por jogar novamente ou encerrar o programa.
- **Encerramento:** O programa agradece ao jogador por jogar antes de sair.

## Descrição Técnica

- Utiliza a classe `Random` para gerar números aleatórios.
- Utiliza um loop `while` para permitir que o jogador jogue várias vezes.
- Utiliza declarações condicionais `if` e `else if` para fornecer feedback ao jogador.
- Converte entradas de texto em números usando `Convert.ToInt32()`.
- Usa uma variável de controle (`JogarNovamente`) para determinar se o jogo continua ou termina.

## Autor

- **Gustavo Souza Nappi**: Responsável pelo desenvolvimento do jogo.

## Como Jogar

1. Execute o programa.
2. Será exibido um número aleatório dentro de um intervalo especificado.
3. Insira um número para tentar adivinhar.
4. O programa fornecerá feedback se o número inserido for muito alto ou muito baixo.
5. Continue tentando até adivinhar corretamente.
6. Após vencer, você terá a opção de jogar novamente ou encerrar o programa.

Divirta-se jogando!
