namespace FluentReactViewModel.FluentElements
{
    public enum FluentElementTypeEnum
    {
        Stack,
        Dialog,
        DialogFooter,
        ComboBox,

    }
    public abstract class FluentReactElement : ReactDOMElementBase
    {
        public abstract FluentElementTypeEnum ElementType { get; }
    }
}