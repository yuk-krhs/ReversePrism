using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 058 E1                                       000186670830 ModelClassType DESTransform DESTransform DESTransform Pointer
    // 060 D2                                       000186670830 ModelClassType DESTransform DESTransform DESTransform Pointer
    // 068 E3                                       000186670830 ModelClassType DESTransform DESTransform DESTransform Pointer
    // 070 D1                                       000186670830 ModelClassType DESTransform DESTransform DESTransform Pointer
    // 078 E2                                       000186670830 ModelClassType DESTransform DESTransform DESTransform Pointer
    // 080 D3                                       000186670830 ModelClassType DESTransform DESTransform DESTransform Pointer
    public partial class TripleDESTransform : DataModel
    {
        public DESTransform?                            E1                                      { get; set; }
        public DESTransform?                            D2                                      { get; set; }
        public DESTransform?                            E3                                      { get; set; }
        public DESTransform?                            D1                                      { get; set; }
        public DESTransform?                            E2                                      { get; set; }
        public DESTransform?                            D3                                      { get; set; }

        public static TripleDESTransform? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TripleDESTransform() { Pointer= p0 };

            value.E1                                        = GetObject<DESTransform>(new IntPtr(p + 0x058), ReversePrism.DataModels.DESTransform.FromPointer); // 024666C28E20 0x58 E1                          ( 000186670830 ModelClassType DESTransform DESTransform DESTransform Pointer )
            value.D2                                        = GetObject<DESTransform>(new IntPtr(p + 0x060), ReversePrism.DataModels.DESTransform.FromPointer); // 024666C28E40 0x60 D2                          ( 000186670830 ModelClassType DESTransform DESTransform DESTransform Pointer )
            value.E3                                        = GetObject<DESTransform>(new IntPtr(p + 0x068), ReversePrism.DataModels.DESTransform.FromPointer); // 024666C28E60 0x68 E3                          ( 000186670830 ModelClassType DESTransform DESTransform DESTransform Pointer )
            value.D1                                        = GetObject<DESTransform>(new IntPtr(p + 0x070), ReversePrism.DataModels.DESTransform.FromPointer); // 024666C28E80 0x70 D1                          ( 000186670830 ModelClassType DESTransform DESTransform DESTransform Pointer )
            value.E2                                        = GetObject<DESTransform>(new IntPtr(p + 0x078), ReversePrism.DataModels.DESTransform.FromPointer); // 024666C28EA0 0x78 E2                          ( 000186670830 ModelClassType DESTransform DESTransform DESTransform Pointer )
            value.D3                                        = GetObject<DESTransform>(new IntPtr(p + 0x080), ReversePrism.DataModels.DESTransform.FromPointer); // 024666C28EC0 0x80 D3                          ( 000186670830 ModelClassType DESTransform DESTransform DESTransform Pointer )

            return value;
        }
    }
}
