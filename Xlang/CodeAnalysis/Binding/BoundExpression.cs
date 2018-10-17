using System;

namespace Xlang.CodeAnalysis.Binding
{
    internal abstract class BoundExpression : BoundNode
    {
        public abstract Type Type { get; }
    }
}