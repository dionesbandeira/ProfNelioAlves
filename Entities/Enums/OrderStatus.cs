using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProfNelioAlves.Entities.Enums;
using ProfNelioAlves.Entities;


namespace ProfNelioAlves.Entities.Enums
{
    enum OrderStatus : int
    {
        //Classe do tipo enumerador da Etidade
        //Enums são do tipo valor
        // : ele é derivado do tipo int

        PendingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3



    }

}
