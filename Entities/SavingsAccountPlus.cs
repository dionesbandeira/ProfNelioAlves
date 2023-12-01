using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfNelioAlves.Entities
{
    internal class SavingsAccountPlus : SavingsAccount
    {
        /* Geralmente convém selar métodos sobrepostos, pois sobreposições múltiplas
           podem ser uma porta de entrada para inconsistências */

        //Não permite utilizar o método Sobre escrito poe estar selado! 
        //public override void Withdraw( double amount) { }

       

    }

}
