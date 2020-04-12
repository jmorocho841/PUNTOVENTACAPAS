using System;
using System.Collections.Generic;
using System.Text;

namespace PUNTOVENTA.MODELOS
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
