using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 EmptyObject                              0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 048 Icon                                     0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 050 OnSetMark                                0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 058 LockedObject                             0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 060 LockedTryOnModeObject                    0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 068 DefaultObject                            0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 070 Canceller                                000186724470 ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32
    // 078 IsUnlocked                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 079 IsEmpty                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 07A IsDefault                                000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class CostumeGridViewCell
    {
        public GameObject?                              EmptyObject                             { get; set; }
        public UIRawImage?                              Icon                                    { get; set; }
        public GameObject?                              OnSetMark                               { get; set; }
        public GameObject?                              LockedObject                            { get; set; }
        public GameObject?                              LockedTryOnModeObject                   { get; set; }
        public GameObject?                              DefaultObject                           { get; set; }
        public AutoCancellationTokenSource              Canceller                               { get; set; }
        public bool                                     IsUnlocked                              { get; set; }
        public bool                                     IsEmpty                                 { get; set; }
        public bool                                     IsDefault                               { get; set; }

        public static CostumeGridViewCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CostumeGridViewCell();

            value.EmptyObject                               = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB3AC650 0x40 EmptyObject                 ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.Icon                                      = GetObject<UIRawImage>(new IntPtr(p + 0x048), ReversePrism.DataModels.UIRawImage.FromPointer); // 0270DB3AC670 0x48 Icon                        ( 0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.OnSetMark                                 = GetObject<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB3AC690 0x50 OnSetMark                   ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.LockedObject                              = GetObject<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB3AC6B0 0x58 LockedObject                ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.LockedTryOnModeObject                     = GetObject<GameObject>(new IntPtr(p + 0x060), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB3AC6D0 0x60 LockedTryOnModeObject       ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.DefaultObject                             = GetObject<GameObject>(new IntPtr(p + 0x068), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB3AC6F0 0x68 DefaultObject               ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.Canceller                                 = (AutoCancellationTokenSource)GetInt32(new IntPtr(p + 0x070)); // 0270DB3AC710 0x70 Canceller                   ( 000186724470 ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32 )
            value.IsUnlocked                                = GetBool(new IntPtr(p + 0x078)); // 0270DB3AC730 0x78 IsUnlocked                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsEmpty                                   = GetBool(new IntPtr(p + 0x079)); // 0270DB3AC750 0x79 IsEmpty                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsDefault                                 = GetBool(new IntPtr(p + 0x07A)); // 0270DB3AC770 0x7A IsDefault                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
