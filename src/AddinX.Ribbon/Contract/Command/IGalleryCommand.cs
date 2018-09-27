using System;
using System.Collections.Generic;

namespace AddinX.Ribbon.Contract.Command
{
    public interface IGalleryCommand : ICommand
    {
        IGalleryCommand IsVisible(Func<bool> condition);

        IGalleryCommand IsEnabled(Func<bool> condition);

        IGalleryCommand OnItemAction(Action<int> act);
        
        IGalleryCommand ItemSelectionIndex(Func<int> selectedItemIndex);
        
        IGalleryCommand ItemCounts(Func<int> numberItems);

        IGalleryCommand ItemsId(Func<int, string> itemsId);

        IGalleryCommand ItemsLabel(Func<int, string> itemsLabel);

        IGalleryCommand ItemsScreentip(Func<int,string> itemsScreentip);

        IGalleryCommand ItemsSupertip(Func<int,string> itemsSupertip);

        IGalleryCommand ItemsImage(Func<int,object> itemsImage);
    }
}