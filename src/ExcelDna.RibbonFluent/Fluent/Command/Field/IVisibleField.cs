using System;

namespace ExcelDna.Fluent.Command.Field {
    public interface IVisibleField {
        /// <summary>
        /// getVisible
        /// �ص�
        /// VBA��Sub GetVisible(control As IRibbonControl, ByRef returnedVal)
        /// C#��bool GetVisible(IRibbonControl control)
        /// </summary>
        Func<bool> getVisible { get; set; }
    }
}