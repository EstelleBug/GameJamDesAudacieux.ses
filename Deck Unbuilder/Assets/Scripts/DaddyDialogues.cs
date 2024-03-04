using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DaddyDialogues : MonoBehaviour
{
    //Dialogues Négatifs
    public const string Truth1 = "Les gens qui saisissent pas les opportunités ça réussit pas dans la vie, tu sais.";
    public const string Truth2 = "Crois-en mon expérience, dans le doute, il faut toujours dire oui.";
    public const string Truth3 = "Se réorienter à ton âge, c'est pas raisonnable. Tu ferais mieux de rester dans le commerce.";
    public const string Truth4 = "Comédienne ! Mais c'est un métier de chômeurs et de communistes !";
    public const string Truth5 = "Tu ne le sais sans doute pas mais seuls 5% des gens réussissent dans ce métier. Alors moi, je n'y crois pas trop.";
    public const string Truth0 = "Tu as rappelé pour le boulot que je t'ai trouvé dans l'entreprise de Frank?";
    public const string Truth01 = "  ";

    public const string Opinion1 = "Moi à ta place, je foncerais ! Ne le fais pas trop attendre.";
    public const string Opinion2 = "T'as pas besoin d'être sûre, fais-le, c'est la bonne chose à faire.";
    public const string Opinion3 = "Moi je les vois à la télé les gens qui changent de travail, c'est pas une bonne idée. ";
    public const string Opinion4 = "C'est pas sérieux enfin ! C'est un hobbie, pas un métier !";
    public const string Opinion5 = "Ce qui est sûr, c'est que si tu persistes tu ne vas réussir à rien. Arrête tes conneries et rappelle Frank ! Là tu vas gagner de l'argent !";

    public const string Guilt1 = "Dépêche-toi, c'est un bon poste, j'ai dû graisser des pattes pour te l'avoir.";
    public const string Guilt2 = "Là, tu déconnes ! C'est une opportunité en or ! Pense un peu à nous, pense à ta mère !";
    public const string Guilt3 = "Arrête tes états d'âme ! On est pas venus jusqu'ici, à s'échiner au travail toutes ces années pour vous, tout ça pour que tu décides de gâcher ta vie !";
    public const string Guilt4 = "Tout mais pas ça ! Tu veux tuer ta mère, c'est ça ? Elle qui a travaillé dur ! Elle s'est privée pour toi !";
    public const string Guilt5 = "15 ans que je trime à faire la caisse, le bricolage, le taxi. Tu crois que j'ai réussi moi ? ";

    public const string Deny1 = "Pas le temps, pas le temps… Tss. Aller au cinéma, ça tu as bien le temps par contre.";
    public const string Deny2 = "Ah non, ça suffit de tergiverser comme ça. Serre les dents un bon coup, et rappelle-le !";
    public const string Deny3 = "Mais non. Tu doutes juste, ça te passera. ";
    public const string Deny4 = "Ce sont des lubies. Je suis ton père, je sais mieux que toi ce qui est bon. Tu dois faire ce que je te dis.";
    public const string Deny5 = "Moi ce que je sens, c'est qu'on va te récupérer à la rue dans 3 ans.";

    public const string Keep1 = "Bla bla bla bla";
    public const string Keep2 = "Bla bla";
    public const string Keep3 = "Bla bla bla";
    public const string Keep4 = "Bla bla bla bla bla bla bla";
    public const string Keep5 = "Blah";

    public const string End1 = "Comment ça c'est pas ce que tu veux faire ? Tu dis n'importe quoi. Allez, tu rappelles maintenant.";
    public const string End2 = "Transmettre des histoires ? C'est toi qui m'en fais là ! C'est non, tu continues en commerce un point c'est tout.";
    public const string End3 = "Non. Non, c'est voué à l'échec, on va pas jeter des années d'efforts pour tes caprices.";

    //Dialogues Positifs
    public const string TruthP1 = "Les gens qui saisissent pas les opportunités ça réussit pas dans la vie, tu sais.";
    public const string TruthP2 = "Crois-en mon expérience, dans le doute, il faut toujours dire oui.";
    public const string TruthP3 = "Se réorienter à ton âge, c'est pas raisonnable. Tu ferais mieux de rester dans le commerce.";
    public const string TruthP4 = "Comédienne ! Mais c'est un métier de chômeurs et de communistes !";
    public const string TruthP5 = "Tu ne le sais sans doute pas mais seuls 5% des gens réussissent dans ce métier. Alors moi, je n'y crois pas trop.";

    public const string OpinionP1 = "Oui";
    public const string OpinionP2 = "C bieng";
    public const string OpinionP3 = "Carrément";
    public const string OpinionP4 = "GG ma fille";
    public const string OpinionP5 = "Is ok l'art";

    public const string GuiltP1 = "Dépêche-toi, c'est un bon poste, j'ai dû graisser des pattes pour te l'avoir.";
    public const string GuiltP2 = "Là, tu déconnes ! C'est une opportunité en or ! Pense un peu à nous, pense à ta mère !";
    public const string GuiltP3 = "Arrête tes états d'âme ! On est pas venus jusqu'ici, à s'échiner au travail toutes ces années pour vous, tout ça pour que tu décides de gâcher ta vie !";
    public const string GuiltP4 = "Tout mais pas ça ! Tu veux tuer ta mère, c'est ça ? Elle qui a travaillé dur ! Elle s'est privée pour toi !";
    public const string GuiltP5 = "15 ans que je trime à faire la caisse, le bricolage, le taxi. Tu crois que j'ai réussi moi ? ";

    public const string DenyP1 = "Pas le temps, pas le temps… Tss. Aller au cinéma, ça tu as bien le temps par contre.";
    public const string DenyP2 = "Ah non, ça suffit de tergiverser comme ça. Serre les dents un bon coup, et rappelle-le !";
    public const string DenyP3 = "Mais non. Tu doutes juste, ça te passera. ";
    public const string DenyP4 = "Ce sont des lubies. Je suis ton père, je sais mieux que toi ce qui est bon. Tu dois faire ce que je te dis.";
    public const string DenyP5 = "Moi ce que je sens, c'est qu'on va te récupérer à la rue dans 3 ans.";

    public const string KeepP1 = "Écoute, ma fille :";
    public const string KeepP2 = "Déjà :";
    public const string KeepP3 = "Voilà ce que tu vas faire :";
    public const string KeepP4 = "Primo :";
    public const string KeepP5 = "Alors :";

    public const string EndP1 = "Comment ça c'est pas ce que tu veux faire ? Tu dis n'importe quoi. Allez, tu rappelles maintenant.";
    public const string EndP2 = "Transmettre des histoires ? C'est toi qui m'en fais là ! C'est non, tu continues en commerce un point c'est tout.";
    public const string EndP3 = "Non. Non, c'est voué à l'échec, on va pas jeter des années d'efforts pour tes caprices.";
}