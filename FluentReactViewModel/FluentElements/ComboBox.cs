namespace FluentReactViewModel.FluentElements
{
    public class ComboBox : FluentReactElement
    {
        public class IComboBoxOption
        {
            public enum SelectableOptionMenuItemType
            {
                Normal,
                Divider,
                Header
            }
            public string Key { get; set; }
            public string Text { get; set; }
            public SelectableOptionMenuItemType ItemType { get; set; }
        }
        public bool AllowFreeForm { get; set; } = false;
        public string Label { get; set; }
        public IComboBoxOption[] Options { get; set; }
        public override FluentElementTypeEnum ElementType => FluentElementTypeEnum.ComboBox;

    }
}