using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       ModelPrimitiveType int int int Int32
    // 018 Name                                     ModelPrimitiveType string string string String
    // 020 Description                              ModelPrimitiveType string string string String
    // 028 StandbyIntImage                          ModelPrimitiveType int int int Int32
    // 02C StartingIntImage                         ModelPrimitiveType int int int Int32
    // 030 EndIntImage                              ModelPrimitiveType int int int Int32
    public partial class MstStreamProgram : DataModel
    {
        public int                                      Id                                      { get; set; }
        public string                                   Name                                    { get; set; }
        public string                                   Description                             { get; set; }
        public int                                      StandbyIntImage                         { get; set; }
        public int                                      StartingIntImage                        { get; set; }
        public int                                      EndIntImage                             { get; set; }

        public static MstStreamProgram? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstStreamProgram() { Pointer= p0 };

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0x10 Id                          ( ModelPrimitiveType int int int Int32 )
            value.Name                                      = GetString(new IntPtr(p + 0x018)); // 0x18 Name                        ( ModelPrimitiveType string string string String )
            value.Description                               = GetString(new IntPtr(p + 0x020)); // 0x20 Description                 ( ModelPrimitiveType string string string String )
            value.StandbyIntImage                           = GetInt32(new IntPtr(p + 0x028)); // 0x28 StandbyIntImage             ( ModelPrimitiveType int int int Int32 )
            value.StartingIntImage                          = GetInt32(new IntPtr(p + 0x02C)); // 0x2C StartingIntImage            ( ModelPrimitiveType int int int Int32 )
            value.EndIntImage                               = GetInt32(new IntPtr(p + 0x030)); // 0x30 EndIntImage                 ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
