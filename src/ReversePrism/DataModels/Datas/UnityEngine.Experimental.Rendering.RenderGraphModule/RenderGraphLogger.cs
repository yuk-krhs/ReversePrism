using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 m_LogMap                                 Dictionary`2<string, StringBuilder> IL2CPP_TYPE_GENERICINST
    // 018 M_CurrentBuilder                         000186676650 ModelClassType StringBuilder StringBuilder StringBuilder Pointer
    // 020 M_CurrentIndentation                     0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class RenderGraphLogger : DataModel
    {
        public StringBuilder?                           M_CurrentBuilder                        { get; set; }
        public int                                      M_CurrentIndentation                    { get; set; }

        public static RenderGraphLogger? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RenderGraphLogger() { Pointer= p0 };

            value.M_CurrentBuilder                          = GetObject<StringBuilder>(new IntPtr(p + 0x018), ReversePrism.DataModels.StringBuilder.FromPointer); // 0246690F4A70 0x18 M_CurrentBuilder            ( 000186676650 ModelClassType StringBuilder StringBuilder StringBuilder Pointer )
            value.M_CurrentIndentation                      = GetInt32(new IntPtr(p + 0x020)); // 0246690F4A90 0x20 M_CurrentIndentation        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
