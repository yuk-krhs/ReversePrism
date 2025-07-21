using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 m_RTHandles                              Dictionary`2<int, RTHandle[]> IL2CPP_TYPE_GENERICINST
    // 018 M_RTHandleSystem                         ModelClassType RTHandleSystem RTHandleSystem RTHandleSystem Pointer
    // 020 M_DisposedValue                          ModelPrimitiveType bool bool bool Bool
    public partial class BufferedRTHandleSystem : DataModel
    {
        public RTHandleSystem?                          M_RTHandleSystem                        { get; set; }
        public bool                                     M_DisposedValue                         { get; set; }

        public static BufferedRTHandleSystem? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BufferedRTHandleSystem() { Pointer= p0 };

            value.M_RTHandleSystem                          = GetObject<RTHandleSystem>(new IntPtr(p + 0x018), ReversePrism.DataModels.RTHandleSystem.FromPointer); // 0x18 M_RTHandleSystem            ( ModelClassType RTHandleSystem RTHandleSystem RTHandleSystem Pointer )
            value.M_DisposedValue                           = GetBool(new IntPtr(p + 0x020)); // 0x20 M_DisposedValue             ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
