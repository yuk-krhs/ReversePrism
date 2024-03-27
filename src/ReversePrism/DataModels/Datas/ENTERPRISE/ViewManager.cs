using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ParentObject                             0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 028 CurrentView                              00018651AA80 ModelClassType ViewBase ViewBase ViewBase Pointer
    // 030 ViewTypeStacks                           000185D30108 ModelClassListType List`1<ViewValue> List`1<ViewValue> List<ViewValue> Pointer
    // 038 IsChangeViewFlg                          000186594D10 ModelPrimitiveType bool bool bool Bool
    // 040 NextView                                 00018651AA80 ModelClassType ViewBase ViewBase ViewBase Pointer
    // 048 ForceChangeCTS                           0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 050 ExternalFinishChangeViewProcess          Func`1<UniTask> IL2CPP_TYPE_GENERICINST
    // 058 ExternalFadeOutProcess                   Func`2<int, UniTask> IL2CPP_TYPE_GENERICINST
    // 060 ExternalFadeInProcess                    Func`1<UniTask> IL2CPP_TYPE_GENERICINST
    // 068 ExternalErrorProcess                     Func`2<Exception, UniTask> IL2CPP_TYPE_GENERICINST
    // 070 ExternalAssetBundleLoadProcess           Func`2<Type, UniTask`1<ViewBase>> IL2CPP_TYPE_GENERICINST
    // 078 ExternalBeforeLoadProcess                Func`1<UniTask> IL2CPP_TYPE_GENERICINST
    public partial class ViewManager
    {
        public GameObject?                              ParentObject                            { get; set; }
        public ViewBase?                                CurrentView                             { get; set; }
        public List<ViewValue>?                         ViewTypeStacks                          { get; set; }
        public bool                                     IsChangeViewFlg                         { get; set; }
        public ViewBase?                                NextView                                { get; set; }
        public CancellationTokenSource?                 ForceChangeCTS                          { get; set; }

        public static ViewManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ViewManager();

            value.ParentObject                              = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0270D0A64168 0x20 ParentObject                ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.CurrentView                               = GetObject<ViewBase>(new IntPtr(p + 0x028), ReversePrism.DataModels.ViewBase.FromPointer); // 0270D0A64188 0x28 CurrentView                 ( 00018651AA80 ModelClassType ViewBase ViewBase ViewBase Pointer )
            value.ViewTypeStacks                            = GetObjectList<ViewValue>(new IntPtr(p + 0x030), ReversePrism.DataModels.ViewValue.FromPointer); // 0270D0A641A8 0x30 ViewTypeStacks              ( 000185D30108 ModelClassListType List`1<ViewValue> List`1<ViewValue> List<ViewValue> Pointer )
            value.IsChangeViewFlg                           = GetBool(new IntPtr(p + 0x038)); // 0270D0A641C8 0x38 IsChangeViewFlg             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.NextView                                  = GetObject<ViewBase>(new IntPtr(p + 0x040), ReversePrism.DataModels.ViewBase.FromPointer); // 0270D0A641E8 0x40 NextView                    ( 00018651AA80 ModelClassType ViewBase ViewBase ViewBase Pointer )
            value.ForceChangeCTS                            = GetObject<CancellationTokenSource>(new IntPtr(p + 0x048), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0270D0A64208 0x48 ForceChangeCTS              ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )

            return value;
        }
    }
}
