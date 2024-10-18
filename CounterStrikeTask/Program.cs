using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterStrikeTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Weapon weapon = new Weapon(32, 32, 2.9f, "Auto");

            bool running = true;

            while (running)
            {
                Console.WriteLine("0 - Get Information");
                Console.WriteLine("1 - Shoot");
                Console.WriteLine("2 - Fire");
                Console.WriteLine("3 - Get Remaining Bullet Count");
                Console.WriteLine("4 - Reload");
                Console.WriteLine("5 - Change Fire Mode");
                Console.WriteLine("6 - Exit");
                Console.Write("Select an option (0-6): ");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 0:

                            Console.WriteLine("Information: \n- Shoot: bir gulle at.\n- Fire: butun gulleleri at.\n- Get Remaining Bullet Count: Qalan gulle sayina bax.\n- Reload: Yeniden doldur.\n- Change Fire Mode: Atis modunu deyis.");
                            break;

                        case 1:
                            {
                                weapon.Shoot();
                                break;
                            }

                        case 2:
                            weapon.Fire();
                            break;

                        case 3:
                            Console.WriteLine(weapon.GetRemainBullets());
                            break;

                        case 4:
                            weapon.Reload();
                            break;

                        case 5:
                            weapon.ChangeFireMode();
                            break;

                        case 6:
                            Console.WriteLine("Proqram deyandirildi");
                            running = false;
                            break;
                     }
                    }
                else
                {
                    Console.WriteLine("Yalnis eded");
                }
            }
        }
    }
}
