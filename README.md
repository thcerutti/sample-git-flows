# Fluxo básico de branches no GIT

Nossa branch inicial é a `main`. A partir desta branch criaremos a branch `develop`, e a partir delas criaremos as demais `feature branches` (cada feature será implementada em uma branch).

```
 main
  │
  ├───►develop
  │       ├───►feature branch
  │       │          │
  │       │◄─────────┘
  │◄──────┤
  │prod.  │
  │deploy │
  │       │
```

Automações na pipeline garantem que tudo o que entrar na branch `main` deve ir para produção, portanto precisamos da branch `develop` para "represar" as implementações, testar a integrações entre as implementações, e só depois geramos uma versão que vai para a produção (`develop` -> `main`).

## Resolução de conflitos

Um conflito ocorre quando um mesmo trecho de código é alterado em mais de uma branch. Quando isso ocorre fazemos um `merge`, que consiste em pegar as alterações que vem de fora (`incoming`) e as alterações que fizemos na nossa branch (`current`) e verificar o que deve ser considerado como código final. Chamamos isso de "resolver os conflitos do merge".