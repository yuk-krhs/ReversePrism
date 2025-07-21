using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CurNode                                  ModelClassType DoubleLinkAxis DoubleLinkAxis DoubleLinkAxis Pointer
    // 018 RootDepth                                ModelPrimitiveType int int int Int32
    // 01C CurDepth                                 ModelPrimitiveType int int int Int32
    // 020 IsMatch                                  ModelPrimitiveType bool bool bool Bool
    public partial class AxisElement : DataModel
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
            var value   = new AxisElement() { Pointer= p0 };

            value.CurNode                                   = GetObject<DoubleLinkAxis>(new IntPtr(p + 0x010), ReversePrism.DataModels.DoubleLinkAxis.FromPointer); // 0x10 CurNode                     ( ModelClassType DoubleLinkAxis DoubleLinkAxis DoubleLinkAxis Pointer )
            value.RootDepth                                 = GetInt32(new IntPtr(p + 0x018)); // 0x18 RootDepth                   ( ModelPrimitiveType int int int Int32 )
            value.CurDepth                                  = GetInt32(new IntPtr(p + 0x01C)); // 0x1C CurDepth                    ( ModelPrimitiveType int int int Int32 )
            value.IsMatch                                   = GetBool(new IntPtr(p + 0x020)); // 0x20 IsMatch                     ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
