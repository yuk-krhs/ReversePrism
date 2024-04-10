using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Indentation                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 M_Logger                                 000186654050 ModelClassType RenderGraphLogger RenderGraphLogger RenderGraphLogger Pointer
    // 020 M_Disposed                               000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class RenderGraphLogIndent : DataModel
    {
        public int                                      M_Indentation                           { get; set; }
        public RenderGraphLogger?                       M_Logger                                { get; set; }
        public bool                                     M_Disposed                              { get; set; }

        public static RenderGraphLogIndent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RenderGraphLogIndent() { Pointer= p0 };

            value.M_Indentation                             = GetInt32(new IntPtr(p + 0x010)); // 024669108140 0x10 M_Indentation               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_Logger                                  = GetObject<RenderGraphLogger>(new IntPtr(p + 0x018), ReversePrism.DataModels.RenderGraphLogger.FromPointer); // 024669108160 0x18 M_Logger                    ( 000186654050 ModelClassType RenderGraphLogger RenderGraphLogger RenderGraphLogger Pointer )
            value.M_Disposed                                = GetBool(new IntPtr(p + 0x020)); // 024669108180 0x20 M_Disposed                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
