using System.Collections.Generic;
using System;

namespace FluentReactViewModel
{
    public abstract class ReactDOMElementBase
    {
        public object[] ChildrenList { get; set; }
        public Dictionary<string, string> CssDict { get; set; }
    }
}
