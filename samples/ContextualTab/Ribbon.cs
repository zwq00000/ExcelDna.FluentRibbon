﻿using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using AddinX.Fluent;
using ExcelDna;
using ExcelDna.Fluent;
using ExcelDna.Fluent.Command;
using ExcelDna.Fluent;
using FluentRibbon = ExcelDna.Fluent.FluentRibbon;

namespace ContextualTab
{
    [ComVisible(true)]
    public class Ribbon : FluentRibbon
    {
        protected override void CreateFluentRibbon(IRibbonBuilder build)
        {
            build.CustomUi.Ribbon.ContextualTabs(tabs =>
                tabs.AddTabSet(set => set.IdMso(TabSetId.TabSetDrawingTools)
                    .Tabs(tab => tab.AddTab("Sample").Id("SampleContextId")
                        .Groups(g => g.AddGroup("Custom group").Id("CustomGroupContextId")
                            .Items(d =>
                            {
                                d.AddButton("Button 1").Id("Button1")
                                    .LargeSize().ImageMso("HappyFace");
                                d.AddButton("Button 2").Id("Button2")
                                    .LargeSize().ImageMso("Bold");
                            })
                        ))));
        }

        protected void CreateRibbonCommand(IRibbonCommands cmds)
        {
            cmds.AddButtonCommand("Button1").OnAction(()=> MessageBox.Show("Button 1 clicked"));

            cmds.AddButtonCommand("Button2").OnAction(() => MessageBox.Show("Button 2 clicked"));
        }

        public override void OnClosing()
        {
            
        }

        public override void OnOpening()
        {
            
        }
    }
}