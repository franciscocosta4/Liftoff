

# Liftoff - Immersive Study Sessions

> Plataforma de sessões de estudo imersivas com ambiente de voo, mapa de lugares em tempo real e sincronização social.

## Sobre o Projeto

**Liftoff** é uma aplicação web criada para proporcionar uma experiência de estudo focada e colaborativa.
A aplicação transforma uma sessão de estudo tradicional numa viagem virtual, onde os utilizadores entram numa cabine de estudo, escolhem um lugar, activam ambientes sonoros e acompanham uma sessão com duração definida até à "aterragem".
O projeto combina produtividade, experiência imersiva e funcionalidades em tempo real utilizando comunicação por WebSockets.

---

## Stack

### Backend

![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=csharp&logoColor=white) 
![Postgres](https://img.shields.io/badge/postgres-%23316192.svg?style=for-the-badge&logo=postgresql&logoColor=white)

### Frontend

![CSS](https://img.shields.io/badge/css-%23663399.svg?style=for-the-badge&logo=css&logoColor=white) 
![HTML5](https://img.shields.io/badge/html5-%23E34F26.svg?style=for-the-badge&logo=html5&logoColor=white)

---

## Funcionalidades Principais

### Sessões de Estudo

- Criação de sessões com duração configurável;
- Temporizador global sincronizado;
- Gestão do estado da sessão:
  - Preparação;
  - Em voo;
  - Aterragem concluída.

---

### Mapa de Lugares em Tempo Real

- Representação visual da cabine;
- Visualização dos lugares disponíveis;
- Escolha e reserva de lugares;
- Actualização imediata quando um lugar é ocupado;
- Prevenção de conflitos entre utilizadores.

---

### Sincronização em Tempo Real

Comunicação através de WebSockets para manter todos os participantes sincronizados:

- Entrada e saída de utilizadores;
- Actualização do mapa de lugares;
- Sincronização do temporizador;
- Alterações do estado da sessão.

---

### Áudio Ambiente

Integração com Web Audio API para criar ambientes de concentração:

- Sons de cabine de avião;
- Ruído ambiente;
- Sons personalizados;
- Controlo de reprodução pelo utilizador.

---

### Presença Social

Os participantes conseguem visualizar:

- Utilizadores presentes na sessão;
- Lugares ocupados;
- Estado da sessão;
- Número de participantes activos.

---

## Possíveis Melhorias

### Estatísticas de Estudo

Adicionar métricas de utilização:

- Tempo total estudado;
- Número de sessões concluídas;
- Histórico de estudo;
- Análise de produtividade.

---

### Streaks

Sistema de continuidade:

- Dias consecutivos de estudo;
- Objectivos pessoais;
- Recompensas por consistência.

---

### Ranking

Sistema competitivo:

- Ranking baseado no tempo estudado;
- Desafios entre utilizadores;
- Tabelas de classificação.
