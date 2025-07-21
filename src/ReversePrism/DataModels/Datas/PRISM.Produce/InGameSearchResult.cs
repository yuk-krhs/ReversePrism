using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsSearch                                 ModelPrimitiveType bool bool bool Bool
    // 014 DrawCardCount                            ModelPrimitiveType int int int Int32
    // 018 SucceededSearchCount                     ModelPrimitiveType int int int Int32
    public partial class InGameSearchResult : DataModel
    {
        public bool                                     IsSearch                                { get; set; }
        public int                                      DrawCardCount                           { get; set; }
        public int                                      SucceededSearchCount                    { get; set; }

        public static InGameSearchResult? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InGameSearchResult() { Pointer= p0 };

            value.IsSearch                                  = GetBool(new IntPtr(p + 0x010)); // 0x10 IsSearch                    ( ModelPrimitiveType bool bool bool Bool )
            value.DrawCardCount                             = GetInt32(new IntPtr(p + 0x014)); // 0x14 DrawCardCount               ( ModelPrimitiveType int int int Int32 )
            value.SucceededSearchCount                      = GetInt32(new IntPtr(p + 0x018)); // 0x18 SucceededSearchCount        ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
