using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Group                                    ModelClassType Group Group Group Pointer
    // 018 Capcount                                 ModelPrimitiveType int int int Int32
    // 020 Captures                                 ModelClassListType Capture[] Capture[] List<Capture> Pointer
    public partial class CaptureCollection : DataModel
    {
        public Group?                                   Group                                   { get; set; }
        public int                                      Capcount                                { get; set; }
        public List<Capture>?                           Captures                                { get; set; }

        public static CaptureCollection? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CaptureCollection() { Pointer= p0 };

            value.Group                                     = GetObject<Group>(new IntPtr(p + 0x010), ReversePrism.DataModels.Group.FromPointer); // 0x10 Group                       ( ModelClassType Group Group Group Pointer )
            value.Capcount                                  = GetInt32(new IntPtr(p + 0x018)); // 0x18 Capcount                    ( ModelPrimitiveType int int int Int32 )
            value.Captures                                  = GetObjectList<Capture>(new IntPtr(p + 0x020), ReversePrism.DataModels.Capture.FromPointer); // 0x20 Captures                    ( ModelClassListType Capture[] Capture[] List<Capture> Pointer )

            return value;
        }
    }
}
