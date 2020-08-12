namespace FluentReactViewModel.FluentElements
{
    public enum FluentElementTypeEnum
    {
        Stack,
        StackItem,
        Dialog,
        DialogFooter,
        ComboBox,


    }
    public abstract class FluentReactElement : ReactDOMElementBase
    {
        public abstract FluentElementTypeEnum ElementType { get; }
    }
}