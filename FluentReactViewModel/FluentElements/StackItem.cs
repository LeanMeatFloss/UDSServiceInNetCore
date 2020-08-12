namespace FluentReactViewModel.FluentElements
{
    public class StackItem : FluentReactElement
    {
        public override FluentElementTypeEnum ElementType => FluentElementTypeEnum.StackItem;
        public int? Grow { get; set; }
    }
}