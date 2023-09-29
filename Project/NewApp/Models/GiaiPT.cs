namespace NewApp.Models
{
    public class GiaiPT
    {   

       
        //phuonf trinh bac 2 : ax^2 + bx + c = 0
        public string PhuongTrinhBacHai(double a, double b, double c)
        {
            double denta = (b*b - 4*a*c);

            if (denta < 0)
            {
                return "Phuong Trinh Vo Nghiem";
            }else 
            if(denta == 0)
            {
                double nghiemkep = -b / 2*a;
                return $"Phuong trinh co nghiem kep {nghiemkep}";

            }else
            {
              double nghiem1 = (-b + Math.Sqrt(denta)) / 2*a;
              double nghiem2 = (-b - Math.Sqrt(denta)) / 2*a;

                return $"Phuong trinh co 2 nghiem: Nghiem 1 = {nghiem1}, Nghiem 2 = {nghiem2}";  
            }
        }
        
        // Phuong trinh bac 1 : ax+b = 0
        public string PhuongTrinhBacNhat(double a, double b)
        {
            if (a==0)
            {
                if (b==0)
                {
                    return "Phuong trinh co vo so nghiem";
                }else 
                {
                    return "Phuong trinh vo nghiem";
                }

            }else
            {
                double x = -b / a;
            return $"Nghiem cua phuong trinh la x = {x}";
            }
        }
        

    }
}