    namespace AbbatoirIntergrade.GumRuntimes
    {
        #region State Enums
        public enum TextBoxBehaviorTextBoxCategory
        {
            Enabled,
            Disabled,
            Highlighted,
            Selected
        }
        #endregion
        public interface ITextBoxBehavior
        {
            TextBoxBehaviorTextBoxCategory CurrentTextBoxBehaviorTextBoxCategoryState {set;}
        }
    }
