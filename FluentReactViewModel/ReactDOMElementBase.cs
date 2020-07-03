using System.Collections.Generic;
using System;

namespace FluentReactViewModel
{
    public abstract class ReactDOMElementBase
    {
        public List<ReactDOMElementBase> ChildrenList { get; } = new List<ReactDOMElementBase>();
    }
}
