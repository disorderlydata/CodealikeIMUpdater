using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API
{
    public enum CodealikeStatus
    {
        NoActivity, //Grey
        CanInterrupt, //Maybe - Green
        CannotInterrupt, //No - Red
        Unknown
    }
}
