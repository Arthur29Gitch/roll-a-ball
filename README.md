# Projeto Roll-a-balll

Aluno: Arthur Rodrigues dos Santos
Turma: 2026.29.09
Feito com:Unity 6 e C### 
Sobre o projeto: O jogador movimenta a bolinha(personagem), por um pequeno labirinto, coletando alguns quadrados vermelhos no caminho, precisando ter todos para ganhar o jogo.
O que o projeto faz: O jogador movimenta a bolinha(personagem) com as setas/WASD e quando colide com os quadradinhos, ele os coleta e adiciona na pontuação, aparece a mensagem de vitória ao coletar todos.
Cenas: Labirinto, vários blocos juntos em um formando um labirinto. 
Scripts: 
GerenciadorDeJogo: define todo o sistema de contagem de pontos.
PlayerController: define teclas de movimento e salto, junto a isso define velocidade de rolagem, além disso define condição de vitória 
Rotate: faz objetos coletáveis ficarem rodando 
Coletavel: quando identifica colisão deleta o coletavel
CameraFollow: faz a câmera acompanhar o jogador
Objetos principais:  
**TaikaWaititi**(jogador) 
chão(colisor do chão)
blocos: Conjunto de blocos e cores para o cenário(colisão)
quadradinhos(coletavel)
Diretional light(luz para o cenário)
MainCamera(uma câmera que segue o jogador)
Canva: usado para textos e pontuação (gerenciador de jogo para auxiliar)
Recursos usados: Rigidbody, Collider com Is Trigger, mesh collider, capsule collider, box collider, character controler, camera light
Controles: WASD para mover o personagem.

O que eu aprendi: Muita coisa, mas mais sobre c## e modelação.
## Como abrir
Baixe o projeto, abra o Unity Hub, clique em **Add** e escolha a pasta do projeto.
