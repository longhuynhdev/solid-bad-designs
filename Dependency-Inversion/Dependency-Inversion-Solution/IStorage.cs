using System;

namespace Dependency_Inversion_Solution;

public interface IStorage
{
    ShoppingCart? Load();
    void Save(ShoppingCart cart);
}
