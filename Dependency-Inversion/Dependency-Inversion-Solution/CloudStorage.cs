using System;

namespace Dependency_Inversion_Solution;

public class CloudStorage : IStorage
{
    public ShoppingCart? Load()
    {
        throw new NotImplementedException();
    }

    public void Save(ShoppingCart cart)
    {
        throw new NotImplementedException();
    }
}
