using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfNelioAlves.Services
{
    internal interface ITaxService
    {

        //Interace define apenas o contrato que sera a linha abaixo 
        double Tax(double amount);

    }
}
