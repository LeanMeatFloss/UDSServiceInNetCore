namespace FluentReactViewModel.FluentElements
{
    public class Stack : FluentReactElement
    {
        public class IStackTokens
        {
            public int ChildrenGap { get; set; }

        }
        public override FluentElementTypeEnum ElementType => FluentElementTypeEnum.Stack;
        public bool Wrap { get; set; }

        public bool Horizontal { get; set; }
        public IStackTokens Tokens { get; set; }
    }
}