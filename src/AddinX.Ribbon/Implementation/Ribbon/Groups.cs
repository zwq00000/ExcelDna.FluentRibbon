﻿using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using AddinX.Ribbon.Contract;
using AddinX.Ribbon.Contract.Ribbon.Group;
using AddinX.Ribbon.Implementation.Control;

namespace AddinX.Ribbon.Implementation.Ribbon {
    public class Groups : AddInList<Group>, IGroups {
        
        public Groups() {

        }

        public IGroup AddGroup(string label) {
            var tab = new Group();
            tab.SetLabel(label);
            InnerList.Add(tab);
            return tab;
        }

        protected internal override IEnumerable<XElement> ToXml(XNamespace ns) {
            return InnerList.Select(
                gp => gp.ToXml(ns)).ToArray();
        }
    }
}