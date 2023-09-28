namespace NewApp.Models
{
    public class GiaiPT
    {   

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