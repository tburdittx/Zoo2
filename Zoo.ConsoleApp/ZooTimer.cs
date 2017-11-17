using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Zoo.BusinessLogic.Models;
using Zoo.BusinessLogic.Models.Animals;
using Zoo.BusinessLogic.Services;

namespace Zoo.ConsoleApp
{
  public class ZooTimer
  {
    public event Action Tick;

    public void Run()
    {
           
         
      while (true)
      {
        Tick?.Invoke(); // The "?." is equivalent to "if (Tick != null) Tick.Invoke();"
                
                Thread.Sleep(1000);
      }
    }
  }
}