﻿using ExcelDna.Fluent.Command;
using ExcelDna.Integration.CustomUI;

namespace ExcelDna.Fluent {
    public interface IRibbonFluent : IRibbonFluentCallback {
        string GetRibbonXml();

        ICommand FindCallback(string id);

        void OnClosing();

        void OnOpening();
    }

    public interface IRibbonFluentCallback {
        void OnAction(IRibbonControl control);
        void OnActionPressed(IRibbonControl control, bool pressed);
        void OnItemAction(IRibbonControl control, string selectedId, int selectedIndex);
        bool GetEnabled(IRibbonControl control);
        bool GetVisible(IRibbonControl control);
        bool GetPressed(IRibbonControl control);
        object GetImage(IRibbonControl control);
        string GetText(IRibbonControl control);
        string GetDescription(IRibbonControl control);
        void OnChange(IRibbonControl control, string newValue);
        int GetItemCount(IRibbonControl control);
        object GetItemId(IRibbonControl control, int index);
        object GetItemImage(IRibbonControl control, int index);
        string GetItemLabel(IRibbonControl control, int index);
        string GetItemScreenTip(IRibbonControl control, int index);
        string GetItemSuperTip(IRibbonControl control, int index);
        string GetLabel(IRibbonControl control);
        int GetSelectedItemIndex(IRibbonControl control);

        /// <summary>
        /// getSize Callback
        /// </summary>
        /// <param name="control"></param>
        /// <returns></returns>
        string GetSize(IRibbonControl control);
    }
}