namespace Boss_final;

/*
    CONSIGNES
    Vous développez le système de combat d'un RPG. Le héros affronte un boss final.

    Le boss possède 150 PV. Le héros possède une arme qui inflige 40 dégâts par attaque.

    Vous devez créer trois méthodes :

    1. CalculateWeaponDamage()
        - Reçoit la puissance de l'arme en paramètre.
        - Retourne les dégâts infligés (ici, la puissance de l'arme).
    2. CalculateRemainingHealth()
        - Reçoit les PV actuels du boss et les dégâts infligés.
        - Calcule les nouveaux PV du boss.
        - Retourne les nouveaux PV.
    3. DisplayBossStatus()
        - Reçoit les PV du boss.
        - Affiche son état :
        - Si ses PV sont supérieurs à 0 : "Le boss est toujours vivant !".
        - Sinon : "Félicitations ! Le boss est vaincu !".
    Dans Main() :
        1. Initialisez les PV du boss à 150.
        2. Calculez les dégâts de l'arme.
        3. Infligez les dégâts au boss.
        4. Affichez son état.
        5. Recommencez une deuxième attaque.
        6. Affichez à nouveau son état.
    BONUS :
        - Inspirez-vous de votre combat du cours de Logique & Algorithmes pour aller plus loin dans cet exercice
 */
class Program
{
    public static int weaponDamage;
    public static int Bosshealth ;
    
    public static void CalculateWeaponDamage()
    {
        weaponDamage = 40;
        Console.WriteLine(weaponDamage + " Dégats infligés");
    }

    public static void CalculateRemaininghealth()
    {
        Bosshealth -= weaponDamage;
        Console.WriteLine(" Le boss est à " + Bosshealth + " PV");
        
    }

    public static void DisplayBossstatus()
    {
        if (Bosshealth <= 0)
        {
            Console.WriteLine("Félicitations, le boss est vaincu !");
        }
        else
        {
            Console.WriteLine("Le boss est toujours vivant !");
        }
    }
    static void Main(string[] args)
    {
        Bosshealth = 150;
        CalculateWeaponDamage();
        CalculateRemaininghealth();
        DisplayBossstatus();
        CalculateWeaponDamage();
        CalculateRemaininghealth();
        DisplayBossstatus();
    }
}