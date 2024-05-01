namespace InjectSharp;


/// <summary>
/// Class <c>ContainerGenerator</c> Responsible for registering dependencies between providers and their implementations.
/// It allows adding dependencies either by specifying both provider and implementation types,
/// or by self-binding where the implementation is its own provider.
/// Once all dependencies are registered, it can generate a <see cref="Container"/> which
/// will be used to resolve and instantiate these dependencies.
/// </summary>
public class ContainerGenerator
{   
    private readonly IDictionary<Type, Type> _dependencies = new Dictionary<Type, Type>();

    /// <summary>
    /// Registers a dependency mapping from a provider type to an implementation type.
    /// Both provider and implementation must be classes, with the implementation being able
    /// to instantiate itself (must have a parameterless constructor) and implement the provider.
    /// </summary>
    /// <typeparam name="TProvider">The type of the provider (interface or abstract class).</typeparam>
    /// <typeparam name="TImplementation">The concrete class implementing the provider.</typeparam>
    public void Add<TProvider, TImplementation>() 
    where TProvider : class
    where TImplementation : class, TProvider, new()
    {
        _dependencies.Add(typeof(TProvider), typeof(TImplementation));
    }

    /// <summary>
    /// Registers a type as both the provider and the implementation, assuming that
    /// the type can instantiate itself (must have a parameterless constructor).
    /// This is commonly used for services that do not have an interface.
    /// </summary>
    /// <typeparam name="TImplementation">The type to register as both provider and implementation.</typeparam>
    public void Add<TImplementation>()
    where TImplementation : class, new()
    {
        _dependencies.Add(typeof(TImplementation), typeof(TImplementation));
    }

    /// <summary>
    /// Generates a <see cref="Container"/> using the registered dependencies.
    /// This container can then be used to resolve and instantiate the registered types.
    /// </summary>
    /// <returns>An instance of <see cref="Container"/>.</returns>
    public Container Generate()
    {
        return new Container(_dependencies);
    }
}
