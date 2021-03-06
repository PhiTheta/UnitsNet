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
    /// Test of RotationalSpeed.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class RotationalSpeedTestsBase
    {
        protected abstract double CentiradiansPerSecondInOneRadianPerSecond { get; }
        protected abstract double DeciradiansPerSecondInOneRadianPerSecond { get; }
        protected abstract double DegreesPerMinuteInOneRadianPerSecond { get; }
        protected abstract double DegreesPerSecondInOneRadianPerSecond { get; }
        protected abstract double MicrodegreesPerSecondInOneRadianPerSecond { get; }
        protected abstract double MicroradiansPerSecondInOneRadianPerSecond { get; }
        protected abstract double MillidegreesPerSecondInOneRadianPerSecond { get; }
        protected abstract double MilliradiansPerSecondInOneRadianPerSecond { get; }
        protected abstract double NanodegreesPerSecondInOneRadianPerSecond { get; }
        protected abstract double NanoradiansPerSecondInOneRadianPerSecond { get; }
        protected abstract double RadiansPerSecondInOneRadianPerSecond { get; }
        protected abstract double RevolutionsPerMinuteInOneRadianPerSecond { get; }
        protected abstract double RevolutionsPerSecondInOneRadianPerSecond { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double CentiradiansPerSecondTolerance { get { return 1e-5; } }
        protected virtual double DeciradiansPerSecondTolerance { get { return 1e-5; } }
        protected virtual double DegreesPerMinuteTolerance { get { return 1e-5; } }
        protected virtual double DegreesPerSecondTolerance { get { return 1e-5; } }
        protected virtual double MicrodegreesPerSecondTolerance { get { return 1e-5; } }
        protected virtual double MicroradiansPerSecondTolerance { get { return 1e-5; } }
        protected virtual double MillidegreesPerSecondTolerance { get { return 1e-5; } }
        protected virtual double MilliradiansPerSecondTolerance { get { return 1e-5; } }
        protected virtual double NanodegreesPerSecondTolerance { get { return 1e-5; } }
        protected virtual double NanoradiansPerSecondTolerance { get { return 1e-5; } }
        protected virtual double RadiansPerSecondTolerance { get { return 1e-5; } }
        protected virtual double RevolutionsPerMinuteTolerance { get { return 1e-5; } }
        protected virtual double RevolutionsPerSecondTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void RadianPerSecondToRotationalSpeedUnits()
        {
            RotationalSpeed radianpersecond = RotationalSpeed.FromRadiansPerSecond(1);
            AssertEx.EqualTolerance(CentiradiansPerSecondInOneRadianPerSecond, radianpersecond.CentiradiansPerSecond, CentiradiansPerSecondTolerance);
            AssertEx.EqualTolerance(DeciradiansPerSecondInOneRadianPerSecond, radianpersecond.DeciradiansPerSecond, DeciradiansPerSecondTolerance);
            AssertEx.EqualTolerance(DegreesPerMinuteInOneRadianPerSecond, radianpersecond.DegreesPerMinute, DegreesPerMinuteTolerance);
            AssertEx.EqualTolerance(DegreesPerSecondInOneRadianPerSecond, radianpersecond.DegreesPerSecond, DegreesPerSecondTolerance);
            AssertEx.EqualTolerance(MicrodegreesPerSecondInOneRadianPerSecond, radianpersecond.MicrodegreesPerSecond, MicrodegreesPerSecondTolerance);
            AssertEx.EqualTolerance(MicroradiansPerSecondInOneRadianPerSecond, radianpersecond.MicroradiansPerSecond, MicroradiansPerSecondTolerance);
            AssertEx.EqualTolerance(MillidegreesPerSecondInOneRadianPerSecond, radianpersecond.MillidegreesPerSecond, MillidegreesPerSecondTolerance);
            AssertEx.EqualTolerance(MilliradiansPerSecondInOneRadianPerSecond, radianpersecond.MilliradiansPerSecond, MilliradiansPerSecondTolerance);
            AssertEx.EqualTolerance(NanodegreesPerSecondInOneRadianPerSecond, radianpersecond.NanodegreesPerSecond, NanodegreesPerSecondTolerance);
            AssertEx.EqualTolerance(NanoradiansPerSecondInOneRadianPerSecond, radianpersecond.NanoradiansPerSecond, NanoradiansPerSecondTolerance);
            AssertEx.EqualTolerance(RadiansPerSecondInOneRadianPerSecond, radianpersecond.RadiansPerSecond, RadiansPerSecondTolerance);
            AssertEx.EqualTolerance(RevolutionsPerMinuteInOneRadianPerSecond, radianpersecond.RevolutionsPerMinute, RevolutionsPerMinuteTolerance);
            AssertEx.EqualTolerance(RevolutionsPerSecondInOneRadianPerSecond, radianpersecond.RevolutionsPerSecond, RevolutionsPerSecondTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, RotationalSpeed.From(1, RotationalSpeedUnit.CentiradianPerSecond).CentiradiansPerSecond, CentiradiansPerSecondTolerance);
            AssertEx.EqualTolerance(1, RotationalSpeed.From(1, RotationalSpeedUnit.DeciradianPerSecond).DeciradiansPerSecond, DeciradiansPerSecondTolerance);
            AssertEx.EqualTolerance(1, RotationalSpeed.From(1, RotationalSpeedUnit.DegreePerMinute).DegreesPerMinute, DegreesPerMinuteTolerance);
            AssertEx.EqualTolerance(1, RotationalSpeed.From(1, RotationalSpeedUnit.DegreePerSecond).DegreesPerSecond, DegreesPerSecondTolerance);
            AssertEx.EqualTolerance(1, RotationalSpeed.From(1, RotationalSpeedUnit.MicrodegreePerSecond).MicrodegreesPerSecond, MicrodegreesPerSecondTolerance);
            AssertEx.EqualTolerance(1, RotationalSpeed.From(1, RotationalSpeedUnit.MicroradianPerSecond).MicroradiansPerSecond, MicroradiansPerSecondTolerance);
            AssertEx.EqualTolerance(1, RotationalSpeed.From(1, RotationalSpeedUnit.MillidegreePerSecond).MillidegreesPerSecond, MillidegreesPerSecondTolerance);
            AssertEx.EqualTolerance(1, RotationalSpeed.From(1, RotationalSpeedUnit.MilliradianPerSecond).MilliradiansPerSecond, MilliradiansPerSecondTolerance);
            AssertEx.EqualTolerance(1, RotationalSpeed.From(1, RotationalSpeedUnit.NanodegreePerSecond).NanodegreesPerSecond, NanodegreesPerSecondTolerance);
            AssertEx.EqualTolerance(1, RotationalSpeed.From(1, RotationalSpeedUnit.NanoradianPerSecond).NanoradiansPerSecond, NanoradiansPerSecondTolerance);
            AssertEx.EqualTolerance(1, RotationalSpeed.From(1, RotationalSpeedUnit.RadianPerSecond).RadiansPerSecond, RadiansPerSecondTolerance);
            AssertEx.EqualTolerance(1, RotationalSpeed.From(1, RotationalSpeedUnit.RevolutionPerMinute).RevolutionsPerMinute, RevolutionsPerMinuteTolerance);
            AssertEx.EqualTolerance(1, RotationalSpeed.From(1, RotationalSpeedUnit.RevolutionPerSecond).RevolutionsPerSecond, RevolutionsPerSecondTolerance);
        }

        [Fact]
        public void As()
        {
            var radianpersecond = RotationalSpeed.FromRadiansPerSecond(1);
            AssertEx.EqualTolerance(CentiradiansPerSecondInOneRadianPerSecond, radianpersecond.As(RotationalSpeedUnit.CentiradianPerSecond), CentiradiansPerSecondTolerance);
            AssertEx.EqualTolerance(DeciradiansPerSecondInOneRadianPerSecond, radianpersecond.As(RotationalSpeedUnit.DeciradianPerSecond), DeciradiansPerSecondTolerance);
            AssertEx.EqualTolerance(DegreesPerMinuteInOneRadianPerSecond, radianpersecond.As(RotationalSpeedUnit.DegreePerMinute), DegreesPerMinuteTolerance);
            AssertEx.EqualTolerance(DegreesPerSecondInOneRadianPerSecond, radianpersecond.As(RotationalSpeedUnit.DegreePerSecond), DegreesPerSecondTolerance);
            AssertEx.EqualTolerance(MicrodegreesPerSecondInOneRadianPerSecond, radianpersecond.As(RotationalSpeedUnit.MicrodegreePerSecond), MicrodegreesPerSecondTolerance);
            AssertEx.EqualTolerance(MicroradiansPerSecondInOneRadianPerSecond, radianpersecond.As(RotationalSpeedUnit.MicroradianPerSecond), MicroradiansPerSecondTolerance);
            AssertEx.EqualTolerance(MillidegreesPerSecondInOneRadianPerSecond, radianpersecond.As(RotationalSpeedUnit.MillidegreePerSecond), MillidegreesPerSecondTolerance);
            AssertEx.EqualTolerance(MilliradiansPerSecondInOneRadianPerSecond, radianpersecond.As(RotationalSpeedUnit.MilliradianPerSecond), MilliradiansPerSecondTolerance);
            AssertEx.EqualTolerance(NanodegreesPerSecondInOneRadianPerSecond, radianpersecond.As(RotationalSpeedUnit.NanodegreePerSecond), NanodegreesPerSecondTolerance);
            AssertEx.EqualTolerance(NanoradiansPerSecondInOneRadianPerSecond, radianpersecond.As(RotationalSpeedUnit.NanoradianPerSecond), NanoradiansPerSecondTolerance);
            AssertEx.EqualTolerance(RadiansPerSecondInOneRadianPerSecond, radianpersecond.As(RotationalSpeedUnit.RadianPerSecond), RadiansPerSecondTolerance);
            AssertEx.EqualTolerance(RevolutionsPerMinuteInOneRadianPerSecond, radianpersecond.As(RotationalSpeedUnit.RevolutionPerMinute), RevolutionsPerMinuteTolerance);
            AssertEx.EqualTolerance(RevolutionsPerSecondInOneRadianPerSecond, radianpersecond.As(RotationalSpeedUnit.RevolutionPerSecond), RevolutionsPerSecondTolerance);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            RotationalSpeed radianpersecond = RotationalSpeed.FromRadiansPerSecond(1);
            AssertEx.EqualTolerance(1, RotationalSpeed.FromCentiradiansPerSecond(radianpersecond.CentiradiansPerSecond).RadiansPerSecond, CentiradiansPerSecondTolerance);
            AssertEx.EqualTolerance(1, RotationalSpeed.FromDeciradiansPerSecond(radianpersecond.DeciradiansPerSecond).RadiansPerSecond, DeciradiansPerSecondTolerance);
            AssertEx.EqualTolerance(1, RotationalSpeed.FromDegreesPerMinute(radianpersecond.DegreesPerMinute).RadiansPerSecond, DegreesPerMinuteTolerance);
            AssertEx.EqualTolerance(1, RotationalSpeed.FromDegreesPerSecond(radianpersecond.DegreesPerSecond).RadiansPerSecond, DegreesPerSecondTolerance);
            AssertEx.EqualTolerance(1, RotationalSpeed.FromMicrodegreesPerSecond(radianpersecond.MicrodegreesPerSecond).RadiansPerSecond, MicrodegreesPerSecondTolerance);
            AssertEx.EqualTolerance(1, RotationalSpeed.FromMicroradiansPerSecond(radianpersecond.MicroradiansPerSecond).RadiansPerSecond, MicroradiansPerSecondTolerance);
            AssertEx.EqualTolerance(1, RotationalSpeed.FromMillidegreesPerSecond(radianpersecond.MillidegreesPerSecond).RadiansPerSecond, MillidegreesPerSecondTolerance);
            AssertEx.EqualTolerance(1, RotationalSpeed.FromMilliradiansPerSecond(radianpersecond.MilliradiansPerSecond).RadiansPerSecond, MilliradiansPerSecondTolerance);
            AssertEx.EqualTolerance(1, RotationalSpeed.FromNanodegreesPerSecond(radianpersecond.NanodegreesPerSecond).RadiansPerSecond, NanodegreesPerSecondTolerance);
            AssertEx.EqualTolerance(1, RotationalSpeed.FromNanoradiansPerSecond(radianpersecond.NanoradiansPerSecond).RadiansPerSecond, NanoradiansPerSecondTolerance);
            AssertEx.EqualTolerance(1, RotationalSpeed.FromRadiansPerSecond(radianpersecond.RadiansPerSecond).RadiansPerSecond, RadiansPerSecondTolerance);
            AssertEx.EqualTolerance(1, RotationalSpeed.FromRevolutionsPerMinute(radianpersecond.RevolutionsPerMinute).RadiansPerSecond, RevolutionsPerMinuteTolerance);
            AssertEx.EqualTolerance(1, RotationalSpeed.FromRevolutionsPerSecond(radianpersecond.RevolutionsPerSecond).RadiansPerSecond, RevolutionsPerSecondTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            RotationalSpeed v = RotationalSpeed.FromRadiansPerSecond(1);
            AssertEx.EqualTolerance(-1, -v.RadiansPerSecond, RadiansPerSecondTolerance);
            AssertEx.EqualTolerance(2, (RotationalSpeed.FromRadiansPerSecond(3)-v).RadiansPerSecond, RadiansPerSecondTolerance);
            AssertEx.EqualTolerance(2, (v + v).RadiansPerSecond, RadiansPerSecondTolerance);
            AssertEx.EqualTolerance(10, (v*10).RadiansPerSecond, RadiansPerSecondTolerance);
            AssertEx.EqualTolerance(10, (10*v).RadiansPerSecond, RadiansPerSecondTolerance);
            AssertEx.EqualTolerance(2, (RotationalSpeed.FromRadiansPerSecond(10)/5).RadiansPerSecond, RadiansPerSecondTolerance);
            AssertEx.EqualTolerance(2, RotationalSpeed.FromRadiansPerSecond(10)/RotationalSpeed.FromRadiansPerSecond(5), RadiansPerSecondTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            RotationalSpeed oneRadianPerSecond = RotationalSpeed.FromRadiansPerSecond(1);
            RotationalSpeed twoRadiansPerSecond = RotationalSpeed.FromRadiansPerSecond(2);

            Assert.True(oneRadianPerSecond < twoRadiansPerSecond);
            Assert.True(oneRadianPerSecond <= twoRadiansPerSecond);
            Assert.True(twoRadiansPerSecond > oneRadianPerSecond);
            Assert.True(twoRadiansPerSecond >= oneRadianPerSecond);

            Assert.False(oneRadianPerSecond > twoRadiansPerSecond);
            Assert.False(oneRadianPerSecond >= twoRadiansPerSecond);
            Assert.False(twoRadiansPerSecond < oneRadianPerSecond);
            Assert.False(twoRadiansPerSecond <= oneRadianPerSecond);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            RotationalSpeed radianpersecond = RotationalSpeed.FromRadiansPerSecond(1);
            Assert.Equal(0, radianpersecond.CompareTo(radianpersecond));
            Assert.True(radianpersecond.CompareTo(RotationalSpeed.Zero) > 0);
            Assert.True(RotationalSpeed.Zero.CompareTo(radianpersecond) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            RotationalSpeed radianpersecond = RotationalSpeed.FromRadiansPerSecond(1);
            Assert.Throws<ArgumentException>(() => radianpersecond.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            RotationalSpeed radianpersecond = RotationalSpeed.FromRadiansPerSecond(1);
            Assert.Throws<ArgumentNullException>(() => radianpersecond.CompareTo(null));
        }


        [Fact]
        public void EqualityOperators()
        {
            RotationalSpeed a = RotationalSpeed.FromRadiansPerSecond(1);
            RotationalSpeed b = RotationalSpeed.FromRadiansPerSecond(2);

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
            RotationalSpeed v = RotationalSpeed.FromRadiansPerSecond(1);
            Assert.True(v.Equals(RotationalSpeed.FromRadiansPerSecond(1)));
            Assert.False(v.Equals(RotationalSpeed.Zero));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            RotationalSpeed radianpersecond = RotationalSpeed.FromRadiansPerSecond(1);
            Assert.False(radianpersecond.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            RotationalSpeed radianpersecond = RotationalSpeed.FromRadiansPerSecond(1);
            Assert.False(radianpersecond.Equals(null));
        }
    }
}
