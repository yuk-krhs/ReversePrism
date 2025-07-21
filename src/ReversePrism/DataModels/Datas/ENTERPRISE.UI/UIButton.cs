using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 1E0 MImageSet                                ModelClassListType ImageSetInformation[] ImageSetInformation[] List<ImageSetInformation> Pointer
    // 1E8 MTextSet                                 ModelClassListType TextSetInformation[] TextSetInformation[] List<TextSetInformation> Pointer
    public partial class UIButton : DataModel
    {
        public List<ImageSetInformation>?               MImageSet                               { get; set; }
        public List<TextSetInformation>?                MTextSet                                { get; set; }

        public static UIButton? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UIButton() { Pointer= p0 };

            value.MImageSet                                 = GetObjectList<ImageSetInformation>(new IntPtr(p + 0x1E0), ReversePrism.DataModels.ImageSetInformation.FromPointer); // 0x1E0 MImageSet                   ( ModelClassListType ImageSetInformation[] ImageSetInformation[] List<ImageSetInformation> Pointer )
            value.MTextSet                                  = GetObjectList<TextSetInformation>(new IntPtr(p + 0x1E8), ReversePrism.DataModels.TextSetInformation.FromPointer); // 0x1E8 MTextSet                    ( ModelClassListType TextSetInformation[] TextSetInformation[] List<TextSetInformation> Pointer )

            return value;
        }
    }
}
