using Microsoft.CodeAnalysis;

namespace SourceGenerator;

[Generator]
public class HelloSourceGenerator : ISourceGenerator
{
    public void Execute(GeneratorExecutionContext context)
    {
        string source = """
namespace BlazorWebAssemblyApp;
public class GeneratedService
    {
        public string GetHello()
        {
            return "Hello from generated code";
        }
    }
""";
        context.AddSource($"GeneratedService.g.cs", source);
    }

    public void Initialize(GeneratorInitializationContext context) { }
}
