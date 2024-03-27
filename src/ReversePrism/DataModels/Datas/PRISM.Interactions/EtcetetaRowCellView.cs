using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 Images                                   000185B7C300 ModelClassListType EtceteraImage[] EtceteraImage[] List<EtceteraImage> Pointer
    // 040 Height                                   0001866656B0 ModelPrimitiveType float float float Single
    public partial class EtcetetaRowCellView
    {
        public List<EtceteraImage>?                     Images                                  { get; set; }
        public float                                    Height                                  { get; set; }

        public static EtcetetaRowCellView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EtcetetaRowCellView();

            value.Images                                    = GetObjectList<EtceteraImage>(new IntPtr(p + 0x038), ReversePrism.DataModels.EtceteraImage.FromPointer); // 0270DA2A8C10 0x38 Images                      ( 000185B7C300 ModelClassListType EtceteraImage[] EtceteraImage[] List<EtceteraImage> Pointer )
            value.Height                                    = GetSingle(new IntPtr(p + 0x040)); // 0270DA2A8C30 0x40 Height                      ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
