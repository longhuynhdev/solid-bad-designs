using System;

namespace Dependency_Inversion_Solution;

public class PDFPrinter : IPrinter
{
    public void Print(ShoppingCart cart)
    {
        throw new NotImplementedException();
    }
}
