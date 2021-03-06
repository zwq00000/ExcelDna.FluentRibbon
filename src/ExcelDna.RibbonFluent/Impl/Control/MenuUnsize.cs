﻿using System;
using AddinX.Fluent.Impl.Ribbon;
using ExcelDna.Fluent.Control;

namespace AddinX.Fluent.Impl.Control {
    public class MenuUnsize : ControlContainer<IMenuUnsize, Controls>, IMenuUnsize {
        public MenuUnsize() : base("menu") {
            NoImage();
        }


        protected override IMenuUnsize Interface => this;


        public IMenuUnsize Items(Action<IMenuUnsizeControls> builder) {
            builder?.Invoke(base.InnerItems);
            return this;
        }
    }
}