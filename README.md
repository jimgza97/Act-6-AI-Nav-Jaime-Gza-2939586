Proyecto de Navegación con NavMesh y Input System
📌 Descripción
Este proyecto en Unity implementa un sistema de navegación basado en NavMesh y Input System, donde el jugador controla un NavMeshAgent haciendo clic en el suelo con el mouse. El agente esquiva obstáculos y puede moverse entre diferentes plataformas utilizando un NavMeshLink.

🎮 Funcionamiento del Proyecto
Escena en 3D

El entorno contiene un suelo navegable y varios obstáculos (paredes, postes, etc.).
Se ha generado un espacio flotante que está conectado al suelo mediante un NavMeshLink.
Control del Agente

Un NavMeshAgent (representado por una cápsula) se mueve en el entorno.
Se utiliza Raycasting para detectar dónde ha hecho clic el jugador.
Si el jugador hace clic en una superficie válida (definida por un LayerMask), el agente se moverá a esa posición.
El agente evita obstáculos automáticamente gracias al NavMesh.
🛠️ Tecnologías Utilizadas
Unity 2022+
NavMesh (AI Navigation)
Input System
C# (Scripting)
🚀 Cómo Jugar
Ejecuta el proyecto en Unity.
Haz clic en cualquier parte del suelo para mover al agente.
Observa cómo el agente esquiva los obstáculos y usa el NavMeshLink para moverse entre plataformas.
