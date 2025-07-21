using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 EmptyView                                ModelClassType PFIdolIconRectEmptyView PFIdolIconRectEmptyView PFIdolIconRectEmptyView Pointer
    // 028 IconView                                 ModelClassType PFIdolIconRectView PFIdolIconRectView PFIdolIconRectView Pointer
    // 030 IconButton                               ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 038 DragMark                                 ModelClassType GameObject GameObject GameObject Pointer
    // 040 FocusMark                                ModelClassType GameObject GameObject GameObject Pointer
    // 048 VocalSeparateObject                      ModelClassType GameObject GameObject GameObject Pointer
    // 050 VocalSeparateEnableObject                ModelClassType GameObject GameObject GameObject Pointer
    // 058 VocalSeparateDisableObject               ModelClassType GameObject GameObject GameObject Pointer
    // 060 LongPressDisposer                        ModelClassType IDisposable IDisposable IDisposable Pointer
    // 068 BonusRate                                ModelPrimitiveType float float float Single
    // 06C IsEmpty                                  ModelPrimitiveType bool bool bool Bool
    // 06D IsInDrag                                 ModelPrimitiveType bool bool bool Bool
    public partial class LiveUnitEditCharacterIcon : DataModel
    {
        public PFIdolIconRectEmptyView?                 EmptyView                               { get; set; }
        public PFIdolIconRectView?                      IconView                                { get; set; }
        public ButtonBase?                              IconButton                              { get; set; }
        public GameObject?                              DragMark                                { get; set; }
        public GameObject?                              FocusMark                               { get; set; }
        public GameObject?                              VocalSeparateObject                     { get; set; }
        public GameObject?                              VocalSeparateEnableObject               { get; set; }
        public GameObject?                              VocalSeparateDisableObject              { get; set; }
        public IDisposable?                             LongPressDisposer                       { get; set; }
        public float                                    BonusRate                               { get; set; }
        public bool                                     IsEmpty                                 { get; set; }
        public bool                                     IsInDrag                                { get; set; }

        public static LiveUnitEditCharacterIcon? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveUnitEditCharacterIcon() { Pointer= p0 };

            value.EmptyView                                 = GetObject<PFIdolIconRectEmptyView>(new IntPtr(p + 0x020), ReversePrism.DataModels.PFIdolIconRectEmptyView.FromPointer); // 0x20 EmptyView                   ( ModelClassType PFIdolIconRectEmptyView PFIdolIconRectEmptyView PFIdolIconRectEmptyView Pointer )
            value.IconView                                  = GetObject<PFIdolIconRectView>(new IntPtr(p + 0x028), ReversePrism.DataModels.PFIdolIconRectView.FromPointer); // 0x28 IconView                    ( ModelClassType PFIdolIconRectView PFIdolIconRectView PFIdolIconRectView Pointer )
            value.IconButton                                = GetObject<ButtonBase>(new IntPtr(p + 0x030), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x30 IconButton                  ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.DragMark                                  = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0x38 DragMark                    ( ModelClassType GameObject GameObject GameObject Pointer )
            value.FocusMark                                 = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0x40 FocusMark                   ( ModelClassType GameObject GameObject GameObject Pointer )
            value.VocalSeparateObject                       = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0x48 VocalSeparateObject         ( ModelClassType GameObject GameObject GameObject Pointer )
            value.VocalSeparateEnableObject                 = GetObject<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 0x50 VocalSeparateEnableObject   ( ModelClassType GameObject GameObject GameObject Pointer )
            value.VocalSeparateDisableObject                = GetObject<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 0x58 VocalSeparateDisableObject  ( ModelClassType GameObject GameObject GameObject Pointer )
            value.LongPressDisposer                         = GetObject<IDisposable>(new IntPtr(p + 0x060), ReversePrism.DataModels.IDisposable.FromPointer); // 0x60 LongPressDisposer           ( ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.BonusRate                                 = GetSingle(new IntPtr(p + 0x068)); // 0x68 BonusRate                   ( ModelPrimitiveType float float float Single )
            value.IsEmpty                                   = GetBool(new IntPtr(p + 0x06C)); // 0x6C IsEmpty                     ( ModelPrimitiveType bool bool bool Bool )
            value.IsInDrag                                  = GetBool(new IntPtr(p + 0x06D)); // 0x6D IsInDrag                    ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
