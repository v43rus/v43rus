using System;

// VARIABLER
Random slumpatTal = new Random();
int menyVal;
char spelVal = 'j';
char spelaIgen = 'j';
string senasteVinnare = "ingen";
int spelarensPoäng = 0;
int datornsPoäng = 0;
bool nyttSpel = true;
bool dinTur = true;
bool rundaSlut = false;

// MENY
Reset();
Main();

void Main()
{
    Console.WriteLine("Välkommen till 21:an!");
    Console.WriteLine("");
    Console.WriteLine("Välj ett av följande alternativ:");
    Console.WriteLine("1. Spela nytt spel");
    Console.WriteLine("2. Visa senaste vinnare");
    Console.WriteLine("3. Spelets regler");
    Console.WriteLine("4. Avsluta spel");
    menyVal = int.Parse(Console.ReadLine());
    MenyVal();
}

void MenyVal()
{
    switch (menyVal)
    {
        case 1:
            NyttSpel();
            break;
        case 2:
            SenasteVinnare();
            break;
        case 3:
            SpeletsRegler();
            break;
        case 4:
            AvslutaSpel();
            break;
        default:
            Console.Clear();
            Console.Write("Felaktigt menyval, försök igen.");
            Main();
            break;
    }
}

void NyttSpel()
{
    // INITIALISERING SPEL
    if (nyttSpel)
    {
        spelarensPoäng += slumpatTal.Next(1, 11);
        datornsPoäng += slumpatTal.Next(1, 11);
        nyttSpel = false;
    }
    Console.Clear();
    RundaRecap();

    // DIN TUR
    if (dinTur)
    {
        if (spelVal == 'j' && dinTur)
        {
            spelarensPoäng += slumpatTal.Next(1, 11);
            NyttSpel();
        }
        else if (spelVal == 'n')
        {
            dinTur = false;
            NyttSpel();
        }
        else
        {
            Console.WriteLine("Felaktig input, försök igen");
            NyttSpel();
        }
    }
    // DATORNS TUR
    if (!dinTur && datornsPoäng < 16)
    {
        datornsPoäng += slumpatTal.Next(1, 11);
        NyttSpel();
        Console.WriteLine($"{datornsPoäng}");
    }
    else
    {
        rundaSlut = true;
        RundaRecap();
    }
}

void RundaRecap()
{
    // SPELARCHECK
    if (spelarensPoäng > 21)
    {
        Console.WriteLine($"Du är tjock({spelarensPoäng}), tyvärr");
        Console.WriteLine("");
        senasteVinnare = "Datorn";
        SpelaIgen();
    }
    else if (spelarensPoäng == 21)
    {
        Console.WriteLine("Du fick 21 och vann grattis!");
        Console.WriteLine("");
        senasteVinnare = "Du";
        SpelaIgen();
    }
    else if (spelarensPoäng < 21 && dinTur)
    {
        Console.WriteLine("");
        Console.WriteLine($"Du har {spelarensPoäng} poäng");
        Console.WriteLine($"Datorn har {datornsPoäng} poäng");
        Console.WriteLine($"Vill du dra ett kort till? (j/n)");
        spelVal = Console.ReadLine()[0];
    }

    // DATORCHECK
    if (rundaSlut)
    {
        if (datornsPoäng >= spelarensPoäng && datornsPoäng <= 21)
        {
            Console.WriteLine($"Datorn fick {datornsPoäng} och du har {spelarensPoäng}");
            Console.WriteLine("Du förlorade, tyvärr");
            senasteVinnare = "Datorn";
            SpelaIgen();
        }
        else if (datornsPoäng < spelarensPoäng)
        {
            Console.WriteLine($"Datorn fick {datornsPoäng} och du har {spelarensPoäng}");
            Console.WriteLine("Du vann grattis!");
            senasteVinnare = "Du";
            SpelaIgen();
        }
        else
        {
            Console.WriteLine($"Datorn fick {datornsPoäng} och du har {spelarensPoäng}");
            Console.WriteLine("Du vann grattis!");
            senasteVinnare = "Du";
            SpelaIgen();
        }
    }
}

void Reset()
{
    nyttSpel = true;
    dinTur = true;
    rundaSlut = false;
    datornsPoäng = 0;
    spelarensPoäng = 0;
    Console.Clear();
}

void SenasteVinnare()
{
    Console.Clear();
    Console.WriteLine($"{senasteVinnare} vann det förra spelet");
    Console.WriteLine("");
    Main();
}

void SpeletsRegler()
{
    Console.Clear();
    Console.WriteLine("Ditt mål är att tvinga datorn att få mer än 21 poäng.");
    Console.WriteLine("Du får poäng genom att dra kort, varje kort har 1-10 poäng.");
    Console.WriteLine("Om du får mer än 21 poäng har du förlorat.");
    Console.WriteLine("Både du och datorn får två kort i början. Därefter får du");
    Console.WriteLine("dra fler kort tills du är nöjd eller får över 21.");
    Console.WriteLine("När du är färdig drar datorn kort till den har");
    Console.WriteLine("mer poäng än dig eller över 21 poäng.");
    Console.WriteLine("");
    Main();
}

void AvslutaSpel()
{
    Console.Clear();
    Environment.Exit(1);
}

void SpelaIgen()
{
    Console.WriteLine("Spela igen? (j/n)");
    spelaIgen = Console.ReadLine()[0];
    if (spelaIgen == 'j')
    {
        Reset();
        Console.Clear();
        Main();
    }
    else
    {
        AvslutaSpel();
    }
}