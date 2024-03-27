using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 _SwitchObject                            000185CC3DE8 ModelClassListType SwitchObjectData[] SwitchObjectData[] List<SwitchObjectData> Pointer
    public partial class SwitchObject
    {
        public List<SwitchObjectData>?                  _SwitchObject                           { get; set; }

        public static SwitchObject? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SwitchObject();

            value._SwitchObject                             = GetObjectList<SwitchObjectData>(new IntPtr(p + 0x020), ReversePrism.DataModels.SwitchObjectData.FromPointer); // 0270D4D5CA40 0x20 _SwitchObject               ( 000185CC3DE8 ModelClassListType SwitchObjectData[] SwitchObjectData[] List<SwitchObjectData> Pointer )

            return value;
        }
    }
}
