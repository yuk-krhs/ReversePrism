using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Group                                    00018669A8B0 ModelClassType Group Group Group Pointer
    // 018 Capcount                                 0001865F4260 ModelPrimitiveType int int int Int32
    // 020 Captures                                 000185B73600 ModelClassListType Capture[] Capture[] List<Capture> Pointer
    public partial class CaptureCollection
    {
        public Group?                                   Group                                   { get; set; }
        public int                                      Capcount                                { get; set; }
        public List<Capture>?                           Captures                                { get; set; }

        public static CaptureCollection? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CaptureCollection();

            value.Group                                     = GetObject<Group>(new IntPtr(p + 0x010), ReversePrism.DataModels.Group.FromPointer); // 0270D79A07E0 0x10 Group                       ( 00018669A8B0 ModelClassType Group Group Group Pointer )
            value.Capcount                                  = GetInt32(new IntPtr(p + 0x018)); // 0270D79A0800 0x18 Capcount                    ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Captures                                  = GetObjectList<Capture>(new IntPtr(p + 0x020), ReversePrism.DataModels.Capture.FromPointer); // 0270D79A0820 0x20 Captures                    ( 000185B73600 ModelClassListType Capture[] Capture[] List<Capture> Pointer )

            return value;
        }
    }
}
