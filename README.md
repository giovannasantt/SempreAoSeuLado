Feito por: Giovanna Santana e Guilherme Santos

# Sempre Ao Seu Lado - Documentação
<br>
<table>
  <tr>
    <td>
     <p>
Atividade realizada em sala de aula e continuada em casa, utilizando conhecimentos das matérias de: Lógica de Programação, TDDGA, POO. A atividade apresenta história e design inspirados na cena do trem, vista no filme "sempre ao seu lado", com o objetivo de recriar a mesma em formato de jogo eletrônico. A seguir, os conceitos de roteirização, execução, elementos gráficos e visuais serão explicados mais detalhadamente.
</p>
</td>
</table>
<br>

## História 

<p>A trama do filme aborda como é importante a ligação de lealdade entre o dono e seu cachorro. Na cena retratada, se torna ainda mais possível essa interpretação, onde a cena escolhida foi a da primeira fuga de Hachi até a estação, em busca de seu dono Parker, simbolizando o companheirismo e a falta que o cachorro sentiu ao ver a ausência de seu dono e ao encontrar com o mesmo, finalizando a cena com a felicidade e surpresa do dono ao ver a demonstração de afeto genuina vinda de Hachi. Na cena recriada, as cores predominantes são claras e saturadas, representando o conforto sentido pelos protagonistas no encontro inesperado e caloroso.
</p>

## Personagens

