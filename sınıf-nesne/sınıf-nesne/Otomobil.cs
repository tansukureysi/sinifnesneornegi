using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sınıf_nesne
{
    internal class Otomobil
    {
        //herkesin erişebildiği bir alanda otomobilin özelliklerini tanımlayarak değişken atıyoruz
        public string marka { get; set; }
        public string model { get; set; }
        public int modelyılı { get; set; }
        public string renk { get; set; }
        public string vitestipi { get; set; }

        //otomobil sınıfına ait tüm (yukarıda tanımlanan tüm alanları) işlemleri marka değişkenine göre yapıyoruz bunun için öncelikle marka değişkenini döndürdük
        public string markagetir()
        {
            return marka;
        }
    }
}
