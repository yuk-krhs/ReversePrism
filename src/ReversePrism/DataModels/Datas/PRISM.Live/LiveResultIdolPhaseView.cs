using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 058 IdolViews                                000185B912F0 ModelClassListType LiveResultIdolView[] LiveResultIdolView[] List<LiveResultIdolView> Pointer
    public partial class LiveResultIdolPhaseView : DataModel
    {
        public List<LiveResultIdolView>?                IdolViews                               { get; set; }

        public static LiveResultIdolPhaseView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveResultIdolPhaseView() { Pointer= p0 };

            value.IdolViews                                 = GetObjectList<LiveResultIdolView>(new IntPtr(p + 0x058), ReversePrism.DataModels.LiveResultIdolView.FromPointer); // 0246652AD300 0x58 IdolViews                   ( 000185B912F0 ModelClassListType LiveResultIdolView[] LiveResultIdolView[] List<LiveResultIdolView> Pointer )

            return value;
        }
    }
}
