﻿using System;
using System.Xml.Linq;
using ExcelDna.Fluent.Command;
using ExcelDna.Fluent.Command.Field;

namespace AddinX.Fluent.Impl.Command {
    public class DialogBoxLauncherCommand : AbstractCommand, IDialogBoxLauncherCommand, IVisibleField, IEnabledField,
        IActionField {
        public Action onAction { get; set; }
        public Func<bool> getEnabled { get; set; }
        public Func<bool> getVisible { get; set; }

        public IDialogBoxLauncherCommand OnAction(Action act) {
            onAction = act;
            return this;
        }

        public IDialogBoxLauncherCommand GetVisible(Func<bool> condition) {
            getVisible = condition;
            return this;
        }

        public IDialogBoxLauncherCommand GetEnabled(Func<bool> condition) {
            getEnabled = condition;
            return this;
        }

        #region Implementation of ICommand

        /// <summary>
        ///     写入回调Xml属性
        /// </summary>
        /// <param name="element"></param>
        protected internal override void WriteXml(XElement element) {
            AddGetEnabled(element, getEnabled);
            AddGetVisible(element, getVisible);
            AddGetVisible(element, getVisible);
        }

        #endregion
    }
}