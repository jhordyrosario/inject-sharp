namespace InjectSharp;

/// <summary>
/// Class <c>Container</c> Works as a depencies manager
/// Responsible for registering dependencies between providers and their implementations.
/// Represents the dependency injection container that is responsible for resolving
/// and instantiating registered services based on the provided dependencies.
/// </summary>
public class Container
{
    private readonly IDictionary<Type, Type> _dependencies = new Dictionary<Type, Type>();
    public Container(IDictionary<Type, Type> dependencies)
    {
        _dependencies = dependencies;
    }

    /// <summary>
    /// Constructs an instance of the specified type <typeparamref name="TImplementation"/>.
    /// This type must have been registered previously in the container's dependencies.
    /// If the type is not registered, or if it cannot be instantiated, an exception is thrown.
    /// </summary>
    /// <typeparam name="TImplementation">The type of the service to resolve and instantiate.</typeparam>
    /// <returns>An instantiated service of type <typeparamref name="TImplementation"/>.</returns>
    /// <exception cref="InvalidOperationException">Thrown when the type cannot be resolved
    /// or instantiated from the registered dependencies.</exception>
    public TImplementation Construct<TImplementation>() where TImplementation : class
    {
        var toBeImplemented = typeof(TImplementation);

        if (!_dependencies.TryGetValue(toBeImplemented, out var dependency))
        {
            throw new InvalidOperationException($"Unable to resolve service for type {toBeImplemented}.");
        }

        var implementation = (TImplementation?)Activator.CreateInstance(dependency);

        if (implementation == null)
        {
            throw new InvalidOperationException($"Cannot instantiate implementation for type {dependency} the dependency is not able to be constructed.");
        }

        return implementation;
    }
}