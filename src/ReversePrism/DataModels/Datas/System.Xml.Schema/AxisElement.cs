using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CurNode                                  0001866ED960 ModelClassType DoubleLinkAxis DoubleLinkAxis DoubleLinkAxis Pointer
    // 018 RootDepth                                0001865F2F90 ModelPrimitiveType int int int Int32
    // 01C CurDepth                                 0001865F2F90 ModelPrimitiveType int int int Int32
    // 020 IsMatch                                  000186595210 ModelPrimitiveType bool bool bool Bool
    public partial class AxisElement
    {
        public DoubleLinkAxis?                          CurNode                                 { get; set; }
        public int                                      RootDepth                               { get; set; }
        public int                                      CurDepth                                { get; set; }
        public bool                                     IsMatch                                 { get; set; }

        public static AxisElement? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AxisElement();

            value.CurNode                                   = GetObject<DoubleLinkAxis>(new IntPtr(p + 0x010), ReversePrism.DataModels.DoubleLinkAxis.FromPointer); // 0270D74D3FB8 0x10 CurNode                     ( 0001866ED960 ModelClassType DoubleLinkAxis DoubleLinkAxis DoubleLinkAxis Pointer )
            value.RootDepth                                 = GetInt32(new IntPtr(p + 0x018)); // 0270D74D3FD8 0x18 RootDepth                   ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.CurDepth                                  = GetInt32(new IntPtr(p + 0x01C)); // 0270D74D3FF8 0x1C CurDepth                    ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.IsMatch                                   = GetBool(new IntPtr(p + 0x020)); // 0270D74D4018 0x20 IsMatch                     ( 000186595210 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
