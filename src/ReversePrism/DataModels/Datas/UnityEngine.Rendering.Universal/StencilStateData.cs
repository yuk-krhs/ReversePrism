using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 OverrideStencilState                     ModelPrimitiveType bool bool bool Bool
    // 014 StencilReference                         ModelPrimitiveType int int int Int32
    // 018 StencilCompareFunction                   ModelEnumType CompareFunction CompareFunction CompareFunction Int32
    // 01C PassOperation                            ModelEnumType StencilOp StencilOp StencilOp Int32
    // 020 FailOperation                            ModelEnumType StencilOp StencilOp StencilOp Int32
    // 024 ZFailOperation                           ModelEnumType StencilOp StencilOp StencilOp Int32
    public partial class StencilStateData : DataModel
    {
        public bool                                     OverrideStencilState                    { get; set; }
        public int                                      StencilReference                        { get; set; }
        public CompareFunction                          StencilCompareFunction                  { get; set; }
        public StencilOp                                PassOperation                           { get; set; }
        public StencilOp                                FailOperation                           { get; set; }
        public StencilOp                                ZFailOperation                          { get; set; }

        public static StencilStateData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StencilStateData() { Pointer= p0 };

            value.OverrideStencilState                      = GetBool(new IntPtr(p + 0x010)); // 0x10 OverrideStencilState        ( ModelPrimitiveType bool bool bool Bool )
            value.StencilReference                          = GetInt32(new IntPtr(p + 0x014)); // 0x14 StencilReference            ( ModelPrimitiveType int int int Int32 )
            value.StencilCompareFunction                    = (CompareFunction)GetInt32(new IntPtr(p + 0x018)); // 0x18 StencilCompareFunction      ( ModelEnumType CompareFunction CompareFunction CompareFunction Int32 )
            value.PassOperation                             = (StencilOp)GetInt32(new IntPtr(p + 0x01C)); // 0x1C PassOperation               ( ModelEnumType StencilOp StencilOp StencilOp Int32 )
            value.FailOperation                             = (StencilOp)GetInt32(new IntPtr(p + 0x020)); // 0x20 FailOperation               ( ModelEnumType StencilOp StencilOp StencilOp Int32 )
            value.ZFailOperation                            = (StencilOp)GetInt32(new IntPtr(p + 0x024)); // 0x24 ZFailOperation              ( ModelEnumType StencilOp StencilOp StencilOp Int32 )

            return value;
        }
    }
}
