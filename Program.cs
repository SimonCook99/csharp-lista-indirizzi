using csharp_lista_indirizzi;

StreamReader file = File.OpenText("D:/documenti/BOOLEAN CAREERS/CORSO .NET/ESERCIZI/csharp-lista-indirizzi/addresses.csv");

string colonne = file.ReadLine();

List<Indirizzo> listaIndirizzi = new List<Indirizzo>();

while (!file.EndOfStream){

    string addresses = file.ReadLine(); //leggo l'intera riga del file

    string[] infoAddress = addresses.Split(","); //creo un array con gli elementi separati dalla ,

    try{
        string name = infoAddress[0];
        string surname = infoAddress[1];
        string street = infoAddress[2];
        string city = infoAddress[3];
        string province = infoAddress[4];
        string ZIP = infoAddress[5];

        if (infoAddress.Length > 6){
            infoAddress[0] += infoAddress[1];
            surname = infoAddress[2];
            street = infoAddress[3];
            city = infoAddress[4];
            province = infoAddress[5];
            ZIP = infoAddress[6];
        }
    listaIndirizzi.Add(new Indirizzo(name, surname, street, city, province, ZIP));

    }catch(IndexOutOfRangeException e){
        Console.WriteLine(e.Message);
    }

}

foreach (Indirizzo indirizzo in listaIndirizzi){
    Console.WriteLine($"Nome: {indirizzo.Name} Cognome: {indirizzo.Surname} Via: {indirizzo.Street} Città: {indirizzo.City} Provincia: {indirizzo.Province} Codice postale: {indirizzo.ZIP}");
}

file.Close();
