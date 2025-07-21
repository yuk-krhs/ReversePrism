using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 OutPt1                                   ModelClassType OutPt OutPt OutPt Pointer
    // 018 OutPt2                                   ModelClassType OutPt OutPt OutPt Pointer
    // 020 OffPt                                    ModelEnumType IntPoint IntPoint IntPoint Int32
    public partial class Join : DataModel
    {
        public OutPt?                                   OutPt1                                  { get; set; }
        public OutPt?                                   OutPt2                                  { get; set; }
        public IntPoint                                 OffPt                                   { get; set; }

        public static Join? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Join() { Pointer= p0 };

            value.OutPt1                                    = GetObject<OutPt>(new IntPtr(p + 0x010), ReversePrism.DataModels.OutPt.FromPointer); // 0x10 OutPt1                      ( ModelClassType OutPt OutPt OutPt Pointer )
            value.OutPt2                                    = GetObject<OutPt>(new IntPtr(p + 0x018), ReversePrism.DataModels.OutPt.FromPointer); // 0x18 OutPt2                      ( ModelClassType OutPt OutPt OutPt Pointer )
            value.OffPt                                     = (IntPoint)GetInt32(new IntPtr(p + 0x020)); // 0x20 OffPt                       ( ModelEnumType IntPoint IntPoint IntPoint Int32 )

            return value;
        }
    }
}
