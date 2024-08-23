using System;

namespace ChuyenDoiNhietDo
{
    class Program
    {
        static void Main(string [] args)
        {
            int luaChon;
            double doC;
            double doF;
            Console.WriteLine("MENU");
            Console.WriteLine("1: Chuyen do C thanh do F");
            Console.WriteLine("2: Chuyen do F thanh do C");
            Console.WriteLine("0: Exit");
            tryAgain:
            while(true)
            {
                 Console.Write("Nhap vao lua chon cua ban: ");
                if(int.TryParse(Console.ReadLine(),out luaChon))
                {
                    break;
                }
                continue;
            }
            
            switch(luaChon)
            {
                case 1:
                {
                     while(true)
                    {
                        Console.Write("Nhap vao nhiet do C ma ban muon chuyen thanh do F: ");
                        if(double.TryParse(Console.ReadLine(),out doC))
                        {
                            break;
                        }
                        continue;
                    }
                    doF=ChuyenDoiDoF(doC);
                    Console.Write("{0}*C = {1}*F", doC,doF);
                    break;
                }
                case 2:
                {
                     while(true)
                    {
                        Console.Write("Nhap vao nhiet do F ban muon chuyen thanh do C: ");
                        if(double.TryParse(Console.ReadLine(),out doF))
                        {
                            break;
                        }
                        continue;
                    }
                    doC=ChuyenDoiDoC(doF);
                    Console.Write("{0}*F = {1}*C", doF,doC);
                    break;
                }
                case 0:
                {
                    return;
                }
                default:
                {
                    Console.WriteLine("Ban nhap sai lua chon, hay nhap lai");
                    goto tryAgain;
                    
                }
            }

        }
        static double ChuyenDoiDoC(double doF)
        {
            double doC;                        
            doC=((5.0/9)*(doF-32));
            return doC;
        }
        static double ChuyenDoiDoF(double doC)
        {            
            double doF;
            doF=((((9.0/5)*doC)+32));
            return doF;
        }
    }
}