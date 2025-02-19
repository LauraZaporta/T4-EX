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
            listEmp.Add(new Employee("A2", "Grawr", "??", "05/09/2006", "25/10/2018", 2032, 11));
            listEmp.Add(new Employee("A3", "AAAAA", "BCD", "09/09/2004", "02/11/2018", 2032, 11));
            listEmp.Add(new Employee("A4", "NoPuc", "Més", "02/06/2007", "04/11/2016", 2032, 11));
            listEmp.Add(new Employee("A5", "Grawr", "No", "05/09/2006", "12/01/2021", 2032, 11));

            listSales.Add(new SalesEmployee("B1", "Lorax", "No", "15/12/2006", "30/10/2018", 2000, 12, 0.1));
            listSales.Add(new SalesEmployee("B2", "Grawr", "??", "05/09/2006", "25/10/2018", 2032, 11, 0.0));
            listSales.Add(new SalesEmployee("B3", "AAAAA", "BCD", "09/09/2004", "02/11/2018", 2032, 11, 0.3));
            listSales.Add(new SalesEmployee ("B4", "NoPuc", "Més", "02/06/2007", "04/11/2016", 2032, 11, 0.25));
            listSales.Add(new SalesEmployee("B5", "Grawr", "No", "05/09/2006", "12/01/2021", 2032, 11, 0.2));

            List<Employee> SortedListEmp = listEmp.OrderBy(o => o.ExtractSeniorityFromHire()).ToList();
            List<SalesEmployee> SortedListSEmp = listSales.OrderBy(o => o.ExtractSeniorityFromHire()).ToList();

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