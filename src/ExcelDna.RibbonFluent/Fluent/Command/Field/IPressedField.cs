using System;

namespace ExcelDna.Fluent.Command.Field {
    public interface IPressedField {
        /// <summary>
        /// getPressed
        /// �ص�
        /// VBA��Sub GetPressed(control As IRibbonControl, ByRef returnedVal)
        /// C#��bool GetPressed(IRibbonControl control)
        /// </summary>
        Func<bool> getPressed { get; set; }
    }
}