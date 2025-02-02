# plinko

LOS CODIGOS ESTAN EN LA CARPETA ASESST RandomSpawn y ZonaPuntos


📌 Reglas del Juego
1️⃣ Presiona ESPACIO para soltar la pelota desde la parte superior.
2️⃣ La pelota rebotará en los tubos de la pirámide.
3️⃣ Al final, caerá en una caja de colores.
4️⃣ Cada caja tiene una puntuación diferente:
5️⃣ La puntuación aparecerá en la consola al tocar una caja.

FUNCIONAMIENTO EN C#   
El primer código utiliza las variables `xrango` y `yrango` para definir el rango dentro del cual la pelota puede aparecer al inicio del juego. `posicionrandom` almacena la posición aleatoria generada para la pelota, asegurando que cada vez que el jugador inicie la partida, la pelota caiga desde un punto distinto dentro del rango permitido. En el método `Update`, se verifica si el jugador presiona la tecla espacio, y si lo hace, se usa `SceneManager.LoadScene(0)` para reiniciar el juego y generar una nueva posición aleatoria para la pelota.  

El segundo código tiene una variable estática `score` que guarda la puntuación total del jugador y se mantiene durante la partida. Dentro del método `OnTriggerEnter2D`, cuando la pelota toca una caja de puntuación, se usa la variable `puntos` para almacenar la cantidad de puntos que otorgará esa caja, dependiendo de su etiqueta. Luego, los puntos se suman a `score`, actualizando la puntuación total del jugador. Finalmente, se imprime en la consola cuántos puntos se ganaron y cuántos tiene acumulados en total.
