using System.Text;

internal class Program
{
    class Org
    {
        string name;
        string director;
        string code;
        string type;
        int doxod;
        string[] employers;
        string adress;

        public Org()
        {

        }

        public Org(string name, string director, string code, string type, int doxod, string employers, string adress)
        {

            Name = name ?? throw new ArgumentNullException(nameof(name));
            Director = director ?? throw new ArgumentNullException(nameof(director));
            Code = code ?? throw new ArgumentNullException(nameof(code));
            Type = type ?? throw new ArgumentNullException(nameof(type));
            Doxod = doxod;
            this.employers = employers.Split(',') ?? throw new ArgumentNullException(nameof(employers));
            this.adress = adress ?? throw new ArgumentNullException(nameof(adress));

        }

        public string Name { get => name; set => name = value; }
        public string Director { get => director; set => director = value; }
        public string Code { get => code; set => code = value; }
        public string Type { get => type; set => type = value; }
        public int Doxod { get => doxod; set => doxod = value; }

        public int Nalog()
        {
            if (doxod > 1000)
                {
                    return (doxod - 1000) / 100 * 13;
                }
            else {
                    return 0;
                }
        }

        public override string ToString()
        {
            return new StringBuilder()
                .AppendLine($"Name: {name}")
                .AppendLine($"Director: {director};")
                .AppendLine($"Code: {code};")
                .AppendLine($"Type: {type};")
                .AppendLine($"Doxod: {doxod};")
                .AppendLine($"Nalog: {this.Nalog()};")
                .AppendLine($"Employers: {string.Join(", ", employers)};")
                .AppendLine($"Adress: {adress}.")
                .ToString();
            
        }
    }

    class Zavod : Org
    {
        int objcount;
        string zavodname;
        string[] production;
       

        public Zavod() : base()
        {

        }


        public Zavod(string name,string zavodname, string director, string code, string type, int doxod, string production, string employers,int objcount, string adress)
            : base(name, director, code, type, doxod, employers, adress)
        {
            this.production = production.Split(',') ?? throw new ArgumentNullException(nameof(production));
            this.zavodname = zavodname ?? throw new ArgumentNullException(nameof(zavodname));
            this.objcount = objcount;
        }

        public override string ToString()
        {
            return base.ToString() +
                new StringBuilder()
                .AppendLine($"Production: {string.Join(", ", production)}.")
                .ToString();
        }

        
    }

    class Company : Org
    {
        string[] uslugi;
        string InternationalStatus;
        

        public Company()
        {

        }

        public Company(string name, string director, string code, string type, int doxod, string employers, string adress,string uslugi, string internationalstatus) : base(name, director, code, type, doxod, employers, adress)
        {
            this.uslugi = uslugi.Split(',') ?? throw new ArgumentNullException(nameof(uslugi));
            this.InternationalStatus = internationalstatus ?? throw new ArgumentNullException(nameof(internationalstatus));
        }

        public int VVP()
        {
            return (this.Doxod - this.Nalog()) * 12;
        }

        public override string ToString()
        {
            return base.ToString()+
                new StringBuilder()
                    .AppendLine($"Uslugi: {string.Join(", ", uslugi)};")
                    .AppendLine($"InternationalStatus = {InternationalStatus};")
                    .AppendLine($"VVP = {VVP()}.")
                    .ToString();
        } 
    }

    private static void Main(string[] args)
    {
        Org OOOMat = new("Mat", "Mihail Pupov", "1423432", "Physik", 45000, "melki,karandashi,pen", "Sidorov,maksimenko,Vetov");
        Console.WriteLine(OOOMat.ToString());

        Console.WriteLine(  );

        Zavod Beltaz = new("Mat", "Beltaz" ,"Mihail Pupov", "1423432", "Physik", 45000, "melki,karandashi,pen" , "Sidorov,maksimenko,Vetov" , 5 ,"Hrodno Titova 48b");
        Console.WriteLine(Beltaz.ToString());

        Console.WriteLine();

        Company BelAuto = new("Mat", "Mihail Pupov", "1423432", "Physik", 45000,  "Sidorov,maksimenko,Vetov",  "Hrodno Titova 48b","chistka,izgotovka,prodazha","WorldWide");
        Console.WriteLine(BelAuto.ToString());
    }
}