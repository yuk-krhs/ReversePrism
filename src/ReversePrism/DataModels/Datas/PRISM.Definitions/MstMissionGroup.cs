using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       ModelPrimitiveType int int int Int32
    // 014 MissionGroupType                         ModelPrimitiveType int int int Int32
    public partial class MstMissionGroup : DataModel
    {
        public int                                      Id                                      { get; set; }
        public int                                      MissionGroupType                        { get; set; }

        public static MstMissionGroup? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstMissionGroup() { Pointer= p0 };

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0x10 Id                          ( ModelPrimitiveType int int int Int32 )
            value.MissionGroupType                          = GetInt32(new IntPtr(p + 0x014)); // 0x14 MissionGroupType            ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
