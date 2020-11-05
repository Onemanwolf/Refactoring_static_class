using AutoFixture.Xunit2;
using AutoFixture;
using System;
using AutoFixture.AutoMoq;

namespace WorkerServiceRefactorStatic.Test
{
    [AttributeUsage(AttributeTargets.Method)]
    public sealed class AutoMoqDataAttribute : AutoDataAttribute
    {
        public AutoMoqDataAttribute() : base(() => new Fixture().Customize(new AutoMoqCustomization()))
        {
        }
    }
}
