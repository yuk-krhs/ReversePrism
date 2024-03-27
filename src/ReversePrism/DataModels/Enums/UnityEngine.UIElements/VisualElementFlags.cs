using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum VisualElementFlags
    {
        WorldTransformDirty,
        WorldTransformInverseDirty,
        WorldClipDirty,
        BoundingBoxDirty,
        WorldBoundingBoxDirty,
        EventCallbackParentCategoriesDirty,
        LayoutManual,
        CompositeRoot,
        RequireMeasureFunction,
        EnableViewDataPersistence,
        DisableClipping,
        NeedsAttachToPanelEvent,
        HierarchyDisplayed,
        StyleInitialized,
        Init,
    }
}
