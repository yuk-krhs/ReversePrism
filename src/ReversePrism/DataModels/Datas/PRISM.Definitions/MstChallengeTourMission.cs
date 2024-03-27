using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       0001865F4260 ModelPrimitiveType int int int Int32
    // 014 MissionType                              0001865F4260 ModelPrimitiveType int int int Int32
    public partial class MstChallengeTourMission
    {
        public int                                      Id                                      { get; set; }
        public int                                      MissionType                             { get; set; }

        public static MstChallengeTourMission? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstChallengeTourMission();

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0270045F89E0 0x10 Id                          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MissionType                               = GetInt32(new IntPtr(p + 0x014)); // 0270045F8A00 0x14 MissionType                 ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
