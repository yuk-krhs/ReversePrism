using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _disallowMultipleComponentArray          DisallowMultipleComponent[] IL2CPP_TYPE_SZARRAY
    // 008 _executeInEditModeArray                  ExecuteInEditMode[] IL2CPP_TYPE_SZARRAY
    // 010 RequireComponentArray                    ModelClassListType RequireComponent[] RequireComponent[] List<RequireComponent> Pointer
    public partial class AttributeHelperEngine : DataModel
    {
        public List<RequireComponent>?                  RequireComponentArray                   { get; set; }

        public static AttributeHelperEngine? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AttributeHelperEngine() { Pointer= p0 };

            value.RequireComponentArray                     = GetObjectList<RequireComponent>(new IntPtr(p + 0x010), ReversePrism.DataModels.RequireComponent.FromPointer); // 0x10 RequireComponentArray       ( ModelClassListType RequireComponent[] RequireComponent[] List<RequireComponent> Pointer )

            return value;
        }
    }
}
