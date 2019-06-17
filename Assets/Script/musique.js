#pragma strict


var MusicEnable : boolean = true;   //Quand la variable boolean est sur true => musique activée

var MusicGameObject : GameObject;   //Variable qui va prendre une forme laquelle on va glisser ce qu'on veux activer/désactiver. 
 




function MUSIC_ENABLE() // quand on va appeler cette fonction la variable boolean va passer de true à false et inversement.
{

MusicEnable = !MusicEnable;

}



function Update() // fonction 
{
if(MusicEnable == true)
  {


MusicGameObject.SetActive(true);

  }



else
  {


MusicGameObject.SetActive(false);

  }


}



function QUIT_GAME()
{

Application.Quit();

}