### Cachorro
![image](https://github.com/user-attachments/assets/36763142-4b40-40b6-a4c0-61d8192a0a41)
<p> Hachi é um dos principais protagonistas do filme e se faz presente na cena também, sendo ele o personagem que o player irá controlar. Com a grande característica de ser um ótimo companheiro e ser extremamente fiel ao seu dono, Hachi é quem da o ponto inicial para a cena. O cachorro utilizado no jogo tem a mesma aparência fisica do cachorro do filme, contendo cores vivas e claras, sendo utilizado um prefab gratuito encontrado na unity story.</p>


### Dono
![image](https://github.com/user-attachments/assets/733203d1-0567-48e4-9970-9709cd9e3205)

<p>Parker, o dono de Hachi, é junto com o cachorro o principal protagonista da trama, sendo ele a motivação para que o cachorro fugisse de casa, dando inicio à cena. O personagem utilizado no jogo se trata de um modelo genérico (porém muito semelhante ao dono original, contendo até mesmo uma paleta de cores semelhante) achado na asset story. </p>

### Figurantes
![image](https://github.com/user-attachments/assets/f344ba70-81d0-4d25-9479-16826e665908) ![image](https://github.com/user-attachments/assets/134962ef-98ab-41b1-b4b0-27cc527fa277)



<p>Os figurantes, nada mais são do que pessoas aleatórias presentes na cena com o objetivo de preencher espaço e influênciar na jogabilidade, uma vez que o player terá que desviar deles para chegar no objetivo final. Os modelos utilizados são prefabs genéricos encontrados na asset story.</p>
<br>

## Cenário
<p>O cenário é ambientado em uma estação de trem, com aparência rústica, assim como a utilizada na cena do filme (que tem inclusive locomotivas a vapor), iluminação com aspecto natural e claro, com cores claras e calmas (ornando com o sentido da cena, que tem como objetivo ser aconchegante ao telespectador). O modelo da estação foi encontrado na asset story e adaptado ao contexto do jogo, sendo retirados alguns elementos gráficos adicionais (algumas pilastras que não irão ser observadas na visão do jogador). </p>
<br>

## Cena
<p>A cena a ser recriada no jogo será a do segundo encontro entre Hachi e Parker na estação, onde o cachorro foge de sua casa em busca de encontrar seu dono. Primeiro será mostrada uma "cutscene" (feita em pixelart) com a cena em que Hachi cava um buraco e, a partir desse momento, o player começará a controlar o cachorro, percorrendo um caminho dentro da estação e desviando de NPCs, até ir de encontro a Parker, onde o player deixa de controlar o cachorro, chegando ao seu objetivo final e por fim aparecendo a imagem final de Hachi e Parker juntos e felizes. A paleta de cores da cena seguirá a mesma da cena original, tendo cores claras e vivas como predominantes. </p>

![Captura de tela 2024-11-28 215006](https://github.com/user-attachments/assets/9d95f9fa-d6b9-4328-93e9-1f132a8a047d)

<br>

## Jogabilidade

<p>A fase inicia-se com uma animação de Hachi cavando para conseguir fugir de casa, dando inicio a cena retratada, após isso o player terá que controlar o cachorro Hachi, andando por toda a estação, com o objetivo de encontrar o seu dono, com isso finalizando o jogo e alcançando sua "recompensa". Porém, Hachi terá que desviar de todos os figurantes presentes na estação, dificultando assim a chegada até seu dono, afinal, os figurantes andarão para ambos os lados. Caso Hachi não consiga desviar, o player terá que recomeçar a jornada desde o inicio da fase.</p>

### Telas


<p>No jogo, foram usadas 4 cenas no total, sendo elas: Inicio, Jogo, GameOver e a tela final (que aparece caso o player consiga cumprir a missão de chegar até ao dono sem bater em nenhum obstáculo). As telas de inicio, gameover e final executam práticamente as mesmas funções, apresentando 2 botões programados por tela, sendo: reiniciar, sair e voltar. Os botões foram programados com o objetivo de auxiliar a experiência do player, deixando-a mais fluida e agradável, contendo um design simples deito no app canva e imagens de fundo coerentes ao contexto dado pela tela. Enquanto as telas de inicio e final apresentam cores vivas e claras, para representar a alegria e companherismo do cachorro ao encontrar-se com seu dono, a tela de gameover contém cores menos saturadas e frias, representando a tristeza e solidão que Hachi sente na ausência de Parker.</p>

![Captura de tela 2024-11-28 214938](https://github.com/user-attachments/assets/59f97d30-006f-4065-a4de-3e0261384104)
![Captura de tela 2024-11-28 214923](https://github.com/user-attachments/assets/7796cc5c-a07f-47bf-a5c2-feb9da0cd6f3)
<br>

## Códigos

### Classes

- Personagem

![image](https://github.com/user-attachments/assets/a10bd499-f28a-4157-9d9d-71e475d3e0d4)

  <p> Essa é a nossa classe mãe, responsável por carregar os atributos principais. O primeiro atributos que criamos foi velocidade (float), o valor é responsável por determinar o quão rápido os personagens irão se mover, o próximo atributo é a posição (Vector3), usamos ele para determinar onde os personagens irão aparecer inicialmente, e se caso precisarem mudar de posição durante o jogo, por fim criamos o atributo modelo (tipo gameObject), ele serve para alterar o modelo da instância durante a execução.</p>
  <br>
  
- Cachorro

![image](https://github.com/user-attachments/assets/a979be2b-4752-45ac-ad28-309b4a34348e)

  <p>Essa classe é responsável por carregar os atributos e métodos de um cachorro. Além dos ex atributos, nós renomeamos o atributo gameObject com o nome ccachorro, e criamos um novo chamado vida (bool), ele servirá para contar se o cachorro está morto ou vivo, assim interagindo com a tela de derrota ou não, no fim também criamos uma variável pra contar quantas instâncias ocorreram, chamada InstanciasCachorro.
</p>
<br>

- Pessoas

  ![image](https://github.com/user-attachments/assets/95d4dc2e-7054-4e6d-a1c2-4fb302b8a111)

<p>Essa classe também carrega os mesmos atributos da classe personagem, a única mudanças é que também renomeamos o atributo gameObject para ppessoa.</p>
<br>

### Scripts

- Movimentação (anexado ao cachorro, que é o player)

![image](https://github.com/user-attachments/assets/7d3df443-43e7-4023-9b99-ad6279907c06)
![image](https://github.com/user-attachments/assets/d6e82438-4468-4589-8c5f-e4cedfdfb9d2)
![image](https://github.com/user-attachments/assets/1db984a0-b65f-4412-a60e-9c3a5962e3d7)


  <p>Primeiramente criamos uma variável posicao (Vector3) e uma personagem (que deriva de cachorro), no start definimos os valores iniciais de posicao e usamos o transform position para o personagem nascer na posição colocada no Vector3, além disso criamos uma instância inicial para o cachorro, definindo, transform position para a posicao, true para a vida e cachorro (variável que recebe o gameObject da cena que tem o nome Cachorro) para o gameObject e por fim a instância do modelo do cachorro, além contar quantas vezes foi instanciado e apresentar no debug.log. No update colocamos a velocidade dele na posição Z como fixa, e juntamente com o transform Translate ele se move constantemente, logo depois definimos as teclas que serviram para o seu movimento, no A ele anda para o eixo X para esquerda, no D é o eixo X para a direita, e o Espaço ele pula, se movendo no eixo Y, além de que fizemos um sistema de barreira, onde as teclas funcionam apenas se ele se mover dentro da área delimitada. No final fizemos um sistema de colisão usando um switch, se ele se colidir com um objeto com a tag pessoa, carrega a cena de derrota, mas se a colisão for com a tag dono, a cena que se carrega é a de vitória, além de destruir a si próprio e apresentar no debug.log se colidiu ou não.</p>
  <br>

- NPC (anexado as pessoas, que são nossos obstáculos)

![image](https://github.com/user-attachments/assets/fa3fdf71-e389-4914-ac7f-72ea4de632f9)

  <p>Esse script serve para instânciar o objeto da nossa classe, igual no script do cachorro, criamos variáveis para a posição (Vector3), gameObject, pessoa e um gerador aleatório. No start usamos o debug.log para falar falar quantas instâncias aconteram assim que o jogo inicou, já no update fizemos a instacia dos objetos e modelos, porém usamos a variável aleatório que vai de 1 a 3 (o último número não conta, então é tecnicamente de 1 a 2), se for 1, usamos a concatenação da variável com o nome pessoa para colocar o modelo 1, e se for 2, o outro modelo, além disso criamos um limite de nascimento, se o número de objetos instanciados for menor que 5, ele continuará instanciando, se for maior ele para, sendo assim essa parte converge com a do script Velocidade.</p>
  <br>

- Velocidade (também anexado as pessoas)

![image](https://github.com/user-attachments/assets/2074869e-3887-443a-a1cc-3c13c4f87bbe)

  <p>Criamos uma variável velocidade (Vector3) e zeramos seus valores no start, no update deixamos sua movimentação no eixo Z constante igual ao do cachorro, e criamos uma condicional, se o objeto estiver dentro do limite permitido, ele continuará se movendo, se não estiver E a instância for igual a 4, ele subtrai 1 das instâncias e destrói o objeto, assim ele deixa de existir</p>
<br>



link do arquivo - https://drive.google.com/drive/folders/1Aopy64-GdMkqRlB0Wp0ojxIy9ly1U_fj?usp=sharing

