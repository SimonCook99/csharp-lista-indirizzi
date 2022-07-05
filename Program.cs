using csharp_lista_indirizzi;

StreamReader file = File.OpenText("D:/documenti/BOOLEAN CAREERS/CORSO .NET/ESERCIZI/csharp-lista-indirizzi/addresses.csv");

string colonne = file.ReadLine();

List<Indirizzo> listaIndirizzi = new List<Indirizzo>();

while (!file.EndOfStream){

    string addresses = file.ReadLine(); //leggo l'intera riga del file

    string[] infoAddress = addresses.Split(","); //creo un array con gli elementi separati dalla ,
    string name = infoAddress[0];
    string surname = infoAddress[1];
    string street = infoAddress[2];
    string city = infoAddress[3];
    string province = infoAddress[4];
    string ZIP = infoAddress[5];

    listaIndirizzi.Add(new Indirizzo(name, surname, street, city, province, ZIP));
}

foreach (Indirizzo indirizzo in listaIndirizzi){
    Console.WriteLine($"Stampa in corso: {indirizzo.Name}, {indirizzo.Surname}, {indirizzo.Street}, {indirizzo.City}, {indirizzo.Province}, {indirizzo.ZIP}");
}
