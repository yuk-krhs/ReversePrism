using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CellData                                 ModelClassType IStoryLastCategoryCellData IStoryLastCategoryCellData IStoryLastCategoryCellData Pointer
    // 018 MainMessageText                          ModelPrimitiveType string string string String
    // 020 DownloadRecommendationText               ModelPrimitiveType string string string String
    // 028 IsVoicePlayActive                        ModelPrimitiveType bool bool bool Bool
    public partial class StoryContinuousPlayConfirmationPopupViewModel : DataModel
    {
        public IStoryLastCategoryCellData?              CellData                                { get; set; }
        public string                                   MainMessageText                         { get; set; }
        public string                                   DownloadRecommendationText              { get; set; }
        public bool                                     IsVoicePlayActive                       { get; set; }

        public static StoryContinuousPlayConfirmationPopupViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StoryContinuousPlayConfirmationPopupViewModel() { Pointer= p0 };

            value.CellData                                  = GetObject<IStoryLastCategoryCellData>(new IntPtr(p + 0x010), ReversePrism.DataModels.IStoryLastCategoryCellData.FromPointer); // 0x10 CellData                    ( ModelClassType IStoryLastCategoryCellData IStoryLastCategoryCellData IStoryLastCategoryCellData Pointer )
            value.MainMessageText                           = GetString(new IntPtr(p + 0x018)); // 0x18 MainMessageText             ( ModelPrimitiveType string string string String )
            value.DownloadRecommendationText                = GetString(new IntPtr(p + 0x020)); // 0x20 DownloadRecommendationText  ( ModelPrimitiveType string string string String )
            value.IsVoicePlayActive                         = GetBool(new IntPtr(p + 0x028)); // 0x28 IsVoicePlayActive           ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
