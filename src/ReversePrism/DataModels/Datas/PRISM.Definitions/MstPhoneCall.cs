using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       0001865F4260 ModelPrimitiveType int int int Int32
    // 014 MstPhoneUserId                           0001865F4260 ModelPrimitiveType int int int Int32
    // 018 TypeId                                   0001865F4260 ModelPrimitiveType int int int Int32
    // 01C ScenarioId                               0001865F4260 ModelPrimitiveType int int int Int32
    // 020 ScenarioNumber                           0001865F4260 ModelPrimitiveType int int int Int32
    public partial class MstPhoneCall
    {
        public int                                      Id                                      { get; set; }
        public int                                      MstPhoneUserId                          { get; set; }
        public int                                      TypeId                                  { get; set; }
        public int                                      ScenarioId                              { get; set; }
        public int                                      ScenarioNumber                          { get; set; }

        public static MstPhoneCall? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstPhoneCall();

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 027004650190 0x10 Id                          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MstPhoneUserId                            = GetInt32(new IntPtr(p + 0x014)); // 0270046501B0 0x14 MstPhoneUserId              ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.TypeId                                    = GetInt32(new IntPtr(p + 0x018)); // 0270046501D0 0x18 TypeId                      ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.ScenarioId                                = GetInt32(new IntPtr(p + 0x01C)); // 0270046501F0 0x1C ScenarioId                  ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.ScenarioNumber                            = GetInt32(new IntPtr(p + 0x020)); // 027004650210 0x20 ScenarioNumber              ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
