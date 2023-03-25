﻿using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace H.Generators;

[Generator]
public class RoutedEventGenerator : IIncrementalGenerator
{
    #region Constants

    private const string Id = "REG";

    #endregion

    #region Methods

    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        var framework = context.DetectFramework();

        context.SyntaxProvider
            .ForAttributeWithMetadataName("DependencyPropertyGenerator.RoutedEventAttribute")
            .SelectManyAllAttributesOfCurrentClassSyntax()
            .Combine(framework)
            .SelectAndReportExceptions(PrepareData, context, Id)
            .WhereNotNull()
            .SelectAndReportExceptions(GetSourceCode, context, Id)
            .AddSource(context);
        context.SyntaxProvider
            .ForAttributeWithMetadataName("DependencyPropertyGenerator.RoutedEventAttribute`1")
            .SelectManyAllAttributesOfCurrentClassSyntax()
            .Combine(framework)
            .SelectAndReportExceptions(PrepareData, context, Id)
            .WhereNotNull()
            .SelectAndReportExceptions(GetSourceCode, context, Id)
            .AddSource(context);
    }

    private static (ClassData Class, EventData Event)? PrepareData(
        Framework framework,
        (SemanticModel SemanticModel, AttributeData AttributeData, ClassDeclarationSyntax ClassSyntax, INamedTypeSymbol
            ClassSymbol) tuple)
    {
        var (_, attribute, _, classSymbol) = tuple;

        var eventData = attribute.GetEventData(isStaticClass: false);
        if (framework is Framework.Maui ||
            framework is not Framework.Wpf && eventData.IsAttached)
        {
            return null;
        }

        var classData = classSymbol.GetClassData(framework);

        return (classData, eventData);
    }

    private static FileWithName GetSourceCode((ClassData Class, EventData Event) data)
    {
        var category = data.Event.IsAttached
            ? "AttachedEvents"
            : "Events";

        return new FileWithName(
            Name: $"{data.Class.Name}.{category}.{data.Event.Name}.generated.cs",
            Text: SourceGenerationHelper.GenerateRoutedEvent(data.Class, data.Event));
    }

    #endregion
}