﻿// <copyright file="DisposableActionFacts.cs" company="Adam Ralph">
//  Copyright (c) Adam Ralph. All rights reserved.
// </copyright>

namespace Xbehave.Test.Unit.Deprecated
{
    using System;
    using FluentAssertions;
    using Xunit;

    public static class DisposableActionFacts
    {
        [Fact]
        public static void ThrowsArgumentNullExceptionWhenActionIsNull()
        {
            // arrange
            var action = default(Action);

            // act
            var exception = Record.Exception(() => new DisposableAction(action));

            // assert
            exception.Should().BeOfType<ArgumentNullException>();
        }
    }
}