using NUnit.Framework;
using InjectSharp.Mocks;

namespace InjectSharp.UnitTests;

[TestFixture]
public class DependencyManagerTests
{
    [Test]
    public void Obtain_WhenCalledForOnlyAnImplementation_ShouldResolveAnObjectInstance()
    {
        var containerGenerator = new ContainerGenerator();
        containerGenerator.Add<OrderRepository>();

        var dependencyManager = containerGenerator.Generate();

        var result = dependencyManager.Construct<OrderRepository>();

        Assert.That(result, Is.Not.Null);
    }

    [Test]
    public void Obtain_WhenCalledWithProviderAndImplementation_ShouldResolveAnObjectInstance()
    {
        var containerGenerator = new ContainerGenerator();
        containerGenerator.Add<IOrderRepository, OrderRepository>();

        var dependencyManager = containerGenerator.Generate();

        var result = dependencyManager.Construct<IOrderRepository>();

        Assert.That(result, Is.TypeOf<OrderRepository>());
    }

    [Test]
    public void Construct_WhenTypeIsNotRegistered_ShouldThrowInvalidOperationException()
    {
        var containerGenerator = new ContainerGenerator();
        var dependencyManager = containerGenerator.Generate();

        Assert.Throws<InvalidOperationException>(() => dependencyManager.Construct<IOrderRepository>());
    }
}
