﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyUnit.extra.cs files to add code to generated quantities.
//     Add Extensions\MyUnitExtensions.cs to decorate quantities with new behavior.
//     Add UnitDefinitions\MyUnit.json and run GeneratUnits.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Copyright (c) 2007 Andreas Gullberg Larsen (angularsen@gmail.com).
// https://github.com/angularsen/UnitsNet
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using UnitsNet.Units;
using Xunit;

// Disable build warning CS1718: Comparison made to same variable; did you mean to compare something else?
#pragma warning disable 1718

// ReSharper disable once CheckNamespace
namespace UnitsNet.Tests
{
    /// <summary>
    /// Test of DynamicViscosity.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class DynamicViscosityTestsBase
    {
        protected abstract double CentipoiseInOneNewtonSecondPerMeterSquared { get; }
        protected abstract double MillipascalSecondsInOneNewtonSecondPerMeterSquared { get; }
        protected abstract double NewtonSecondsPerMeterSquaredInOneNewtonSecondPerMeterSquared { get; }
        protected abstract double PascalSecondsInOneNewtonSecondPerMeterSquared { get; }
        protected abstract double PoiseInOneNewtonSecondPerMeterSquared { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double CentipoiseTolerance { get { return 1e-5; } }
        protected virtual double MillipascalSecondsTolerance { get { return 1e-5; } }
        protected virtual double NewtonSecondsPerMeterSquaredTolerance { get { return 1e-5; } }
        protected virtual double PascalSecondsTolerance { get { return 1e-5; } }
        protected virtual double PoiseTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void NewtonSecondPerMeterSquaredToDynamicViscosityUnits()
        {
            DynamicViscosity newtonsecondpermetersquared = DynamicViscosity.FromNewtonSecondsPerMeterSquared(1);
            AssertEx.EqualTolerance(CentipoiseInOneNewtonSecondPerMeterSquared, newtonsecondpermetersquared.Centipoise, CentipoiseTolerance);
            AssertEx.EqualTolerance(MillipascalSecondsInOneNewtonSecondPerMeterSquared, newtonsecondpermetersquared.MillipascalSeconds, MillipascalSecondsTolerance);
            AssertEx.EqualTolerance(NewtonSecondsPerMeterSquaredInOneNewtonSecondPerMeterSquared, newtonsecondpermetersquared.NewtonSecondsPerMeterSquared, NewtonSecondsPerMeterSquaredTolerance);
            AssertEx.EqualTolerance(PascalSecondsInOneNewtonSecondPerMeterSquared, newtonsecondpermetersquared.PascalSeconds, PascalSecondsTolerance);
            AssertEx.EqualTolerance(PoiseInOneNewtonSecondPerMeterSquared, newtonsecondpermetersquared.Poise, PoiseTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, DynamicViscosity.From(1, DynamicViscosityUnit.Centipoise).Centipoise, CentipoiseTolerance);
            AssertEx.EqualTolerance(1, DynamicViscosity.From(1, DynamicViscosityUnit.MillipascalSecond).MillipascalSeconds, MillipascalSecondsTolerance);
            AssertEx.EqualTolerance(1, DynamicViscosity.From(1, DynamicViscosityUnit.NewtonSecondPerMeterSquared).NewtonSecondsPerMeterSquared, NewtonSecondsPerMeterSquaredTolerance);
            AssertEx.EqualTolerance(1, DynamicViscosity.From(1, DynamicViscosityUnit.PascalSecond).PascalSeconds, PascalSecondsTolerance);
            AssertEx.EqualTolerance(1, DynamicViscosity.From(1, DynamicViscosityUnit.Poise).Poise, PoiseTolerance);
        }

        [Fact]
        public void As()
        {
            var newtonsecondpermetersquared = DynamicViscosity.FromNewtonSecondsPerMeterSquared(1);
            AssertEx.EqualTolerance(CentipoiseInOneNewtonSecondPerMeterSquared, newtonsecondpermetersquared.As(DynamicViscosityUnit.Centipoise), CentipoiseTolerance);
            AssertEx.EqualTolerance(MillipascalSecondsInOneNewtonSecondPerMeterSquared, newtonsecondpermetersquared.As(DynamicViscosityUnit.MillipascalSecond), MillipascalSecondsTolerance);
            AssertEx.EqualTolerance(NewtonSecondsPerMeterSquaredInOneNewtonSecondPerMeterSquared, newtonsecondpermetersquared.As(DynamicViscosityUnit.NewtonSecondPerMeterSquared), NewtonSecondsPerMeterSquaredTolerance);
            AssertEx.EqualTolerance(PascalSecondsInOneNewtonSecondPerMeterSquared, newtonsecondpermetersquared.As(DynamicViscosityUnit.PascalSecond), PascalSecondsTolerance);
            AssertEx.EqualTolerance(PoiseInOneNewtonSecondPerMeterSquared, newtonsecondpermetersquared.As(DynamicViscosityUnit.Poise), PoiseTolerance);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            DynamicViscosity newtonsecondpermetersquared = DynamicViscosity.FromNewtonSecondsPerMeterSquared(1);
            AssertEx.EqualTolerance(1, DynamicViscosity.FromCentipoise(newtonsecondpermetersquared.Centipoise).NewtonSecondsPerMeterSquared, CentipoiseTolerance);
            AssertEx.EqualTolerance(1, DynamicViscosity.FromMillipascalSeconds(newtonsecondpermetersquared.MillipascalSeconds).NewtonSecondsPerMeterSquared, MillipascalSecondsTolerance);
            AssertEx.EqualTolerance(1, DynamicViscosity.FromNewtonSecondsPerMeterSquared(newtonsecondpermetersquared.NewtonSecondsPerMeterSquared).NewtonSecondsPerMeterSquared, NewtonSecondsPerMeterSquaredTolerance);
            AssertEx.EqualTolerance(1, DynamicViscosity.FromPascalSeconds(newtonsecondpermetersquared.PascalSeconds).NewtonSecondsPerMeterSquared, PascalSecondsTolerance);
            AssertEx.EqualTolerance(1, DynamicViscosity.FromPoise(newtonsecondpermetersquared.Poise).NewtonSecondsPerMeterSquared, PoiseTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            DynamicViscosity v = DynamicViscosity.FromNewtonSecondsPerMeterSquared(1);
            AssertEx.EqualTolerance(-1, -v.NewtonSecondsPerMeterSquared, NewtonSecondsPerMeterSquaredTolerance);
            AssertEx.EqualTolerance(2, (DynamicViscosity.FromNewtonSecondsPerMeterSquared(3)-v).NewtonSecondsPerMeterSquared, NewtonSecondsPerMeterSquaredTolerance);
            AssertEx.EqualTolerance(2, (v + v).NewtonSecondsPerMeterSquared, NewtonSecondsPerMeterSquaredTolerance);
            AssertEx.EqualTolerance(10, (v*10).NewtonSecondsPerMeterSquared, NewtonSecondsPerMeterSquaredTolerance);
            AssertEx.EqualTolerance(10, (10*v).NewtonSecondsPerMeterSquared, NewtonSecondsPerMeterSquaredTolerance);
            AssertEx.EqualTolerance(2, (DynamicViscosity.FromNewtonSecondsPerMeterSquared(10)/5).NewtonSecondsPerMeterSquared, NewtonSecondsPerMeterSquaredTolerance);
            AssertEx.EqualTolerance(2, DynamicViscosity.FromNewtonSecondsPerMeterSquared(10)/DynamicViscosity.FromNewtonSecondsPerMeterSquared(5), NewtonSecondsPerMeterSquaredTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            DynamicViscosity oneNewtonSecondPerMeterSquared = DynamicViscosity.FromNewtonSecondsPerMeterSquared(1);
            DynamicViscosity twoNewtonSecondsPerMeterSquared = DynamicViscosity.FromNewtonSecondsPerMeterSquared(2);

            Assert.True(oneNewtonSecondPerMeterSquared < twoNewtonSecondsPerMeterSquared);
            Assert.True(oneNewtonSecondPerMeterSquared <= twoNewtonSecondsPerMeterSquared);
            Assert.True(twoNewtonSecondsPerMeterSquared > oneNewtonSecondPerMeterSquared);
            Assert.True(twoNewtonSecondsPerMeterSquared >= oneNewtonSecondPerMeterSquared);

            Assert.False(oneNewtonSecondPerMeterSquared > twoNewtonSecondsPerMeterSquared);
            Assert.False(oneNewtonSecondPerMeterSquared >= twoNewtonSecondsPerMeterSquared);
            Assert.False(twoNewtonSecondsPerMeterSquared < oneNewtonSecondPerMeterSquared);
            Assert.False(twoNewtonSecondsPerMeterSquared <= oneNewtonSecondPerMeterSquared);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            DynamicViscosity newtonsecondpermetersquared = DynamicViscosity.FromNewtonSecondsPerMeterSquared(1);
            Assert.Equal(0, newtonsecondpermetersquared.CompareTo(newtonsecondpermetersquared));
            Assert.True(newtonsecondpermetersquared.CompareTo(DynamicViscosity.Zero) > 0);
            Assert.True(DynamicViscosity.Zero.CompareTo(newtonsecondpermetersquared) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            DynamicViscosity newtonsecondpermetersquared = DynamicViscosity.FromNewtonSecondsPerMeterSquared(1);
            Assert.Throws<ArgumentException>(() => newtonsecondpermetersquared.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            DynamicViscosity newtonsecondpermetersquared = DynamicViscosity.FromNewtonSecondsPerMeterSquared(1);
            Assert.Throws<ArgumentNullException>(() => newtonsecondpermetersquared.CompareTo(null));
        }


        [Fact]
        public void EqualityOperators()
        {
            DynamicViscosity a = DynamicViscosity.FromNewtonSecondsPerMeterSquared(1);
            DynamicViscosity b = DynamicViscosity.FromNewtonSecondsPerMeterSquared(2);

// ReSharper disable EqualExpressionComparison
            Assert.True(a == a);
            Assert.True(a != b);

            Assert.False(a == b);
            Assert.False(a != a);
// ReSharper restore EqualExpressionComparison
        }

        [Fact]
        public void EqualsIsImplemented()
        {
            DynamicViscosity v = DynamicViscosity.FromNewtonSecondsPerMeterSquared(1);
            Assert.True(v.Equals(DynamicViscosity.FromNewtonSecondsPerMeterSquared(1)));
            Assert.False(v.Equals(DynamicViscosity.Zero));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            DynamicViscosity newtonsecondpermetersquared = DynamicViscosity.FromNewtonSecondsPerMeterSquared(1);
            Assert.False(newtonsecondpermetersquared.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            DynamicViscosity newtonsecondpermetersquared = DynamicViscosity.FromNewtonSecondsPerMeterSquared(1);
            Assert.False(newtonsecondpermetersquared.Equals(null));
        }
    }
}
