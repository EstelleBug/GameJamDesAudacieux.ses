using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DaddyDialogues : MonoBehaviour
{
    //Dialogues N�gatifs
    public const string Truth1 = "Les gens qui saisissent pas les opportunit�s �a r�ussit pas dans la vie, tu sais.";
    public const string Truth2 = "Crois-en mon exp�rience, dans le doute, il faut toujours dire oui.";
    public const string Truth3 = "Se r�orienter � ton �ge, c'est pas raisonnable. Tu ferais mieux de rester dans le commerce.";
    public const string Truth4 = "Com�dienne ! Mais c'est un m�tier de ch�meurs et de communistes !";
    public const string Truth5 = "Tu ne le sais sans doute pas mais seuls 5% des gens r�ussissent dans ce m�tier. Alors moi, je n'y crois pas trop.";
    public const string Truth0 = "Tu as rappel� pour le boulot que je t'ai trouv� dans l'entreprise de Frank?";
    public const string Truth01 = "  ";

    public const string Opinion1 = "Moi � ta place, je foncerais !�Ne le fais pas trop attendre.";
    public const string Opinion2 = "T'as pas besoin d'�tre s�re, fais-le, c'est la bonne chose � faire.";
    public const string Opinion3 = "Moi je les vois � la t�l� les gens qui changent de travail,�c'est pas une bonne id�e.�";
    public const string Opinion4 = "C'est pas s�rieux enfin ! C'est un hobbie, pas un m�tier !";
    public const string Opinion5 = "Ce qui est s�r, c'est que si tu persistes tu ne vas r�ussir � rien. Arr�te tes conneries et rappelle Frank ! L� tu vas gagner de l'argent !";

    public const string Guilt1 = "D�p�che-toi, c'est un bon poste, j'ai d� graisser des pattes pour te l'avoir.";
    public const string Guilt2 = "L�, tu d�connes ! C'est une opportunit� en or ! Pense un peu � nous, pense � ta m�re !";
    public const string Guilt3 = "Arr�te tes �tats d'�me ! On est pas venus jusqu'ici, � s'�chiner au travail toutes ces ann�es pour vous, tout �a pour que tu d�cides de g�cher ta vie !";
    public const string Guilt4 = "Tout mais pas �a ! Tu veux tuer ta m�re, c'est �a ? Elle qui a travaill� dur ! Elle s'est priv�e pour toi !";
    public const string Guilt5 = "15 ans que je trime � faire la caisse, le bricolage, le taxi. Tu crois que j'ai r�ussi moi ?�";

    public const string Deny1 = "Pas le temps, pas le temps� Tss. Aller au cin�ma, �a tu as bien le temps par contre.";
    public const string Deny2 = "Ah non, �a suffit de tergiverser comme �a. Serre les dents un bon coup, et rappelle-le !";
    public const string Deny3 = "Mais non. Tu doutes juste, �a te passera.�";
    public const string Deny4 = "Ce sont des lubies. Je suis ton p�re, je sais mieux que toi ce qui est bon. Tu dois faire ce que je te dis.";
    public const string Deny5 = "Moi ce que je sens, c'est qu'on va te r�cup�rer � la rue dans 3 ans.";

    public const string Keep1 = "Bla bla bla bla";
    public const string Keep2 = "Bla bla";
    public const string Keep3 = "Bla bla bla";
    public const string Keep4 = "Bla bla bla bla bla bla bla";
    public const string Keep5 = "Blah";

    public const string End1 = "Comment �a c'est pas ce que tu veux faire ? Tu dis n'importe quoi. Allez, tu rappelles maintenant.";
    public const string End2 = "Transmettre des histoires ? C'est toi qui m'en fais l� ! C'est non, tu continues en commerce un point c'est tout.";
    public const string End3 = "Non. Non, c'est vou� � l'�chec, on va pas jeter des ann�es d'efforts pour tes caprices.";

    //Dialogues Positifs
    public const string TruthP1 = "Les gens qui saisissent pas les opportunit�s �a r�ussit pas dans la vie, tu sais.";
    public const string TruthP2 = "Crois-en mon exp�rience, dans le doute, il faut toujours dire oui.";
    public const string TruthP3 = "Se r�orienter � ton �ge, c'est pas raisonnable. Tu ferais mieux de rester dans le commerce.";
    public const string TruthP4 = "Com�dienne ! Mais c'est un m�tier de ch�meurs et de communistes !";
    public const string TruthP5 = "Tu ne le sais sans doute pas mais seuls 5% des gens r�ussissent dans ce m�tier. Alors moi, je n'y crois pas trop.";

    public const string OpinionP1 = "Oui";
    public const string OpinionP2 = "C bieng";
    public const string OpinionP3 = "Carr�ment";
    public const string OpinionP4 = "GG ma fille";
    public const string OpinionP5 = "Is ok l'art";

    public const string GuiltP1 = "D�p�che-toi, c'est un bon poste, j'ai d� graisser des pattes pour te l'avoir.";
    public const string GuiltP2 = "L�, tu d�connes ! C'est une opportunit� en or ! Pense un peu � nous, pense � ta m�re !";
    public const string GuiltP3 = "Arr�te tes �tats d'�me ! On est pas venus jusqu'ici, � s'�chiner au travail toutes ces ann�es pour vous, tout �a pour que tu d�cides de g�cher ta vie !";
    public const string GuiltP4 = "Tout mais pas �a ! Tu veux tuer ta m�re, c'est �a ? Elle qui a travaill� dur ! Elle s'est priv�e pour toi !";
    public const string GuiltP5 = "15 ans que je trime � faire la caisse, le bricolage, le taxi. Tu crois que j'ai r�ussi moi ?�";

    public const string DenyP1 = "Pas le temps, pas le temps� Tss. Aller au cin�ma, �a tu as bien le temps par contre.";
    public const string DenyP2 = "Ah non, �a suffit de tergiverser comme �a. Serre les dents un bon coup, et rappelle-le !";
    public const string DenyP3 = "Mais non. Tu doutes juste, �a te passera.�";
    public const string DenyP4 = "Ce sont des lubies. Je suis ton p�re, je sais mieux que toi ce qui est bon. Tu dois faire ce que je te dis.";
    public const string DenyP5 = "Moi ce que je sens, c'est qu'on va te r�cup�rer � la rue dans 3 ans.";

    public const string KeepP1 = "�coute, ma fille :";
    public const string KeepP2 = "D�j� :";
    public const string KeepP3 = "Voil� ce que tu vas faire :";
    public const string KeepP4 = "Primo :";
    public const string KeepP5 = "Alors :";

    public const string EndP1 = "Comment �a c'est pas ce que tu veux faire ? Tu dis n'importe quoi. Allez, tu rappelles maintenant.";
    public const string EndP2 = "Transmettre des histoires ? C'est toi qui m'en fais l� ! C'est non, tu continues en commerce un point c'est tout.";
    public const string EndP3 = "Non. Non, c'est vou� � l'�chec, on va pas jeter des ann�es d'efforts pour tes caprices.";
}