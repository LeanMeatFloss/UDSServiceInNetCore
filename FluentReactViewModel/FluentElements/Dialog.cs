namespace FluentReactViewModel.FluentElements
{
    public class Dialog : FluentReactElement
    {
        public class DialogContentProperties
        {
            public enum DialogType
            {
                Normal,
                LargeHeader,
                Close
            }
            public string Title { get; set; }
            public string SubText { get; set; }
            public DialogType Type { get; set; }

        }
        public DialogContentProperties DialogContentProps { get; set; }
        public override FluentElementTypeEnum ElementType => FluentElementTypeEnum.Dialog;
    }
}