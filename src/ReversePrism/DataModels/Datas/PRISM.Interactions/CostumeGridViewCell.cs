using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 EmptyObject                              ModelClassType GameObject GameObject GameObject Pointer
    // 048 Icon                                     ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 050 OnSetMark                                ModelClassType GameObject GameObject GameObject Pointer
    // 058 LockedObject                             ModelClassType GameObject GameObject GameObject Pointer
    // 060 LockedTryOnModeObject                    ModelClassType GameObject GameObject GameObject Pointer
    // 068 DefaultObject                            ModelClassType GameObject GameObject GameObject Pointer
    // 070 CanDressOrderObject                      ModelClassType GameObject GameObject GameObject Pointer
    // 078 CanNotDressOrderObject                   ModelClassType GameObject GameObject GameObject Pointer
    // 080 Canceller                                ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32
    // 088 IsUnlocked                               ModelPrimitiveType bool bool bool Bool
    // 089 IsEmpty                                  ModelPrimitiveType bool bool bool Bool
    // 08A IsDefault                                ModelPrimitiveType bool bool bool Bool
    // 08C CostumeCategory                          ModelEnumType CostumeCategory CostumeCategory CostumeCategory Int32
    // 090 MyCostume                                ModelPrimitiveType bool bool bool Bool
    // 091 CanDressOrder                            ModelPrimitiveType bool bool bool Bool
    public partial class CostumeGridViewCell : DataModel
    {
        public GameObject?                              EmptyObject                             { get; set; }
        public UIRawImage?                              Icon                                    { get; set; }
        public GameObject?                              OnSetMark                               { get; set; }
        public GameObject?                              LockedObject                            { get; set; }
        public GameObject?                              LockedTryOnModeObject                   { get; set; }
        public GameObject?                              DefaultObject                           { get; set; }
        public GameObject?                              CanDressOrderObject                     { get; set; }
        public GameObject?                              CanNotDressOrderObject                  { get; set; }
        public AutoCancellationTokenSource              Canceller                               { get; set; }
        public bool                                     IsUnlocked                              { get; set; }
        public bool                                     IsEmpty                                 { get; set; }
        public bool                                     IsDefault                               { get; set; }
        public CostumeCategory                          CostumeCategory                         { get; set; }
        public bool                                     MyCostume                               { get; set; }
        public bool                                     CanDressOrder                           { get; set; }

        public static CostumeGridViewCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CostumeGridViewCell() { Pointer= p0 };

            value.EmptyObject                               = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0x40 EmptyObject                 ( ModelClassType GameObject GameObject GameObject Pointer )
            value.Icon                                      = GetObject<UIRawImage>(new IntPtr(p + 0x048), ReversePrism.DataModels.UIRawImage.FromPointer); // 0x48 Icon                        ( ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.OnSetMark                                 = GetObject<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 0x50 OnSetMark                   ( ModelClassType GameObject GameObject GameObject Pointer )
            value.LockedObject                              = GetObject<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 0x58 LockedObject                ( ModelClassType GameObject GameObject GameObject Pointer )
            value.LockedTryOnModeObject                     = GetObject<GameObject>(new IntPtr(p + 0x060), ReversePrism.DataModels.GameObject.FromPointer); // 0x60 LockedTryOnModeObject       ( ModelClassType GameObject GameObject GameObject Pointer )
            value.DefaultObject                             = GetObject<GameObject>(new IntPtr(p + 0x068), ReversePrism.DataModels.GameObject.FromPointer); // 0x68 DefaultObject               ( ModelClassType GameObject GameObject GameObject Pointer )
            value.CanDressOrderObject                       = GetObject<GameObject>(new IntPtr(p + 0x070), ReversePrism.DataModels.GameObject.FromPointer); // 0x70 CanDressOrderObject         ( ModelClassType GameObject GameObject GameObject Pointer )
            value.CanNotDressOrderObject                    = GetObject<GameObject>(new IntPtr(p + 0x078), ReversePrism.DataModels.GameObject.FromPointer); // 0x78 CanNotDressOrderObject      ( ModelClassType GameObject GameObject GameObject Pointer )
            value.Canceller                                 = (AutoCancellationTokenSource)GetInt32(new IntPtr(p + 0x080)); // 0x80 Canceller                   ( ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32 )
            value.IsUnlocked                                = GetBool(new IntPtr(p + 0x088)); // 0x88 IsUnlocked                  ( ModelPrimitiveType bool bool bool Bool )
            value.IsEmpty                                   = GetBool(new IntPtr(p + 0x089)); // 0x89 IsEmpty                     ( ModelPrimitiveType bool bool bool Bool )
            value.IsDefault                                 = GetBool(new IntPtr(p + 0x08A)); // 0x8A IsDefault                   ( ModelPrimitiveType bool bool bool Bool )
            value.CostumeCategory                           = (CostumeCategory)GetInt32(new IntPtr(p + 0x08C)); // 0x8C CostumeCategory             ( ModelEnumType CostumeCategory CostumeCategory CostumeCategory Int32 )
            value.MyCostume                                 = GetBool(new IntPtr(p + 0x090)); // 0x90 MyCostume                   ( ModelPrimitiveType bool bool bool Bool )
            value.CanDressOrder                             = GetBool(new IntPtr(p + 0x091)); // 0x91 CanDressOrder               ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
