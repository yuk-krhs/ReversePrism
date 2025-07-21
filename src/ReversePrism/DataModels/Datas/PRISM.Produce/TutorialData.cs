using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 TutorialParams                           ModelClassListType List`1<TutorialParam> List`1<TutorialParam> List<TutorialParam> Pointer
    public partial class TutorialData : DataModel
    {
        public List<TutorialParam>?                     TutorialParams                          { get; set; }

        public static TutorialData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TutorialData() { Pointer= p0 };

            value.TutorialParams                            = GetObjectList<TutorialParam>(new IntPtr(p + 0x018), ReversePrism.DataModels.TutorialParam.FromPointer); // 0x18 TutorialParams              ( ModelClassListType List`1<TutorialParam> List`1<TutorialParam> List<TutorialParam> Pointer )

            return value;
        }
    }
}
