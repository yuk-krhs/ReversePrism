using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 OnClickButton                            Action`1<int> IL2CPP_TYPE_GENERICINST
    // 048 LastDisplayDate                          ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 058 ResourceTagName                          ModelPrimitiveType string string string String
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

            value.LastDisplayDate                           = GetDateTime(new IntPtr(p + 0x048)); // 0x48 LastDisplayDate             ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.ResourceTagName                           = GetString(new IntPtr(p + 0x058)); // 0x58 ResourceTagName             ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
