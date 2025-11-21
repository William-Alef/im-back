Requisitos solicitados:

# 1. Modelagem e Classes Base

* Criação de classes **"Música"** com propriedades para título, artista e duração.
* Criação de classes **"Playlist"** e **"Artista"** com propriedades adequadas.
* Implementação de objetos com dados exemplares.

# 2. Gerenciamento de Playlist

* Adição de músicas à "Playlist" usando um método específico.
* Implementação das interfaces **"ICollection"** e **"IEnumerable"** na "Playlist".
* Desenvolvimento de um método para exibir a "Playlist" no console com interpolação.
* Criação de um método para obter uma música pelo título na "Playlist".
* Implementação de um método para remoção de uma música.
* Criação de um método para tocar uma música aleatória usando a classe **"Random"**, verificando se a lista não está vazia.
* Utilização de um **"HashSet"** auxiliar para impedir **músicas duplicadas** na "Playlist".
* Sobrescrita dos métodos **"Equals" e "GetHashCode"** na classe "Música" para comparação adequada.

# 3. Ordenação

* Implementação da interface **"IComparable"** na classe "Música" para comparação por duração.
* Criação de classes comparadoras **"IComparer"** para ordenar por artista e por título.
* Implementação de métodos na "Playlist" para realizar a ordenação usando os comparadores criados.

# 4. Análise de Dados

* Criação de um **"Dictionary"** para contabilizar quantas vezes cada música aparece nas playlists ("Ranking").
* Implementação de um serviço para agregar e exibir o ranking de músicas mais tocadas.

# 5. Player de Música

* Construção de um **Player de Música** com fila de reprodução (**"Queue"**) e histórico (**"Stack"**) para gerenciar as músicas tocadas.
