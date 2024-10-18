using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CounterStrikeTask
{
    public class Weapon
    {
        public int BulletCap { get; set; }
        public int CurrentBullets { get; set; }
        public float DischargeTime { get; set; }
        public string FireMod { get; set; }

        public Weapon()
        {

        }

        public Weapon(int bulletCapacity, int currentBulletsCount, float dischargeTime, string fireMod)
        {
            BulletCap = bulletCapacity;
            CurrentBullets = currentBulletsCount;
            DischargeTime = dischargeTime;
            FireMod = fireMod;
        }

        public void Shoot()
        {
            if (CurrentBullets > 0)
            {
                CurrentBullets--; 
                Console.WriteLine("Bir defe ates edildi");
                Console.WriteLine($"Gulle sayi {CurrentBullets}/{BulletCap}");
            }
            else
            {
                Console.WriteLine("Daraq bosdur");
                Reload();

            }

        }

        public void Fire()
        {
            if (CurrentBullets > 0)
            {
                if (FireMod == "Auto")
                {
                    Console.WriteLine("Ates basladi");

                    float spentTime = (CurrentBullets * DischargeTime) / BulletCap;                    

                    Console.WriteLine("Ates bitdi!");

                    Console.WriteLine($"{CurrentBullets} gulle istifade edildi. Ates {spentTime} saniye davam etdi");

                    CurrentBullets = 0;

                }
                else
                {
                    Shoot();
                }
            }
            else
            {
                Console.WriteLine("Daraq bosdur");
                Console.Write("Daragi deyisdirmek isteyirsiniz mi?(y/n):");
                string code = default;
                bool running = true;
                while (running)
                {
                    code = Console.ReadLine();
                    if (code == "y")
                    {
                        Reload();
                        running = false;
                    }
                    else if (code == "n")
                    {
                        Console.WriteLine("Silahin daragi bos olaraq qalir!");
                        running = false;
                    }
                    else
                    {
                        Console.WriteLine("Duzgun code daxil edilmedi!!!");
                        Console.Write("Daragi deyisdirmek isteyirsiniz mi?(y/n):");
                    }
                }

            }
        }

        public int GetRemainBullets()
        {
            int remainBulletsCount = BulletCap - CurrentBullets;
            return remainBulletsCount;
        }

        public void Reload()
        {
            if (CurrentBullets != BulletCap)
            {
                Console.WriteLine("Daraq deyisdirildi.");
                CurrentBullets = BulletCap;
            }
            else
            {
                Console.WriteLine("Daraq deyismeye ehtiyac yoxdur");
            }
        }

        public void ChangeFireMode()
        {
            if (FireMod == "Auto")
            {
                FireMod = "Single";
            }
            else
            {
                FireMod = "Auto";
            }

            Console.WriteLine($"Atis modu {FireMod} olaraq deyisdirildi");
        }
    }
}
