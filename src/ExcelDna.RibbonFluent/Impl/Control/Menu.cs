﻿using System;
using AddinX.Fluent.Impl.Command;
using AddinX.Fluent.Impl.Ribbon;
using ExcelDna.Fluent.Command;
using ExcelDna.Fluent.Control;

namespace AddinX.Fluent.Impl.Control {
    public class Menu : ControlContainer<IMenu, Controls>, IMenu {
        public Menu() : base("menu") {
            NoImage();
        }

        public IMenu Items(Action<IMenuControls> builder) {
            builder.Invoke(base.InnerItems);
            return this;
        }

        #region Implementation of IRibbonCallback<out IMenu,out IMenuCommand>

        public void Callback(Action<IMenuCommand> builder) {
            builder(GetCommand<MenuCommand>());
        }

        #endregion

        #region Overrides of Control<IMenu>

        protected override IMenu Interface => this;

        #endregion

        #region Implementation of IRibbonCallback<out IMenu,IMenuCommand>

        public void Callback(IMenuCommand command) {
            base.SetCommand(command);
        }

        #endregion
    }
}