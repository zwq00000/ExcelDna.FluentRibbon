﻿using System;
using AddinX.Ribbon.Contract.Command;
using AddinX.Ribbon.Contract.Control.Item;

namespace AddinX.Ribbon.Contract.Control.Gallery
{
    public interface IGallery :IRibbonId<IGallery>,IRibbonGalleryExtra<IGallery>,
            IRibbonImage<IGallery>,IRibbonItemImage<IGallery>,IRibbonItemLabel<IGallery>,
            IRibbonLabel<IGallery>,IRibbonDynamic<IGallery, IItems>,IRibbonSize<IGallery>,
            IRibbonCallback<IGalleryCommand>
        //IGalleryExtra, IGalleryId,
        //IGalleryImage, IGalleryItemImage, IGalleryItemLabel,
        //IGalleryLabel, IGalleryItems, IGallerySize
    {
        IGallery AddButtons(Action<IGalleryControls> items);

    }
}