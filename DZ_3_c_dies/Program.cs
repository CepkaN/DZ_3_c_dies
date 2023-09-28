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
        static void Main(string[] args)
        {
           // задание 2 - уже было

           // задание 4 - уже было

            // задание 5
            Journal journal = new Journal();
            journal.Mostra();
            journal.nome = "Figaro";journal.ans = 1990;journal.descr = "Очень смешной";journal.tel = "88009003000";journal.email = "fig@figaro.fr";
            journal.Mostra();
            Console.WriteLine();
            Magaz magaz = new Magaz();
            magaz.Mostra();
            magaz.nome = "Metro";magaz.descr = "гипермаркет";magaz.adress = "Сибирский тракт";magaz.tel = "88008009905";magaz.email = "metr@metro.com";
            magaz.Mostra();
        }
    }
}