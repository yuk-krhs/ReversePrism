using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CellData                                 00018665C460 ModelClassType IStoryLastCategoryCellData IStoryLastCategoryCellData IStoryLastCategoryCellData Pointer
    // 018 IsVoicePlayActive                        0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 020 popupViewFactory                         IPopupViewFactory`1<IStoryContinuousPlayConfirmationPopupView> IL2CPP_TYPE_GENERICINST
    public partial class StoryContinuousPlayConfirmationPopupSequencer : DataModel
    {
        public IStoryLastCategoryCellData?              CellData                                { get; set; }
        public bool                                     IsVoicePlayActive                       { get; set; }

        public static StoryContinuousPlayConfirmationPopupSequencer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StoryContinuousPlayConfirmationPopupSequencer() { Pointer= p0 };

            value.CellData                                  = GetObject<IStoryLastCategoryCellData>(new IntPtr(p + 0x010), ReversePrism.DataModels.IStoryLastCategoryCellData.FromPointer); // 024666824F90 0x10 CellData                    ( 00018665C460 ModelClassType IStoryLastCategoryCellData IStoryLastCategoryCellData IStoryLastCategoryCellData Pointer )
            value.IsVoicePlayActive                         = GetBool(new IntPtr(p + 0x018)); // 024666824FB0 0x18 IsVoicePlayActive           ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
