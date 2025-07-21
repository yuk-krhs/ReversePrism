using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MainDraw                                 ModelPrimitiveType bool bool bool Bool
    // 011 IsBase                                   ModelPrimitiveType bool bool bool Bool
    public partial class PrismRenderData : DataModel
    {
        public bool                                     MainDraw                                { get; set; }
        public bool                                     IsBase                                  { get; set; }

        public static PrismRenderData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PrismRenderData() { Pointer= p0 };

            value.MainDraw                                  = GetBool(new IntPtr(p + 0x010)); // 0x10 MainDraw                    ( ModelPrimitiveType bool bool bool Bool )
            value.IsBase                                    = GetBool(new IntPtr(p + 0x011)); // 0x11 IsBase                      ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
