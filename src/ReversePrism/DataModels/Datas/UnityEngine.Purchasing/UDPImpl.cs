using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 M_Bindings                               ModelClassType INativeUDPStore INativeUDPStore INativeUDPStore Pointer
    // 068 m_UserInfo                               <object> IL2CPP_TYPE_OBJECT
    // 070 M_LastInitError                          ModelPrimitiveType string string string String
    // 000 k_Unknown                                string IL2CPP_TYPE_STRING
    // 078 M_Initialized                            ModelPrimitiveType bool bool bool Bool
    // 000 PURCHASE_PENDING_CODE                    int IL2CPP_TYPE_I4
    // 080 m_DeferredCallback                       Action`1<Product> IL2CPP_TYPE_GENERICINST
    // 000 k_Errorcode                              string IL2CPP_TYPE_STRING
    public partial class UDPImpl : DataModel
    {
        public INativeUDPStore?                         M_Bindings                              { get; set; }
        public string                                   M_LastInitError                         { get; set; }
        public bool                                     M_Initialized                           { get; set; }

        public static UDPImpl? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UDPImpl() { Pointer= p0 };

            value.M_Bindings                                = GetObject<INativeUDPStore>(new IntPtr(p + 0x060), ReversePrism.DataModels.INativeUDPStore.FromPointer); // 0x60 M_Bindings                  ( ModelClassType INativeUDPStore INativeUDPStore INativeUDPStore Pointer )
            value.M_LastInitError                           = GetString(new IntPtr(p + 0x070)); // 0x70 M_LastInitError             ( ModelPrimitiveType string string string String )
            value.M_Initialized                             = GetBool(new IntPtr(p + 0x078)); // 0x78 M_Initialized               ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
