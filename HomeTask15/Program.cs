using System.Runtime.Intrinsics.Arm;
using KlassTask._01._12.Exceptions;
using KlassTask._01._12.WeaponModels;
using System;
using System.Media;
using System.Runtime.CompilerServices;

namespace KlassTask._01._12

{
    internal class Program
    {
        static void Main(string[] args)
        {



            int maxammocapacity = 0;
            int input1 = 0;
            int currentammo = 0;

            Console.WriteLine("Create Weapon");

            bool check1 = false;
            do
            {

                Console.WriteLine("Choose magazin capacity");



                try
                {
                    maxammocapacity = Convert.ToInt32(Console.ReadLine());
                    if (maxammocapacity > 0)
                    {
                        check1 = true;
                    }
                    else
                    {
                        throw new InvalidAmmoException();
                    }



                }
                catch (InvalidAmmoException)
                {
                    Console.WriteLine("Ammo Capacity Must be Bigger Than Zero");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
                catch
                {
                    Console.WriteLine($"Another Problem ");
                }
            } while (!check1);





            bool check2 = false;
            do
            {

                Console.WriteLine("Choose Current Ammo");
                try
                {
                    currentammo = Convert.ToInt32(Console.ReadLine());
                    if (currentammo >= 0 && currentammo <= maxammocapacity)
                    {
                        check2 = true;
                    }
                    else
                    {
                        throw new InvalidCurrentAmmoException();
                    }


                }
                catch (InvalidCurrentAmmoException)
                {
                    
                    Console.WriteLine($"Ammo can not be negativ and over Max ammo; Your Max Ammo is {maxammocapacity}");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
                catch (Exception)
                {
                    Console.WriteLine("Another Error");
                }

            } while (!check2);
            Console.Clear();

            bool check3 = false;
            do
            {
                Console.WriteLine("Choose Fire Mood");
                Console.WriteLine("1.Shot");
                Console.WriteLine("2.Brust");
                Console.WriteLine("3.Fire");

                try
                {
                    input1 = Convert.ToInt32(Console.ReadLine());
                    if (input1 > 0 && input1 < 4)
                    {
                        Weapon.ChangeFireMode(input1);
                        check3 = true;
                    }
                    else
                    {
                        throw new WrongOperationException();
                    }



                }
                catch (WrongOperationException)
                {
                    Console.WriteLine("Wrong operation. Sellect number from 1 to 3");

                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            } while (!check3);
            Console.Clear();











            Console.Clear();
            Weapon AK47 = new Weapon(maxammocapacity, currentammo, input1);
            if (AK47 != null)
            {
                Console.WriteLine("Weapon Created Successfully");
            }
















            bool check4 = false;
            int input2 = 0;
            do
            {


                Console.WriteLine(" 0 - Information");
                Console.WriteLine("1 - Shoot  ");
                Console.WriteLine("2 - Fire ");
                Console.WriteLine("3 - GetRemainBulletCount  ");
                Console.WriteLine("4 - Reload  ");
                Console.WriteLine("5 - ChangeFireMode ");
                Console.WriteLine("6 - Exit Program ");
                Console.WriteLine("Create New  Shortcut :");
                Console.WriteLine("7. Edit:");


                do
                {

                    try
                    {
                        input2 = Convert.ToInt32(Console.ReadLine());
                        if (input2>=0&& input2<8)
                        {
                        check4 = true;

                        }
                        else
                        {
                            throw new WrongOperationException();
                        }

                    }
                    catch (WrongOperationException)
                    {
                        Console.WriteLine("Wrong operation. Sellect number from 0 to 7");
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Wrong Please enter Number");
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("This input is over Range");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Wrong Operation: {ex.Message}");
                    }
                } while (!check4);
                Console.Clear();


                switch (input2)
                {
                    case 0:
                        Console.WriteLine(AK47.ToString());
                        break;
                    case 1:
                        AK47.Shoot();

                        break;
                    case 2:
                        AK47.Fire();
                        break;
                    case 3:
                        AK47.GetRemainBulletCount();
                        break;
                    case 4:
                        AK47.Reload();
                        break;
                    case 5:

                        bool check5 = false;
                        do
                        {
                            Console.WriteLine("Choose Fire Mood");
                            Console.WriteLine("1.Shot");
                            Console.WriteLine("2.Brust");
                            Console.WriteLine("3.Fire");
                            try
                            {

                                input1 = Convert.ToInt32(Console.ReadLine());
                                if (input1 > 0 && input1 < 4)
                                {
                                    Weapon.ChangeFireMode(input1);
                                    check5 = true;
                                }
                                else
                                {
                                    throw new WrongOperationException();
                                }



                            }
                            catch (WrongOperationException)
                            {
                                Console.WriteLine("Wrong operation. Sellect number from 1 to 3");

                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Invalid input. Please enter a valid number.");
                            }
                        } while (!check5);
                        break;




                    case 6:
                        Console.WriteLine("The Program was Exited");
                        break;
                    case 7:
                        int input4 = 0;
                        bool check6=false;
                        do 
                        {
                        Console.WriteLine("Deyesikliyi secin");
                        Console.WriteLine("8.ChangeCapacity");
                        Console.WriteLine("9.ChangeCurrentAmmo");
                        try
                        {
                            input4 = Convert.ToInt32(Console.ReadLine());
                            if (input4 == 8 || input4==9)
                            {
                                check6 = true;
                            }else
                            {
                                throw new WrongOperationException();    
                            }

                        }
                        catch (WrongOperationException)
                        {
                            Console.WriteLine("Wrong operation. Sellect number 8 0r 9");
                        }
                        catch (FormatException) 
                        {
                                Console.WriteLine("Invalid input. Please enter a valid number.");
                            
                        }
                       catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        }while (!check6);
                        

                        Console.Clear();


                        do
                            switch (input4)
                            {

                                case 8:
                                    bool check7= false;
                                    do
                                    {
                                        Console.WriteLine("Choose  New Ammo Capacity");

                                        try
                                        {
                                            int input5 = Convert.ToInt32(Console.ReadLine());
                                            if (input5 > 0)
                                            {
                                                AK47.Changecapacity(input5);
                                                check7 = true;
                                            }
                                            else
                                            {
                                                throw new WrongOperationException();
                                            }
                                        }
                                        catch (WrongOperationException)
                                        {
                                            Console.WriteLine("Wrong operation. Sellect number over zero");
                                        }
                                        catch (FormatException)
                                        {

                                            Console.WriteLine("Invalid input. Please enter a valid number.");
                                        }
                                        catch (Exception)
                                        {
                                            Console.WriteLine("Another Exception");
                                        }
                                    } while (!check7);

                                    Console.Clear();
                                    break;
                                case 9:
                                    bool check8= false;
                                    do 
                                    {
                                    Console.WriteLine("Choose  New Current Ammo ");

                                        try
                                        {

                                            int input6 = Convert.ToInt32(Console.ReadLine());
                                            if (input6 > 0 && input6 <  maxammocapacity)
                                            {

                                                Weapon.ChangeCurrentammo(input6);
                                                check8 = true;
                                            }else if (input6 <0 || input6>maxammocapacity)
                                            {
                                                throw new WrongOperationException();    
                                            }

                                        }
                                       
                                        catch (WrongOperationException)
                                        {
                                            Console.WriteLine($"Wrong operation. Sellect number over zero and below Max ammo {maxammocapacity}");
                                        }
                                        catch (FormatException)
                                        {

                                            Console.WriteLine("Invalid input. Please enter a valid number.");
                                        }
                                        catch (Exception)
                                        {
                                            Console.WriteLine("Another Exception");

                                        }

                                    } while (!check8);

                                    Console.Clear();

                                    break;
                            } while (input4 != 8 && input4 != 9);



                    break;























                }
            } while (input2 != 6);


        }
    }
}










