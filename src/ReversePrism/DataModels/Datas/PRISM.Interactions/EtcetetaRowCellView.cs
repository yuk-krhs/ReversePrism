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
    public partial class EtcetetaRowCellView : DataModel
    {
        public List<EtceteraImage>?                     Images                                  { get; set; }
        public float                                    Height                                  { get; set; }

        public static EtcetetaRowCellView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EtcetetaRowCellView() { Pointer= p0 };

            value.Images                                    = GetObjectList<EtceteraImage>(new IntPtr(p + 0x038), ReversePrism.DataModels.EtceteraImage.FromPointer); // 02466A2FC1F8 0x38 Images                      ( 000185B7C300 ModelClassListType EtceteraImage[] EtceteraImage[] List<EtceteraImage> Pointer )
            value.Height                                    = GetSingle(new IntPtr(p + 0x040)); // 02466A2FC218 0x40 Height                      ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
