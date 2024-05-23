using UnityEngine;

[CreateAssetMenu(fileName = "InfosJoueur", menuName = "SO/Nouveaujoueur")]

public class InfosJoueur : ScriptableObject
{
    public string nomJoueur;
    public string nomEnvironnement;

    public int score;
    
    public int nbrVie;
}
