// See https://aka.ms/new-console-template for more information

using System.Runtime.InteropServices;

namespace module10 { 
public class Manager : IManager
{
    public void Create()
    {

    }

    public void Read()
    {

    }

    public void Update()
    {

    }

    public void Delete()
    {

    }

        void IManager.Write()
        {
            throw new NotImplementedException();
        }
    }


class Program
{
  static void Main(string[] args)
    {
            Manager manager = new Manager();    
            ((IManager) manager).Write();  
    }
}

}
