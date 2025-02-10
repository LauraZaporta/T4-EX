using System.Collections;

namespace T4EX
{
    public class EX13
    {
        public static void Done()
        {
            List<Employee> listEmp = new List<Employee>();
            List<SalesEmployee> listSales = new List<SalesEmployee>();

            listEmp.Add(new Employee("A1", "Lorax", "No", "15/12/2006", "30/10/2018", 2000, 12));
            listEmp.Add(new Employee("A2", "Grawr", "No", "05/09/2006", "25/10/2018", 2032, 11));
            listEmp.Add(new Employee("A3", "Grawr", "No", "05/09/2006", "02/11/2018", 2032, 11));

            listSales.Add(new SalesEmployee("A1", "Lorax", "No", "15/12/2006", "30/10/2018", 2000, 12, 0.1));
            listSales.Add(new SalesEmployee("A2", "Grawr", "No", "05/09/2006", "25/10/2018", 2032, 11, 0.2));
            listSales.Add(new SalesEmployee("A3", "Grawr", "No", "05/09/2006", "02/11/2018", 2032, 11, 0.2));

            List<Employee> SortedListEmp = listEmp.OrderBy(o => o.Seniority).ToList();
            List<SalesEmployee> SortedListSEmp = listSales.OrderBy(o => o.Seniority).ToList();

            SortedListEmp.ForEach(delegate (Employee emp)
            {
                Console.WriteLine(emp.ToString());
            });
            SortedListSEmp.ForEach(delegate (SalesEmployee emp)
            {
                Console.WriteLine(emp.ToString());
            });
        }
    }
}