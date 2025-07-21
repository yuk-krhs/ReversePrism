using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       ModelPrimitiveType int int int Int32
    // 014 MstLoginBonusId                          ModelPrimitiveType int int int Int32
    // 018 ResourceIdList                           ModelPrimitiveListType string[] string[] List<string> Pointer
    public partial class MstLoginBonusGraffiti : DataModel
    {
        public int                                      Id                                      { get; set; }
        public int                                      MstLoginBonusId                         { get; set; }
        public List<string>?                            ResourceIdList                          { get; set; }

        public static MstLoginBonusGraffiti? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstLoginBonusGraffiti() { Pointer= p0 };

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0x10 Id                          ( ModelPrimitiveType int int int Int32 )
            value.MstLoginBonusId                           = GetInt32(new IntPtr(p + 0x014)); // 0x14 MstLoginBonusId             ( ModelPrimitiveType int int int Int32 )
            value.ResourceIdList                            = GetStringList(new IntPtr(p + 0x018)); // 0x18 ResourceIdList              ( ModelPrimitiveListType string[] string[] List<string> Pointer )

            return value;
        }
    }
}
