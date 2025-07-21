using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 EnvironmentDescriptionPostfix            string IL2CPP_TYPE_STRING
    // 000 SuccessString                            string IL2CPP_TYPE_STRING
    // 000 RetrieveProductsDescriptionCount         int IL2CPP_TYPE_I4
    // 088 M_CurrentDialog                          ModelClassType DialogRequest DialogRequest DialogRequest Pointer
    // 090 M_LastSelectedDropdownIndex              ModelPrimitiveType int int int Int32
    // 098 M_UIFakeStoreWindowObject                ModelClassType GameObject GameObject GameObject Pointer
    // 0A0 M_EventSystem                            ModelClassType GameObject GameObject GameObject Pointer
    // 0A8 M_Util                                   ModelClassType IUtil IUtil IUtil Pointer
    public partial class UIFakeStore : DataModel
    {
        public DialogRequest?                           M_CurrentDialog                         { get; set; }
        public int                                      M_LastSelectedDropdownIndex             { get; set; }
        public GameObject?                              M_UIFakeStoreWindowObject               { get; set; }
        public GameObject?                              M_EventSystem                           { get; set; }
        public IUtil?                                   M_Util                                  { get; set; }

        public static UIFakeStore? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UIFakeStore() { Pointer= p0 };

            value.M_CurrentDialog                           = GetObject<DialogRequest>(new IntPtr(p + 0x088), ReversePrism.DataModels.DialogRequest.FromPointer); // 0x88 M_CurrentDialog             ( ModelClassType DialogRequest DialogRequest DialogRequest Pointer )
            value.M_LastSelectedDropdownIndex               = GetInt32(new IntPtr(p + 0x090)); // 0x90 M_LastSelectedDropdownIndex ( ModelPrimitiveType int int int Int32 )
            value.M_UIFakeStoreWindowObject                 = GetObject<GameObject>(new IntPtr(p + 0x098), ReversePrism.DataModels.GameObject.FromPointer); // 0x98 M_UIFakeStoreWindowObject   ( ModelClassType GameObject GameObject GameObject Pointer )
            value.M_EventSystem                             = GetObject<GameObject>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.GameObject.FromPointer); // 0xA0 M_EventSystem               ( ModelClassType GameObject GameObject GameObject Pointer )
            value.M_Util                                    = GetObject<IUtil>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.IUtil.FromPointer); // 0xA8 M_Util                      ( ModelClassType IUtil IUtil IUtil Pointer )

            return value;
        }
    }
}
