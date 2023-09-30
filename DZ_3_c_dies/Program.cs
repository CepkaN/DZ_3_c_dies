namespace DZ_3_c_dies
{
    internal class Program
    {
        class Journal
        {
            string _nome;
            int _ans;
            string _descr;
            string _tel;
            string _email;
            public string nome
            {
                get { return _nome; }
                set { _nome = value; }
            }
            public int ans
            {
                get { return _ans; }
                set { _ans = value; }
            }
            public string descr
            {
                get { return _descr; }
                set { _descr = value; }
            }
            public string tel
            {
                get { return _tel; }
                set { _tel = value; }
            }
            public string email
            {
                get { return _email; }
                set { _email = value; }
            }
            public Journal()
            {
                _nome = "niente";_ans = 0;_descr = "niente";_tel = "niente";_email = "niente";
            }
            public Journal(string nome,int ans,string descr,string tel,string email)
            {
                _nome = nome;  
                _ans = ans;
                _descr = descr;
                _tel = tel;
                _email = email;
            }
            public void Mostra()
            {
                Console.WriteLine(" Название журнала : " + _nome + "\n Год основания : " + _ans + "\n Описание : " + _descr + "\n Телефон : " + _tel + "\n Email : " + _email);
            }
        }
        class Magaz
        {
            string _nome;
            string _descr;
            string _adress;
            string _tel;
            string _email;
            public string nome
            {
                get { return _nome; }
                set { _nome = value; }
            } 
            public string descr
            {
                get { return _descr; }
                set { _descr = value; }
            }
            public string adress
            {
                get { return _adress; }
                set { _adress = value; }
            }

            public string tel
            {
                get { return _tel; }
                set { _tel = value; }
            }
            public string email
            {
                get { return _email; }
                set { _email = value; }
            }
            public Magaz(string nome, string descr, string adress, string tel, string email)
            {
                this.nome = nome;
                this.descr = descr;
                this.adress = adress;
                this.tel = tel;
                this.email = email; 
            }
            public Magaz()
            {
                _nome = "niente"; _descr = "niente";_adress = "niente"; _tel = "niente"; _email = "niente";
            }
            public void Mostra()
            {
                Console.WriteLine(" Название магазина : " + _nome + "\n Описание : " + _descr + "\n Адрес : " + _adress + "\n Телефон : " + _tel + "\n Email : " + _email);
            }
        }
        class Website
        {
            string _nome;
            string _url;
            string _ob;
            string _ip;
            public string nome
            {
                get { return _nome; }
                set { _nome = value; }
            }
            public string url
            {
                get { return _url; }
                set { _url = value; }
            }
            public string ob
            {
                get { return _ob; }
                set { _ob = value; }
            }
            public string ip
            {
                get { return _ip; }
                set { _ip = value; }
            }
            public Website()
            {
                _nome = "niente";
                _url = "niente";
                _ob = "niente";
                _ip = "niente";
            }
            public Website(string nome, string url, string ob, string ip)
            {
                this._nome = nome;
                this._url = url;
                this._ob = ob;
                this._ip = ip;
            }

            public void Mostra()
            {
                Console.WriteLine("\n Имя сайта : " + _nome + "\n адрес сайта : " + _url + "\n описание сайта : " + _ob + "\n ip сайта : " + _ip);
            }
        }
        static void Main(string[] args)
        {
            // задание 2
            Console.WriteLine("Введите число : ");
            string? cislo = Console.ReadLine();
            bool proverka(string str)
            {
                for (int i = 0; i < str.Length / 2; ++i)
                {
                    if (str[i] != str[str.Length - 1 - i]) { return false; }
                }
                return true;
            }
            Console.WriteLine("Проверка на палиндром " + proverka(cislo));

            // задание 4
            Website site = new Website();
            site.Mostra();
            site.nome = "aaaaaaa";
            site.url = "bbbbbbb";
            site.ob = "ccccccc";
            site.ip = "ddddddd";
            site.Mostra();

            // задание 5
            Journal journal = new Journal();
            journal.Mostra();
            journal.nome = "Figaro";journal.ans = 1990;journal.descr = "Очень смешной";journal.tel = "88009003000";journal.email = "fig@figaro.fr";
            journal.Mostra();
            Console.WriteLine();

            // 6
            Magaz magaz = new Magaz();
            magaz.Mostra();
            magaz.nome = "Metro";magaz.descr = "гипермаркет";magaz.adress = "Сибирский тракт";magaz.tel = "88008009905";magaz.email = "metr@metro.com";
            magaz.Mostra();
        }
    }
}