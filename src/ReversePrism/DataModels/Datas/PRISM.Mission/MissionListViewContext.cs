using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 OnClickButton                            Action`1<int> IL2CPP_TYPE_GENERICINST
    // 040 LastDisplayDate                          000185D00A78 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 050 ResourceTagName                          0001866722E0 ModelPrimitiveType string string string String
    public partial class MissionListViewContext : DataModel
    {
        public DateTime                                 LastDisplayDate                         { get; set; }
        public string                                   ResourceTagName                         { get; set; }

        public static MissionListViewContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MissionListViewContext() { Pointer= p0 };

            value.LastDisplayDate                           = GetDateTime(new IntPtr(p + 0x040)); // 0246655C7770 0x40 LastDisplayDate             ( 000185D00A78 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.ResourceTagName                           = GetString(new IntPtr(p + 0x050)); // 0246655C7790 0x50 ResourceTagName             ( 0001866722E0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
