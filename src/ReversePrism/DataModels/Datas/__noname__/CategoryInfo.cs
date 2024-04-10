using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Cursor                                   000186671910 ModelPrimitiveType string string string String
    // 018 AnnounceStatusList                       000185CE0D38 ModelClassListType List`1<IAnnounceStatus> List`1<IAnnounceStatus> List<IAnnounceStatus> Pointer
    public partial class CategoryInfo : DataModel
    {
        public string                                   Cursor                                  { get; set; }
        public List<IAnnounceStatus>?                   AnnounceStatusList                      { get; set; }

        public static CategoryInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CategoryInfo() { Pointer= p0 };

            value.Cursor                                    = GetString(new IntPtr(p + 0x010)); // 0245A71C6468 0x10 Cursor                      ( 000186671910 ModelPrimitiveType string string string String )
            value.AnnounceStatusList                        = GetObjectList<IAnnounceStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.IAnnounceStatus.FromPointer); // 0245A71C6488 0x18 AnnounceStatusList          ( 000185CE0D38 ModelClassListType List`1<IAnnounceStatus> List`1<IAnnounceStatus> List<IAnnounceStatus> Pointer )

            return value;
        }
    }
}
