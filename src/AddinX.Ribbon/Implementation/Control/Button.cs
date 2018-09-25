using System;
using System.Xml.Linq;
using AddinX.Ribbon.Contract;
using AddinX.Ribbon.Contract.Command;
using AddinX.Ribbon.Contract.Control.Button;
using AddinX.Ribbon.Contract.Enums;
using AddinX.Ribbon.Implementation.Command;

namespace AddinX.Ribbon.Implementation.Control {
    public class Button : Control<IButton,IButtonCommand>, IButton {

        public Button() :base("button") {
            NormalSize();
            NoImage();
            HideLabel();
        }

        protected override IButton Interface => this;

        #region Implementation of IRibbonCommands<out IButtonCommand>

        public void Callback(Action<IButtonCommand> builder) {
            builder(GetCommand<ButtonCommand>());
        }

        #endregion
    }
}