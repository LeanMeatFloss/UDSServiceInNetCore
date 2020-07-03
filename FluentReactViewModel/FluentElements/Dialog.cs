namespace FluentReactViewModel.FluentElements
{
    public class Dialog : FluentReactElement
    {
        public string Title { get; set; }
        public string SubText { get; set; }
        public override FluentElementTypeEnum ElementType => FluentElementTypeEnum.Dialog;
        public DialogFooter Footer { get; set; }
    }
}