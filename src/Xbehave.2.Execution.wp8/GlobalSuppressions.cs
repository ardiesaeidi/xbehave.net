// <copyright file="GlobalSuppressions.cs" company="xBehave.net contributors">
//  Copyright (c) xBehave.net contributors. All rights reserved.
// </copyright>

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage(
    "Microsoft.Design",
    "CA2210:AssembliesShouldHaveValidStrongNames",
    Justification = "Windows Phone Silverlight 8 assemblies don't support signing.")]
