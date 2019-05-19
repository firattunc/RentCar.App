using RentCar.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.DataAccsess.EF
{
    public class MyInitializer : CreateDatabaseIfNotExists<DatabaseContext>
    {
        DateTime time = DateTime.Now;
        protected override void Seed(DatabaseContext context)
        {
            int degisken = 2;
            

            Role admin = new Role()
            {
                CreatedOn = DateTime.Now,
                ModifiedOn= DateTime.Now,
                ModifiedUserName="firattunc",
                RoleAd="admin",                                
            };
            Role musteri = new Role()
            {
                CreatedOn = DateTime.Now,
                ModifiedOn = DateTime.Now,
                ModifiedUserName = "firattunc",
                RoleAd = "musteri",
            };
            Role calisan = new Role()
            {
                CreatedOn = DateTime.Now,
                ModifiedOn = DateTime.Now,
                ModifiedUserName = "firattunc",
                RoleAd = "calisan",
            };

            Kullanici admin1 = new Kullanici()
            {
                CreatedOn = DateTime.Now,
                ModifiedOn = DateTime.Now,
                ModifiedUserName = "firattunc",
                adSoyad = "admin1",
                kullaniciAdi = "admin1",
                sifre = "1234",
            };
            Kullanici musteri1 = new Kullanici()
            {
                CreatedOn = DateTime.Now,
                ModifiedOn = DateTime.Now,
                ModifiedUserName = "firattunc",
                adSoyad = "musteri1",
                kullaniciAdi = "musteri1",
                sifre = "1234",
            };
            Kullanici calisan1 = new Kullanici()
            {
                CreatedOn = DateTime.Now,
                ModifiedOn = DateTime.Now,
                ModifiedUserName = "firattunc",
                adSoyad = "calisan1",
                kullaniciAdi = "calisan1",
                sifre = "1234",              
            };

            admin.Kullanicilar.Add(admin1);
            musteri.Kullanicilar.Add(musteri1);
            calisan.Kullanicilar.Add(calisan1);

            context.Role.Add(admin);
            context.Role.Add(musteri);
            context.Role.Add(calisan);
           


            for (int i = 0; i < 3; i++)
            {
                //Adding Sirket
                Sirket s = new Sirket()
                {
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    ModifiedUserName = "firattunc",
                    sirketAdi = FakeData.NameData.GetCompanyName(),
                    sirketAdresi = FakeData.PlaceData.GetAddress(),
                };

                    //Adding Arac
                    for (int j = 0; j < 30; j++)
                    {
                        
                        Arac a = new Arac()
                        {
                            CreatedOn = DateTime.Now,
                            ModifiedOn = DateTime.Now,
                            ModifiedUserName = "firattunc",
                            anlikKm = FakeData.NumberData.GetNumber(10000, 100000),
                            aracAdi = FakeData.NameData.GetFirstName(),
                            aracDurum = false,
                            gunlukFiyat = FakeData.NumberData.GetNumber(50, 500),
                            Arac_aracTakip = null,
                            Kiralama = null,


                        };
                        s.Araclar.Add(a);
                        context.Sirket.Add(s);
                        //Adding Musteri
                        Kullanici m = new Kullanici()
                        {
                            CreatedOn = DateTime.Now,
                            ModifiedOn = DateTime.Now,
                            ModifiedUserName = "firattunc",
                            adSoyad = $"musteri{degisken}",
                            kullaniciAdi = $"musteri{degisken}",
                            sifre = "1234",
                            
                        };
                        musteri.Kullanicilar.Add(m);

                        
                        for (int x = 1; x < DateTime.Now.Day; x++)
                        {
                            DateTime dateTakip = new DateTime(2019, DateTime.Now.Month, x);
                            //Adding AracTakip
                            AracTakip takip = new AracTakip();

                            takip.gunlukKm = FakeData.NumberData.GetNumber(100, 500);
                            takip.tarih = dateTakip;
                            takip.Arac = a;
                            takip.Musteri = m;
                            context.AracTakip.Add(takip);
                        }

                        DateTime dateKiralama = new DateTime(2019, DateTime.Now.Month, 1);
                        //Adding Kiralama
                        Kiralama k = new Kiralama()
                        {

                            kiralamaTarihi = dateKiralama,
                            odenecekTutar = DateTime.Now.Day*a.gunlukFiyat,
                            Calisan = calisan1,
                            Musteri = m,
                            Arac = a
                        };

                        degisken++;
                        
                        context.Kiralama.Add(k);

                    }
                   
                

            }
            context.SaveChanges();








        }
    }
}