# Async Generator

T4 template to generate async methods wrapping existing APM

# Example/How to use

Install from nuget to project you need wrappers in.
    
    Install-Package AsyncGenerator

This will add two files:

  __AsyncExtensions.ttinclude__ - this is main implemantation
  __ExampleAsyncExtensions.tt__ - example template, it configures and include `AsyncExtensions.ttinclude`

Example of `ExampleAsyncExtensions.tt`, in most cases you only need modify `Name`, `Namespace` and `Assemblies`.

    <#  
    var config = new GenerationConfiguration
    {
        Name = "ExampleAsyncExtensions", // Name of the class to generate
        Namespace = "SuperExample", // Namespace of the class
        Assemblies = new []
        {
            Define(@".\Path\To.dll", // Path to assembly to generate wrappers
                "SuperType1", "SuperType2") // List all types you want to include
        }
    };
    #>
    <#@ include file="AsyncExtensions.ttinclude" #>

# Misc notes

1. AsyncGenerator does not generate async version of methods in object inheritance chain, so for example if you registered A, only BeginMethod1 will be generated.

    class A : B
    {
        BeginMethod1
    }
    class B
    {
       BeginMethod2
    }



# License

Licensed under the MIT