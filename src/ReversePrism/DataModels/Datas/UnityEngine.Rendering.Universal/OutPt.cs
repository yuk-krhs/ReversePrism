using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Idx                                      ModelPrimitiveType int int int Int32
    // 018 Pt                                       ModelEnumType IntPoint IntPoint IntPoint Int32
    // 048 Next                                     ModelClassType OutPt OutPt OutPt Pointer
    // 050 Prev                                     ModelClassType OutPt OutPt OutPt Pointer
    public partial class OutPt : DataModel
    {
        public int                                      Idx                                     { get; set; }
        public IntPoint                                 Pt                                      { get; set; }
        public OutPt?                                   Next                                    { get; set; }
        public OutPt?                                   Prev                                    { get; set; }

        public static OutPt? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OutPt() { Pointer= p0 };

            value.Idx                                       = GetInt32(new IntPtr(p + 0x010)); // 0x10 Idx                         ( ModelPrimitiveType int int int Int32 )
            value.Pt                                        = (IntPoint)GetInt32(new IntPtr(p + 0x018)); // 0x18 Pt                          ( ModelEnumType IntPoint IntPoint IntPoint Int32 )
            value.Next                                      = GetObject<OutPt>(new IntPtr(p + 0x048), ReversePrism.DataModels.OutPt.FromPointer); // 0x48 Next                        ( ModelClassType OutPt OutPt OutPt Pointer )
            value.Prev                                      = GetObject<OutPt>(new IntPtr(p + 0x050), ReversePrism.DataModels.OutPt.FromPointer); // 0x50 Prev                        ( ModelClassType OutPt OutPt OutPt Pointer )

            return value;
        }
    }
}
