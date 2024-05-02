# InjectSharp
Simple Dependency Injection implementation for educational and demonstration purposes

InjectSharp is a simple, educational dependency injection (DI) framework for .NET applications. This project is designed to demonstrate how dependency injection works in a straightforward and accessible manner, making it ideal for educational purposes and for those interested in understanding the core concepts of DI without the overhead of more complex frameworks.

## What is Dependency Injection?

Dependency Injection (DI) is a design pattern used to implement IoC (Inversion of Control), allowing for better modularity and making the code easier to manage and test. DI enables the removal of hard-coded dependencies and makes them manageable through external means.

## Key Components

- **Container**: The DI container is a central place where the components and their dependencies are registered. The container is responsible for the creation and injection of instances wherever needed.

- **Builder**: In InjectSharp, the `ContainerGenerator` acts as a builder that collects all the dependencies and constructs a container from them.

## Getting Started

### Prerequisites

- .NET Core 3.1 or later / .NET 5 or later
- Visual Studio 2019 or later (recommended for development)

## Features
**Simple DI Container:** Easy to use and lightweight, with basic DI capabilities.
**Service Registration:** Support for registering services and their implementations.
**Instance Creation:** Automatic creation of service instances when required.

## Contributing
Contributors are welcome! Feel free to open pull requests or submit issues if you have suggestions or encounter bugs.

## License
InjectSharp is released under the MIT License. See the LICENSE file for more details.

## Educational Purpose
This library is created strictly for educational purposes to show how dependency injection frameworks are typically implemented in a simplified form. It is ideal for those new to software design patterns or those interested in learning the internal workings of a DI framework.

This README outlines the project, provides basic usage examples, and explains the educational purpose behind InjectSharp. Adjust as needed to match the actual structure and URLs of your project repository.

### Installation

Currently, to use InjectSharp, clone this repository locally and build the project using Visual Studio or the .NET CLI.

```bash
git clone https://github.com/yourusername/InjectSharp.git
cd InjectSharp
dotnet build
```

## TODO List

This list outlines current tasks and future enhancements planned for the InjectSharp project. Contributors are welcome to tackle these issues or suggest new features.

### Core Development
- [ ] **Implement Lifecycle Management**: Support for different lifecycles like singleton, transient, and scoped.
- [ ] **Error Handling**: Improve error handling for unregistered types and circular dependencies.
- [ ] **Support for Constructor Injection**: Enable the container to resolve dependencies through constructors.

### Testing
- [ ] **Complete Unit Tests**: Add comprehensive tests for new features as they are developed.
- [ ] **Integration Tests**: Set up tests that integrate InjectSharp with a sample .NET application.
- [ ] **Performance Benchmarking**: Establish benchmarks and optimize performance where necessary.

### Documentation
- [ ] **Expand API Documentation**: Provide detailed comments and documentation for all public interfaces and classes.
- [ ] **User Guide**: Create a detailed user guide covering all features and use cases of InjectSharp.
- [ ] **Examples**: Add more complex examples demonstrating advanced usage of the DI framework.

### Tooling and Infrastructure
- [ ] **CI/CD Pipeline**: Setup a CI/CD pipeline using GitHub Actions for automated testing and deployment.
- [ ] **Code Quality**: Integrate static analysis tools to ensure code quality.

### Community and Contribution
- [ ] **Contributing Guidelines**: Draft clear contributing guidelines to help new contributors get started.
- [ ] **Issue Templates**: Create GitHub issue templates for bug reports and feature requests.

### Release Management
- [ ] **Versioning**: Define a clear versioning strategy.
- [ ] **NuGet Packaging**: Prepare the project for distribution via NuGet.
