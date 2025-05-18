using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt.Dto
{
    class NbpResponseDto
    {
        public required List<ExchangeRate> Rates { get; set; }
    }
}
