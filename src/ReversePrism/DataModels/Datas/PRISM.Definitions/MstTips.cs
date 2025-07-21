using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       ModelPrimitiveType int int int Int32
    // 014 MstTipsCategoryId                        ModelPrimitiveType int int int Int32
    // 018 Weight                                   ModelPrimitiveType int int int Int32
    public partial class MstTips : DataModel
    {
        public int                                      Id                                      { get; set; }
        public int                                      MstTipsCategoryId                       { get; set; }
        public int                                      Weight                                  { get; set; }

        public static MstTips? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstTips() { Pointer= p0 };

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0x10 Id                          ( ModelPrimitiveType int int int Int32 )
            value.MstTipsCategoryId                         = GetInt32(new IntPtr(p + 0x014)); // 0x14 MstTipsCategoryId           ( ModelPrimitiveType int int int Int32 )
            value.Weight                                    = GetInt32(new IntPtr(p + 0x018)); // 0x18 Weight                      ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
