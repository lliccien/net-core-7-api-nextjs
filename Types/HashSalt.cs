using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace products_app.Types;

public class HashSalt
{
    public string Hash { get; set; }
    public byte[] Salt { get; set; }
}
