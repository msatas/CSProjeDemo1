namespace CSProjeDemo1
{   
       
       public abstract class Kitap
        {
            public int ISNB { get; set; }
            public string Baslik { get; set; }
            public string Yazar { get; set; }
            public int YayınYılı { get; set; }
            public Durum Durum { get; set; }

        }
    
}