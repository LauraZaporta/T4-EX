using System.Collections;

namespace T4EX
{
    public class EX13
    {
        public static void Main()
        {
            Employee emp1 = new Employee("A1", "Lorax", "No", "15/12/2006", "30/10/2018", 2000, 12);
            Employee emp2 = new Employee("A2", "Grawr", "No", "05/09/2006", "31/10/2018", 2032, 11);
            Employee emp3 = new Employee("A2", "Grawr", "No", "05/09/2006", "02/11/2018", 2032, 11);

            SalesEmployee semp1 = new SalesEmployee("A1", "Lorax", "No", "15/12/2006", "30/10/2018", 2000, 12, 0.1);
            SalesEmployee semp2 = new SalesEmployee("A2", "Grawr", "No", "05/09/2006", "31/10/2018", 2032, 11, 0.2);
            SalesEmployee semp3 = new SalesEmployee("A2", "Grawr", "No", "05/09/2006", "02/11/2018", 2032, 11, 0.2);

            for (int i = 0; i < emp3.CounterEmployees; i++)
            {

            }
        }
    }
}