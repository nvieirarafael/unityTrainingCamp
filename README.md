Unity3D Training Camp
=================

Repositório para testes de funcionalidades e plugins do **Unity3D 4.3.4**


### Plugins

1. **Scene Sync**
2. **2D Platform Controller**
		
	* Na scene _2DPlatformControllerUsingPS3Control.unity_ utilizei o InputManager para mapear os botões do controle de playstation3.    
	(Para acessar o InputManager navegue em Edit->Project Settings->Input).   	
	![image](https://raw.githubusercontent.com/nvieirarafael/unityTrainingCamp/master/ReadmeFiles/InputManager.png)   	
	E assim adaptei a classe SimpleCharacterInput.cs para a MySimpleCharacterInput.cs que utiliza funções como **Input.GetButton()**, **Input.GetButtonDown()**, **Input.GetAxis()** me permitindo configurar mais de um botão (key) para a mesma ação. (Observe que no InputManager existem configurações para o teclado e para joystick com nomes iguais como "Jump", "Horizontal").



3. **Ferr2D Terrain Tool**

	* Na scene _2DPlatformControllerUsingPS3Control.unity_ adicionei plataformas utilizando o plugin. Bem fácil de usar! :D
	* Ele possui um editor de terrenos para mapear o .png do terreno antes de usar.