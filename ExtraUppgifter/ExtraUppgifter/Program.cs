using System;
using System.Collections.Generic;

namespace ExtraUppgifter
{
  static class OrdLista
  {
    static List<string> eng_List = new List<string>();
    static List<string> sve_List = new List<string>();

    static Random slump = new Random();

    /**
     * <summary>
     * Skriver ut ett meddelande och läser en hel rad från konsolen.
     * </summary>
     * <param name="msg">Aktuelt meddelande</param>
     * <returns>Returnerar svaret på aktuellt meddelande</returns>
     **/
    static string GetInputText(string msg)
    {
      bool slutOK;
      string result = "";
      do
      {
        Console.Write(msg);
        try
        {
          result = Console.ReadLine();
          slutOK = false;
        }
        catch (IndexOutOfRangeException)
        {
          slutOK = true;
          Console.Clear();
          Console.WriteLine("Något blev fel, en gång till");
        }
      } while (slutOK);
      return result;
    }

    /**
     * <summary>
     * Skriv 2 st ord och lägg dom på ord listan
     * </summary>
     **/
    public static void InsertWord()
    {
      char input;
      bool menyOK = true;
      do
      {
        sve_List.Add(GetInputText("Ange ett svenskt ord: "));
        eng_List.Add(GetInputText("Ange motsvarande engelskt ord: "));
        input = '0';
        if (input == '0')
          menyOK = false;

      } while (menyOK);
    }

    /**
     * <summary>
     * Mata in det svenska ordet till ett engelskt ord
     * </summary>
     * <param name="mode">1 = sve -> eng, 2 = eng -> sve, 3 = rnd</param>
     * <returns>result: antal korrekt ord</returns>
     **/
    public static int SvenskaEngelsk(char mode)
    {
      string input;
      char slump_mode;
      bool nextOK = true;
      int result = 0; // Upprepa tills fel ord, return: antal rätt ord.
      int index; // Slumptal från 0 till antal.Count-1
      do
      {
        if ((mode == '1') || (mode == '2'))
        {
          slump_mode = mode;
        }
        else if (slump.Next(1, 11) < 6)
        {
          slump_mode = '1';
        }
        else
        {
          slump_mode = '2';
        }

        index = slump.Next(0, sve_List.Count);
        if (slump_mode == '1')
        {
          Console.Write("Skriv " + sve_List[index] + " på engelska : ");
        }
        else
        {
          Console.Write("Skriv " + eng_List[index] + " på svenska : ");
        }

        try
        {
          input = Console.ReadLine(); // innehåler inmatat ord
          if (((slump_mode == '1') && (input.CompareTo(eng_List[index]) == 0)) || ((slump_mode == '2') && (input.CompareTo(sve_List[index]) == 0)))
          {
            result += 1;
          }
          else
          {
            nextOK = false;
          }
        }
        catch (IndexOutOfRangeException)
        {
          Console.Clear();
          Console.WriteLine("Ange nytt ord");
        }
      } while (nextOK);
      return result;
    }

    /**
     * <summary>
     * tför testen av ord till inmatad lista
     * </summary>
     **/
    public static void WordPlay()
    {
      int antalOrd = 0;
      char input = '1';
      char mode = '2';
      bool menyOK = true;
      do
      {
        if (mode == '2')
        {
          input = Menu("Vilken testmodell vill du köra? 1 = Sve -> Eng", "2 = Eng -> Sve eller 3 = Blandning", "0 = Återgå");
        }
        antalOrd = SvenskaEngelsk(input);

        Console.WriteLine("Antal rätt ord är " + antalOrd);
        Console.ReadKey();

        mode = Menu("Vilken test 1 = Samma test", "2 = Ny testmodell", "0 = Återgå");
        if (mode == '0')
        {
          menyOK = false;
        }
      } while (menyOK);
    }

    /**
     * <summary>
     * Skriver ut en menyval med 3 olika meningar
     * </summary>
     * <param name="menu">Första meningen</param>
     * <param name="menu1">Andra meningen under</param>
     * <param name="menu2">Sista meningen</param>
     **/
    public static char Menu(string menu, string menu1, string menu2)
    {
      string lineStr;
      char svar = ' ';
      Console.Clear();
      Console.WriteLine(menu);
      if (!string.IsNullOrEmpty(menu1))
      {
        Console.WriteLine(menu1);
      }

      if (!string.IsNullOrEmpty(menu2))
      {
        Console.WriteLine(menu2);
      }

      try
      {
        lineStr = Console.ReadLine(); // Tries to set input to the first char in an input line
        if (!string.IsNullOrEmpty(lineStr))
        {
          svar = lineStr[0];
        }
      }
      catch (IndexOutOfRangeException)
      {
        Console.Clear();
        Console.WriteLine("Vänligen ange några bokstäver!");
      }
      return svar;
    }
  }

  static class Program
  {
    static void Main(string[] args)
    {
      char input;
      bool menyOK = true;
      do
      {
        input = OrdLista.Menu("Ange ett val där 1 = Lägga till ord", "2 = Utföra en test på orden", "0 = Exit");
        if (input == '1')
        {
          OrdLista.InsertWord();
        }
        else if (input == '2')
        {
          OrdLista.WordPlay();
        }
        else if (input == '0')
        {
          menyOK = false;
        }
      } while (menyOK);
    }
  }
}