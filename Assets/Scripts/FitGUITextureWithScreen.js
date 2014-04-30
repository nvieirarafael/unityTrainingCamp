#pragma strict

function Start () {
  var gui : GUITexture = GetComponent(GUITexture);
  var screenWidth : float = Screen.width + 4;
  var screenHeight : float = Screen.height + 4;

  gui.pixelInset.width = screenWidth;
  gui.pixelInset.height = screenHeight;

  gui.pixelInset.x = 0;
  gui.pixelInset.y = 0;
}