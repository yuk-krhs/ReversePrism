using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum HideFlags
    {
        None,
        HideInHierarchy,
        HideInInspector,
        DontSaveInEditor,
        NotEditable,
        DontSaveInBuild,
        DontUnloadUnusedAsset,
        DontSave,
        HideAndDontSave,
    }
}
