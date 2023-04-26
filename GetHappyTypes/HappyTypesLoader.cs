using System.Reflection;

namespace GetHappyTypes;

public class HappyTypesLoader
{
    public static List<IHappyInterface> DoWork()
    {
        Type interfaceType = typeof(IHappyInterface);

        return Assembly.GetAssembly(typeof(HappyTypesLoader))!
            .GetTypes()
            .Where(type => type.IsAssignableTo(interfaceType) && type.IsClass)
            .Select(Activator.CreateInstance)
            .Cast<IHappyInterface>()
            .ToList();
    }
}
